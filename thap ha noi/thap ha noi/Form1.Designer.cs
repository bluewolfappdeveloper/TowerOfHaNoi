namespace thap_ha_noi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnplay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.txttime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmovecount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguide = new System.Windows.Forms.Button();
            this.btngiveup = new System.Windows.Forms.Button();
            this.btnplayagain = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.piccota = new System.Windows.Forms.PictureBox();
            this.piccotc = new System.Windows.Forms.PictureBox();
            this.piccotb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccotc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccotb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnplay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num);
            this.panel1.Controls.Add(this.txttime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmovecount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnguide);
            this.panel1.Controls.Add(this.btngiveup);
            this.panel1.Controls.Add(this.btnplayagain);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 161);
            this.panel1.TabIndex = 20;
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(200, 109);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(167, 49);
            this.btnplay.TabIndex = 9;
            this.btnplay.Text = "CHƠI";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(468, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số đĩa:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(625, 66);
            this.num.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(71, 32);
            this.num.TabIndex = 7;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txttime
            // 
            this.txttime.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttime.Location = new System.Drawing.Point(899, 10);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(127, 44);
            this.txttime.TabIndex = 6;
            this.txttime.Text = "0";
            this.txttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(741, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian:";
            // 
            // txtmovecount
            // 
            this.txtmovecount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmovecount.Location = new System.Drawing.Point(398, 10);
            this.txtmovecount.Name = "txtmovecount";
            this.txtmovecount.ReadOnly = true;
            this.txtmovecount.Size = new System.Drawing.Size(127, 44);
            this.txtmovecount.TabIndex = 4;
            this.txtmovecount.Text = "0";
            this.txtmovecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lần di chuyển:";
            // 
            // btnguide
            // 
            this.btnguide.Location = new System.Drawing.Point(899, 109);
            this.btnguide.Name = "btnguide";
            this.btnguide.Size = new System.Drawing.Size(167, 49);
            this.btnguide.TabIndex = 2;
            this.btnguide.Text = "LUẬT CHƠI";
            this.btnguide.UseVisualStyleBackColor = true;
            this.btnguide.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngiveup
            // 
            this.btngiveup.Enabled = false;
            this.btngiveup.Location = new System.Drawing.Point(560, 109);
            this.btngiveup.Name = "btngiveup";
            this.btngiveup.Size = new System.Drawing.Size(167, 49);
            this.btngiveup.TabIndex = 1;
            this.btngiveup.Text = "CHỊU THUA";
            this.btngiveup.UseVisualStyleBackColor = true;
            this.btngiveup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnplayagain
            // 
            this.btnplayagain.Location = new System.Drawing.Point(200, 109);
            this.btnplayagain.Name = "btnplayagain";
            this.btnplayagain.Size = new System.Drawing.Size(167, 49);
            this.btnplayagain.TabIndex = 0;
            this.btnplayagain.Text = "CHƠI LẠI";
            this.btnplayagain.UseVisualStyleBackColor = true;
            this.btnplayagain.Click += new System.EventHandler(this.btnplayagain_Click);
            // 
            // time
            // 
            this.time.Interval = 1500;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(179, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(582, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(987, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Magneto", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(302, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(619, 78);
            this.label7.TabIndex = 24;
            this.label7.Text = "THÁP HÀ NỘI";
            // 
            // pic1
            // 
            this.pic1.Image = global::thap_ha_noi.Properties.Resources.pic1;
            this.pic1.Location = new System.Drawing.Point(102, 239);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(175, 35);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 17;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Visible = false;
            this.pic1.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::thap_ha_noi.Properties.Resources.pic2;
            this.pic2.Location = new System.Drawing.Point(92, 284);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(195, 35);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic2.TabIndex = 16;
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.Visible = false;
            this.pic2.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic4
            // 
            this.pic4.Image = global::thap_ha_noi.Properties.Resources.pic4;
            this.pic4.Location = new System.Drawing.Point(72, 374);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(235, 35);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic4.TabIndex = 14;
            this.pic4.TabStop = false;
            this.pic4.Tag = "4";
            this.pic4.Visible = false;
            this.pic4.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::thap_ha_noi.Properties.Resources.pic3;
            this.pic3.Location = new System.Drawing.Point(82, 329);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(215, 35);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic3.TabIndex = 15;
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.Visible = false;
            this.pic3.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic5
            // 
            this.pic5.Image = global::thap_ha_noi.Properties.Resources.pic5;
            this.pic5.Location = new System.Drawing.Point(62, 419);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(255, 35);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic5.TabIndex = 13;
            this.pic5.TabStop = false;
            this.pic5.Tag = "5";
            this.pic5.Visible = false;
            this.pic5.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic6
            // 
            this.pic6.Image = global::thap_ha_noi.Properties.Resources.pic6;
            this.pic6.Location = new System.Drawing.Point(52, 465);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(275, 35);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic6.TabIndex = 12;
            this.pic6.TabStop = false;
            this.pic6.Tag = "6";
            this.pic6.Visible = false;
            this.pic6.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pic8.Image = global::thap_ha_noi.Properties.Resources.pic8;
            this.pic8.Location = new System.Drawing.Point(32, 554);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(318, 35);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic8.TabIndex = 10;
            this.pic8.TabStop = false;
            this.pic8.Tag = "8";
            this.pic8.Visible = false;
            this.pic8.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic7
            // 
            this.pic7.Image = global::thap_ha_noi.Properties.Resources.pic7;
            this.pic7.Location = new System.Drawing.Point(42, 509);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(296, 35);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic7.TabIndex = 11;
            this.pic7.TabStop = false;
            this.pic7.Tag = "7";
            this.pic7.Visible = false;
            this.pic7.Click += new System.EventHandler(this.pic_Click);
            // 
            // piccota
            // 
            this.piccota.Image = global::thap_ha_noi.Properties.Resources.piccot;
            this.piccota.Location = new System.Drawing.Point(12, 239);
            this.piccota.Name = "piccota";
            this.piccota.Size = new System.Drawing.Size(392, 385);
            this.piccota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccota.TabIndex = 0;
            this.piccota.TabStop = false;
            this.piccota.Click += new System.EventHandler(this.piccot_Click);
            // 
            // piccotc
            // 
            this.piccotc.Image = global::thap_ha_noi.Properties.Resources.piccot;
            this.piccotc.Location = new System.Drawing.Point(811, 239);
            this.piccotc.Name = "piccotc";
            this.piccotc.Size = new System.Drawing.Size(392, 384);
            this.piccotc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccotc.TabIndex = 19;
            this.piccotc.TabStop = false;
            this.piccotc.Click += new System.EventHandler(this.piccot_Click);
            // 
            // piccotb
            // 
            this.piccotb.Image = global::thap_ha_noi.Properties.Resources.piccot;
            this.piccotb.Location = new System.Drawing.Point(410, 239);
            this.piccotb.Name = "piccotb";
            this.piccotb.Size = new System.Drawing.Size(392, 385);
            this.piccotb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccotb.TabIndex = 18;
            this.piccotb.TabStop = false;
            this.piccotb.Click += new System.EventHandler(this.piccot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1212, 672);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.piccota);
            this.Controls.Add(this.piccotc);
            this.Controls.Add(this.piccotb);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÁP HÀ NỘI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccotc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccotb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piccota;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox piccotb;
        private System.Windows.Forms.PictureBox piccotc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmovecount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguide;
        private System.Windows.Forms.Button btngiveup;
        private System.Windows.Forms.Button btnplayagain;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Label label7;
    }
}

