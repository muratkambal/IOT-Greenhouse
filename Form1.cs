using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace greenhouse
{
    public partial class Form1 : Form
    {
        string[]   portlar = SerialPort.GetPortNames();
        SerialPort portum = new System.IO.Ports.SerialPort();
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;

        private void doorgroup_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            humgroup.Enabled = false;
            fangroup.Enabled = false;
            lightgroup.Enabled = false;
            doorgroup.Enabled = false;




            string[] Portlar = SerialPort.GetPortNames();
            foreach (string port in Portlar)
            {
                selectport.Items.Add(port);
            }
        }

        private void humgroup_Enter(object sender, EventArgs e)
        {

        }

        private void lightgroup_Enter(object sender, EventArgs e)
        {

        }

        private void fangroup_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (portum.IsOpen == false)
            {
                if (selectport.Text == "")
                    return;
                portum.BaudRate = 115200;
                portum.PortName = selectport.SelectedItem.ToString();
                try
                {
                    portum.Open();
                    label1.Text = "PORT IS OPEN";
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);

                }


            }
            else
            {
                label1.Text = "SERIAL PORT CONNECTED";
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            humgroup.Enabled = false;
            fangroup.Enabled = false;
            lightgroup.Enabled = false;
            doorgroup.Enabled = false;

            timer1.Stop();
            if (portum.IsOpen == true)
            {
                portum.Close();
                label1.Text = "SERIAL PORT CLOSED";
            }
        }

        private void portgroup_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (portum.IsOpen == true)
            {
                portum.Close();
                label3.Text = "Port is closed";
            }
        }
        private void hmbtn_Click(object sender, EventArgs e)
        {
            portum.Write("B");
        }

        private void hlbtn_Click(object sender, EventArgs e)
        {
            portum.Write("A");
        }

        private void hhbtn_Click(object sender, EventArgs e)
        {
            portum.Write("C");
        }

        private void flbtn_Click(object sender, EventArgs e)
        {
            portum.Write("G");
        }

        private void fmbtn_Click(object sender, EventArgs e)
        {
            portum.Write("H");

        }

        private void fhbtn_Click(object sender, EventArgs e)
        {
            portum.Write("I");

        }

        private void llbtn_Click(object sender, EventArgs e)
        {
            portum.Write("D");
        }

        private void lmbtn_Click(object sender, EventArgs e)
        {
            portum.Write("E");
        }

        private void lhbtn_Click(object sender, EventArgs e)
        {
            portum.Write("F");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void opndoorbtn_Click(object sender, EventArgs e)
        {
            portum.Write("J");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (portum.IsOpen == true)
            {

                humgroup.Enabled = true;
                fangroup.Enabled = true;
                lightgroup.Enabled = true;
                doorgroup.Enabled = true;
            }
            try
            {
                string sonuc = portum.ReadExisting();
                string[] sonuclar = sonuc.Split(' ');

                int a0 = (4096 - (Convert.ToInt32(sonuclar[0]))) * 100 / 1023;
                int a1 = ((Convert.ToInt32(sonuclar[1]))) / 10;
                float a2 = (1023 - (Convert.ToInt32(sonuclar[2]))) * 100 / 1023;
                int a3 = ((Convert.ToInt32(sonuclar[3])));




                humlbl.Text = a2.ToString();
                templbl.Text = a1.ToString();
                lightlbl.Text = a0.ToString();
                if (a3 > 1)
                {
                    doorlbl.Text = "Door is Opened";
                }
                else
                {
                    doorlbl.Text = "Door is Closed";
                }
   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void humlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            portum.Write("L");

        }

        private void tempclose_Click(object sender, EventArgs e)
        {
            portum.Write("M");
        }

        private void closedoorbtn_Click(object sender, EventArgs e)
        {
            portum.Write("K");

        }

        private void doorlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
