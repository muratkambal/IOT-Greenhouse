#include "esp_camera.h"
#include "FS.h"
#include "SPI.h"
#include "SD.h"
#include "EEPROM.h"
#include "driver/rtc_io.h"
#include "ESP32_MailClient.h"
#define CAMERA_MODEL_AI_THINKER

#include "camera_pins.h"

#define ID_ADDRESS            0x00
#define COUNT_ADDRESS         0x01
#define ID_BYTE               0xAA
#define EEPROM_SIZE           0x0F

uint16_t nextImageNumber = 0;

#define WIFI_SSID             "********"                    // Kameranın bağlanacağı wifi.
#define WIFI_PASSWORD         "*******"                   // Kameranın bağlanacağı wifi şifresi 
#define emailSenderAccount    "****************"                 // e-mail gönderimi için gmail port 465
#define emailSenderPassword   "****************"                    // e-mail şifresi.

#define emailRecipient        "************"   

SMTPData smtpData; // wifi nesnesi
void sendCallback(SendStatus info);

void setup() 
{
  Serial.begin(115200); // opens the serial port
  Serial.println();
  Serial.println("Booting...");

  //WiFi Bağlantısı
  Serial.print("Connecting to AP");
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD); 
  while (WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(200);
  }
// wifi baglantisi
  Serial.println("");
  Serial.println("WiFi connected.");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  Serial.println();
    //kamera ayarlari
  camera_config_t config;
  config.ledc_channel = LEDC_CHANNEL_0;
  config.ledc_timer = LEDC_TIMER_0;
  config.pin_d0 = Y2_GPIO_NUM;
  config.pin_d1 = Y3_GPIO_NUM;
  config.pin_d2 = Y4_GPIO_NUM;
  config.pin_d3 = Y5_GPIO_NUM;
  config.pin_d4 = Y6_GPIO_NUM;
  config.pin_d5 = Y7_GPIO_NUM;
  config.pin_d6 = Y8_GPIO_NUM;
  config.pin_d7 = Y9_GPIO_NUM;
  config.pin_xclk = XCLK_GPIO_NUM;
  config.pin_pclk = PCLK_GPIO_NUM;
  config.pin_vsync = VSYNC_GPIO_NUM;
  config.pin_href = HREF_GPIO_NUM;
  config.pin_sscb_sda = SIOD_GPIO_NUM;
  config.pin_sscb_scl = SIOC_GPIO_NUM;
  config.pin_pwdn = PWDN_GPIO_NUM;
  config.pin_reset = RESET_GPIO_NUM;
  config.xclk_freq_hz = 20000000;
  config.pixel_format = PIXFORMAT_JPEG;
  
 
  if(psramFound())
  {
    config.frame_size = FRAMESIZE_UXGA;
    config.jpeg_quality = 10;
    config.fb_count = 2;
  } else 
  {
    config.frame_size = FRAMESIZE_SVGA;
    config.jpeg_quality = 12;
    config.fb_count = 1;
  }
  
  //kamera baslatiliyor
  esp_err_t err = esp_camera_init(&config);
  if (err != ESP_OK) 
  {
    Serial.printf("Camera init failed with error 0x%x", err);
    return;
  }

  //Kamera parametreleri
  sensor_t * s = esp_camera_sensor_get();
  s->set_contrast(s, 2);    //min=-2, max=2
  s->set_brightness(s, 2);  //min=-2, max=2
  s->set_saturation(s, 2);  //min=-2, max=2
  delay(100);               //wait a little for settings to take effect
  
  //SD kart
  Serial.println("Mounting SD Card...");
  MailClient.sdBegin(14,2,15,13);

  if(!SD.begin())
  {
    Serial.println("Card Mount Failed");
    return;
  }

  // EEPROM'u başlatıyoruz
  if (!EEPROM.begin(EEPROM_SIZE))
  {
    Serial.println("Failed to initialise EEPROM"); 
    Serial.println("Exiting now"); 
    while(1);     
  
  if(EEPROM.read(ID_ADDRESS) != ID_BYTE)    //Eğer geçerli bir resim degilse
  {
    Serial.println("Initializing ID byte & restarting picture count");
    nextImageNumber = 0;
    EEPROM.write(ID_ADDRESS, ID_BYTE);  
    EEPROM.commit(); 
  }
  else                                      // resim numarasını geçerli olana kadar bir sonrakini alarak değiştiriyoruz.
  {
    EEPROM.get(COUNT_ADDRESS, nextImageNumber);
    nextImageNumber +=  1;    
    Serial.print("Next image number:");
    Serial.println(nextImageNumber);
  }

  // Yeni bir fotoğraf karesi alınıyor.
  camera_fb_t * fb = NULL;
    
  // Kameranın frame buffer bilgisi alınıyor.
  fb = esp_camera_fb_get();
  if (!fb) 
  {
    Serial.println("Camera capture failed");
    Serial.println("Exiting now"); 
    while(1);   // Bir hata oluştuysa bu satırda bekleniyor.
  }

  //Fotoğraf SD karta kaydediliyor.
  //Fotoğraf için veri yolu ve isim oluşturuluyor.
  String path = "/IMG" + String(nextImageNumber) + ".jpg";
    
  fs::FS &fs = SD;

  //Yeni bir dosya oluşturuluyor.
  File file = fs.open(path.c_str(), FILE_WRITE);
  if(!file)
  {
    Serial.println("Failed to create file");
    Serial.println("Exiting now"); 
    while(1);   // hata  varsa bekliyor    
  } 
  else 
  {
    file.write(fb->buf, fb->len); 
    EEPROM.put(COUNT_ADDRESS, nextImageNumber);
    EEPROM.commit();
  }
  file.close();

  //Kameranın bilgisi gonderiliyor
  esp_camera_fb_return(fb);
  Serial.printf("Image saved: %s\n", path.c_str());

  //E-posta gönderimi
  Serial.println("Sending email...");
  //E-posta bilgileri
  smtpData.setLogin("smtp.gmail.com", 465, emailSenderAccount, emailSenderPassword);
  
  //E-posta gonderenin ismi
  smtpData.setSender("ESP32-CAM", emailSenderAccount);
  
  //E-posta önceliğini 
  smtpData.setPriority("High");

  //E-postanın konusu
  smtpData.setSubject("Someone is trying to enter your greenhouse.");
    
  //E-posta metninin yapisi
  smtpData.setMessage("<div style=\"color:#003366;font-size:20px;\">Image captured and attached.</div>", true);

  //E-postanın gondrilecegi adres
  smtpData.addRecipient(emailRecipient);
  
  //E-postaya SD karttan fotoğraf ekliyoruz
  smtpData.addAttachFile(path);
  
  // sd kart tipini sd yapiyoruz
  smtpData.setFileStorageType(MailClientStorageType::SD);
  
  smtpData.setSendCallback(sendCallback);
  
  //E-posta gönderimi 
  if (!MailClient.sendMail(smtpData))
    Serial.println("Error sending Email, " + MailClient.smtpErrorReason());

  //e posta gonderildikten sonra veriler temizleniyor
  smtpData.empty();
  Serial.flush(); 
  esp_sleep_enable_ext0_wakeup(GPIO_NUM_13, 0);   
  delay(2000);                                   
  esp_deep_sleep_start();
}

void loop() 
{


}

//e posta durumu kontrol ediyor
void sendCallback(SendStatus msg)
{
  //seri ekrana yazdiriliyor
  Serial.println(msg.info());

  //seri port ekranina basarili yazdiriliyor
  if (msg.success())
  {
  }
}
