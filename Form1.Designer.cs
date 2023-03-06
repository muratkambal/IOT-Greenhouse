namespace greenhouse
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fangroup = new System.Windows.Forms.GroupBox();
            this.humclose = new System.Windows.Forms.Button();
            this.templbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fhbtn = new System.Windows.Forms.Button();
            this.fmbtn = new System.Windows.Forms.Button();
            this.flbtn = new System.Windows.Forms.Button();
            this.lightgroup = new System.Windows.Forms.GroupBox();
            this.humlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hhbtn = new System.Windows.Forms.Button();
            this.hmbtn = new System.Windows.Forms.Button();
            this.hlbtn = new System.Windows.Forms.Button();
            this.humgroup = new System.Windows.Forms.GroupBox();
            this.tempclose = new System.Windows.Forms.Button();
            this.lightlbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lhbtn = new System.Windows.Forms.Button();
            this.lmbtn = new System.Windows.Forms.Button();
            this.llbtn = new System.Windows.Forms.Button();
            this.doorgroup = new System.Windows.Forms.GroupBox();
            this.doorlbl = new System.Windows.Forms.Label();
            this.closedoorbtn = new System.Windows.Forms.Button();
            this.opndoorbtn = new System.Windows.Forms.Button();
            this.closeportbtn = new System.Windows.Forms.Button();
            this.openportbtn = new System.Windows.Forms.Button();
            this.selectport = new System.Windows.Forms.ComboBox();
            this.portgroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fangroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.lightgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.humgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.doorgroup.SuspendLayout();
            this.portgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fangroup
            // 
            this.fangroup.BackColor = System.Drawing.SystemColors.Info;
            this.fangroup.Controls.Add(this.humclose);
            this.fangroup.Controls.Add(this.templbl);
            this.fangroup.Controls.Add(this.pictureBox2);
            this.fangroup.Controls.Add(this.fhbtn);
            this.fangroup.Controls.Add(this.fmbtn);
            this.fangroup.Controls.Add(this.flbtn);
            this.fangroup.Location = new System.Drawing.Point(500, 47);
            this.fangroup.Name = "fangroup";
            this.fangroup.Size = new System.Drawing.Size(199, 437);
            this.fangroup.TabIndex = 0;
            this.fangroup.TabStop = false;
            this.fangroup.Text = "Temperature Control";
            this.fangroup.Enter += new System.EventHandler(this.fangroup_Enter);
            // 
            // humclose
            // 
            this.humclose.BackColor = System.Drawing.Color.Red;
            this.humclose.Location = new System.Drawing.Point(6, 385);
            this.humclose.Name = "humclose";
            this.humclose.Size = new System.Drawing.Size(187, 35);
            this.humclose.TabIndex = 12;
            this.humclose.Text = "CLOSE";
            this.humclose.UseVisualStyleBackColor = false;
            this.humclose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // templbl
            // 
            this.templbl.AutoSize = true;
            this.templbl.BackColor = System.Drawing.Color.OliveDrab;
            this.templbl.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.templbl.Location = new System.Drawing.Point(2, 195);
            this.templbl.Name = "templbl";
            this.templbl.Size = new System.Drawing.Size(151, 22);
            this.templbl.TabIndex = 12;
            this.templbl.Text = "TEMPERATURE: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // fhbtn
            // 
            this.fhbtn.BackColor = System.Drawing.Color.Yellow;
            this.fhbtn.Location = new System.Drawing.Point(6, 337);
            this.fhbtn.Name = "fhbtn";
            this.fhbtn.Size = new System.Drawing.Size(187, 42);
            this.fhbtn.TabIndex = 2;
            this.fhbtn.Text = "HIGH";
            this.fhbtn.UseVisualStyleBackColor = false;
            this.fhbtn.Click += new System.EventHandler(this.fhbtn_Click);
            // 
            // fmbtn
            // 
            this.fmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fmbtn.Location = new System.Drawing.Point(6, 289);
            this.fmbtn.Name = "fmbtn";
            this.fmbtn.Size = new System.Drawing.Size(187, 42);
            this.fmbtn.TabIndex = 1;
            this.fmbtn.Text = "MEDIUM";
            this.fmbtn.UseVisualStyleBackColor = false;
            this.fmbtn.Click += new System.EventHandler(this.fmbtn_Click);
            // 
            // flbtn
            // 
            this.flbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flbtn.Location = new System.Drawing.Point(6, 241);
            this.flbtn.Name = "flbtn";
            this.flbtn.Size = new System.Drawing.Size(187, 42);
            this.flbtn.TabIndex = 0;
            this.flbtn.Text = "LOW";
            this.flbtn.UseVisualStyleBackColor = false;
            this.flbtn.Click += new System.EventHandler(this.flbtn_Click);
            // 
            // lightgroup
            // 
            this.lightgroup.BackColor = System.Drawing.SystemColors.Info;
            this.lightgroup.Controls.Add(this.humlbl);
            this.lightgroup.Controls.Add(this.pictureBox1);
            this.lightgroup.Controls.Add(this.hhbtn);
            this.lightgroup.Controls.Add(this.hmbtn);
            this.lightgroup.Controls.Add(this.hlbtn);
            this.lightgroup.Location = new System.Drawing.Point(285, 47);
            this.lightgroup.Name = "lightgroup";
            this.lightgroup.Size = new System.Drawing.Size(209, 437);
            this.lightgroup.TabIndex = 1;
            this.lightgroup.TabStop = false;
            this.lightgroup.Text = "Humidity Control";
            this.lightgroup.Enter += new System.EventHandler(this.lightgroup_Enter);
            // 
            // humlbl
            // 
            this.humlbl.AutoSize = true;
            this.humlbl.BackColor = System.Drawing.Color.OliveDrab;
            this.humlbl.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.humlbl.Location = new System.Drawing.Point(6, 195);
            this.humlbl.Name = "humlbl";
            this.humlbl.Size = new System.Drawing.Size(95, 20);
            this.humlbl.TabIndex = 11;
            this.humlbl.Text = "HUMIDITY: ";
            this.humlbl.Click += new System.EventHandler(this.humlbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hhbtn
            // 
            this.hhbtn.BackColor = System.Drawing.Color.Yellow;
            this.hhbtn.Location = new System.Drawing.Point(6, 337);
            this.hhbtn.Name = "hhbtn";
            this.hhbtn.Size = new System.Drawing.Size(187, 42);
            this.hhbtn.TabIndex = 9;
            this.hhbtn.Text = "HIGH";
            this.hhbtn.UseVisualStyleBackColor = false;
            this.hhbtn.Click += new System.EventHandler(this.hhbtn_Click);
            // 
            // hmbtn
            // 
            this.hmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hmbtn.Location = new System.Drawing.Point(6, 289);
            this.hmbtn.Name = "hmbtn";
            this.hmbtn.Size = new System.Drawing.Size(187, 42);
            this.hmbtn.TabIndex = 0;
            this.hmbtn.Text = "MEDIUM";
            this.hmbtn.UseVisualStyleBackColor = false;
            this.hmbtn.Click += new System.EventHandler(this.hmbtn_Click);
            // 
            // hlbtn
            // 
            this.hlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hlbtn.Location = new System.Drawing.Point(6, 241);
            this.hlbtn.Name = "hlbtn";
            this.hlbtn.Size = new System.Drawing.Size(187, 42);
            this.hlbtn.TabIndex = 8;
            this.hlbtn.Text = "LOW";
            this.hlbtn.UseVisualStyleBackColor = false;
            this.hlbtn.Click += new System.EventHandler(this.hlbtn_Click);
            // 
            // humgroup
            // 
            this.humgroup.BackColor = System.Drawing.SystemColors.Info;
            this.humgroup.Controls.Add(this.tempclose);
            this.humgroup.Controls.Add(this.lightlbl);
            this.humgroup.Controls.Add(this.pictureBox3);
            this.humgroup.Controls.Add(this.lhbtn);
            this.humgroup.Controls.Add(this.lmbtn);
            this.humgroup.Controls.Add(this.llbtn);
            this.humgroup.Location = new System.Drawing.Point(705, 47);
            this.humgroup.Name = "humgroup";
            this.humgroup.Size = new System.Drawing.Size(212, 437);
            this.humgroup.TabIndex = 2;
            this.humgroup.TabStop = false;
            this.humgroup.Text = "Light Control";
            this.humgroup.Enter += new System.EventHandler(this.humgroup_Enter);
            // 
            // tempclose
            // 
            this.tempclose.BackColor = System.Drawing.Color.Red;
            this.tempclose.Location = new System.Drawing.Point(6, 385);
            this.tempclose.Name = "tempclose";
            this.tempclose.Size = new System.Drawing.Size(200, 35);
            this.tempclose.TabIndex = 13;
            this.tempclose.Text = "CLOSE";
            this.tempclose.UseVisualStyleBackColor = false;
            this.tempclose.Click += new System.EventHandler(this.tempclose_Click);
            // 
            // lightlbl
            // 
            this.lightlbl.AutoSize = true;
            this.lightlbl.BackColor = System.Drawing.Color.OliveDrab;
            this.lightlbl.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightlbl.Location = new System.Drawing.Point(6, 195);
            this.lightlbl.Name = "lightlbl";
            this.lightlbl.Size = new System.Drawing.Size(134, 22);
            this.lightlbl.TabIndex = 12;
            this.lightlbl.Text = "LIGHT RATIO: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // lhbtn
            // 
            this.lhbtn.BackColor = System.Drawing.Color.Yellow;
            this.lhbtn.Location = new System.Drawing.Point(6, 337);
            this.lhbtn.Name = "lhbtn";
            this.lhbtn.Size = new System.Drawing.Size(200, 42);
            this.lhbtn.TabIndex = 2;
            this.lhbtn.Text = "HIGH";
            this.lhbtn.UseVisualStyleBackColor = false;
            this.lhbtn.Click += new System.EventHandler(this.lhbtn_Click);
            // 
            // lmbtn
            // 
            this.lmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lmbtn.Location = new System.Drawing.Point(6, 289);
            this.lmbtn.Name = "lmbtn";
            this.lmbtn.Size = new System.Drawing.Size(200, 42);
            this.lmbtn.TabIndex = 1;
            this.lmbtn.Text = "MEDIUM";
            this.lmbtn.UseVisualStyleBackColor = false;
            this.lmbtn.Click += new System.EventHandler(this.lmbtn_Click);
            // 
            // llbtn
            // 
            this.llbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.llbtn.Location = new System.Drawing.Point(6, 241);
            this.llbtn.Name = "llbtn";
            this.llbtn.Size = new System.Drawing.Size(200, 42);
            this.llbtn.TabIndex = 0;
            this.llbtn.Text = "LOW";
            this.llbtn.UseVisualStyleBackColor = false;
            this.llbtn.Click += new System.EventHandler(this.llbtn_Click);
            // 
            // doorgroup
            // 
            this.doorgroup.BackColor = System.Drawing.SystemColors.Info;
            this.doorgroup.Controls.Add(this.doorlbl);
            this.doorgroup.Controls.Add(this.closedoorbtn);
            this.doorgroup.Controls.Add(this.opndoorbtn);
            this.doorgroup.Location = new System.Drawing.Point(923, 47);
            this.doorgroup.Name = "doorgroup";
            this.doorgroup.Size = new System.Drawing.Size(431, 437);
            this.doorgroup.TabIndex = 3;
            this.doorgroup.TabStop = false;
            this.doorgroup.Text = "Security Control";
            this.doorgroup.Enter += new System.EventHandler(this.doorgroup_Enter);
            // 
            // doorlbl
            // 
            this.doorlbl.AutoSize = true;
            this.doorlbl.BackColor = System.Drawing.Color.OliveDrab;
            this.doorlbl.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.doorlbl.Location = new System.Drawing.Point(6, 195);
            this.doorlbl.Name = "doorlbl";
            this.doorlbl.Size = new System.Drawing.Size(119, 22);
            this.doorlbl.TabIndex = 2;
            this.doorlbl.Text = "DOOR INFO: ";
            this.doorlbl.Click += new System.EventHandler(this.doorlbl_Click);
            // 
            // closedoorbtn
            // 
            this.closedoorbtn.BackColor = System.Drawing.Color.Red;
            this.closedoorbtn.Location = new System.Drawing.Point(222, 250);
            this.closedoorbtn.Name = "closedoorbtn";
            this.closedoorbtn.Size = new System.Drawing.Size(203, 183);
            this.closedoorbtn.TabIndex = 1;
            this.closedoorbtn.Text = "CLOSE DOOR ";
            this.closedoorbtn.UseVisualStyleBackColor = false;
            this.closedoorbtn.Click += new System.EventHandler(this.closedoorbtn_Click);
            // 
            // opndoorbtn
            // 
            this.opndoorbtn.BackColor = System.Drawing.Color.Lime;
            this.opndoorbtn.Location = new System.Drawing.Point(6, 248);
            this.opndoorbtn.Name = "opndoorbtn";
            this.opndoorbtn.Size = new System.Drawing.Size(204, 183);
            this.opndoorbtn.TabIndex = 0;
            this.opndoorbtn.Text = "OPEN DOOR";
            this.opndoorbtn.UseVisualStyleBackColor = false;
            this.opndoorbtn.Click += new System.EventHandler(this.opndoorbtn_Click);
            // 
            // closeportbtn
            // 
            this.closeportbtn.BackColor = System.Drawing.Color.Red;
            this.closeportbtn.Location = new System.Drawing.Point(6, 348);
            this.closeportbtn.Name = "closeportbtn";
            this.closeportbtn.Size = new System.Drawing.Size(255, 83);
            this.closeportbtn.TabIndex = 4;
            this.closeportbtn.Text = "Close";
            this.closeportbtn.UseVisualStyleBackColor = false;
            this.closeportbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openportbtn
            // 
            this.openportbtn.BackColor = System.Drawing.Color.Lime;
            this.openportbtn.Location = new System.Drawing.Point(6, 248);
            this.openportbtn.Name = "openportbtn";
            this.openportbtn.Size = new System.Drawing.Size(255, 83);
            this.openportbtn.TabIndex = 5;
            this.openportbtn.Text = "Open";
            this.openportbtn.UseVisualStyleBackColor = false;
            this.openportbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectport
            // 
            this.selectport.FormattingEnabled = true;
            this.selectport.Location = new System.Drawing.Point(6, 82);
            this.selectport.Name = "selectport";
            this.selectport.Size = new System.Drawing.Size(255, 24);
            this.selectport.TabIndex = 6;
            this.selectport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // portgroup
            // 
            this.portgroup.BackColor = System.Drawing.SystemColors.Info;
            this.portgroup.Controls.Add(this.label3);
            this.portgroup.Controls.Add(this.label1);
            this.portgroup.Controls.Add(this.openportbtn);
            this.portgroup.Controls.Add(this.selectport);
            this.portgroup.Controls.Add(this.closeportbtn);
            this.portgroup.Location = new System.Drawing.Point(12, 47);
            this.portgroup.Name = "portgroup";
            this.portgroup.Size = new System.Drawing.Size(267, 437);
            this.portgroup.TabIndex = 7;
            this.portgroup.TabStop = false;
            this.portgroup.Text = "Serial Port Control ";
            this.portgroup.Enter += new System.EventHandler(this.portgroup_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(520, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "SMART GREENHOUSE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fangroup);
            this.Controls.Add(this.portgroup);
            this.Controls.Add(this.doorgroup);
            this.Controls.Add(this.humgroup);
            this.Controls.Add(this.lightgroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fangroup.ResumeLayout(false);
            this.fangroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.lightgroup.ResumeLayout(false);
            this.lightgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.humgroup.ResumeLayout(false);
            this.humgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.doorgroup.ResumeLayout(false);
            this.doorgroup.PerformLayout();
            this.portgroup.ResumeLayout(false);
            this.portgroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fangroup;
        private System.Windows.Forms.GroupBox lightgroup;
        private System.Windows.Forms.GroupBox humgroup;
        private System.Windows.Forms.GroupBox doorgroup;
        private System.Windows.Forms.Button closeportbtn;
        private System.Windows.Forms.Button openportbtn;
        private System.Windows.Forms.ComboBox selectport;
        private System.Windows.Forms.GroupBox portgroup;
        private System.Windows.Forms.Button fhbtn;
        private System.Windows.Forms.Button fmbtn;
        private System.Windows.Forms.Button flbtn;
        private System.Windows.Forms.Button hhbtn;
        private System.Windows.Forms.Button hmbtn;
        private System.Windows.Forms.Button hlbtn;
        private System.Windows.Forms.Button lhbtn;
        private System.Windows.Forms.Button lmbtn;
        private System.Windows.Forms.Button llbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label templbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label humlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lightlbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label doorlbl;
        private System.Windows.Forms.Button closedoorbtn;
        private System.Windows.Forms.Button opndoorbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tempclose;
        private System.Windows.Forms.Button humclose;
    }
}

