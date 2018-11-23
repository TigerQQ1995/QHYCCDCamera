namespace SdkDemo08
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
            this.Connection = new System.Windows.Forms.Button();
            this.DisConnection = new System.Windows.Forms.Button();
            this.single = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exposure = new System.Windows.Forms.TextBox();
            this.gain = new System.Windows.Forms.TextBox();
            this.offset = new System.Windows.Forms.TextBox();
            this.usbTraffic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConnectLive = new System.Windows.Forms.Button();
            this.Live = new System.Windows.Forms.Button();
            this.fps = new System.Windows.Forms.Label();
            this.fps_text = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.pointX = new System.Windows.Forms.TextBox();
            this.pointY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(20, 72);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(75, 23);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connect";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // DisConnection
            // 
            this.DisConnection.Location = new System.Drawing.Point(410, 12);
            this.DisConnection.Name = "DisConnection";
            this.DisConnection.Size = new System.Drawing.Size(103, 62);
            this.DisConnection.TabIndex = 1;
            this.DisConnection.Text = "DisConnect";
            this.DisConnection.UseVisualStyleBackColor = true;
            this.DisConnection.Click += new System.EventHandler(this.DisConnection_Click);
            // 
            // single
            // 
            this.single.Location = new System.Drawing.Point(119, 72);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(75, 23);
            this.single.TabIndex = 2;
            this.single.Text = "16bit Img";
            this.single.UseVisualStyleBackColor = true;
            this.single.Click += new System.EventHandler(this.single_Click);
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(17, 123);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(139, 33);
            this.setting.TabIndex = 3;
            this.setting.Text = "Settings";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SdkDemo08.Properties.Resources.Tulips;
            this.pictureBox1.Location = new System.Drawing.Point(451, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exposure
            // 
            this.exposure.Location = new System.Drawing.Point(89, 176);
            this.exposure.Name = "exposure";
            this.exposure.Size = new System.Drawing.Size(86, 21);
            this.exposure.TabIndex = 5;
            this.exposure.Text = "20000";
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(89, 262);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(86, 21);
            this.gain.TabIndex = 6;
            this.gain.Text = "1";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(89, 305);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(86, 21);
            this.offset.TabIndex = 7;
            this.offset.Text = "115";
            // 
            // usbTraffic
            // 
            this.usbTraffic.Location = new System.Drawing.Point(89, 222);
            this.usbTraffic.Name = "usbTraffic";
            this.usbTraffic.Size = new System.Drawing.Size(86, 21);
            this.usbTraffic.TabIndex = 8;
            this.usbTraffic.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "exposure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "offSet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "usbTraffic";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "8bit Img";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "grey Img";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConnectLive
            // 
            this.ConnectLive.Location = new System.Drawing.Point(20, 12);
            this.ConnectLive.Name = "ConnectLive";
            this.ConnectLive.Size = new System.Drawing.Size(125, 32);
            this.ConnectLive.TabIndex = 15;
            this.ConnectLive.Text = "ConnectLive";
            this.ConnectLive.UseVisualStyleBackColor = true;
            this.ConnectLive.Click += new System.EventHandler(this.ConnectLive_Click);
            // 
            // Live
            // 
            this.Live.Location = new System.Drawing.Point(182, 12);
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(119, 32);
            this.Live.TabIndex = 16;
            this.Live.Text = "LiveMode";
            this.Live.UseVisualStyleBackColor = true;
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // fps
            // 
            this.fps.AutoSize = true;
            this.fps.Location = new System.Drawing.Point(1078, 72);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(23, 12);
            this.fps.TabIndex = 17;
            this.fps.Text = "fps";
            // 
            // fps_text
            // 
            this.fps_text.AutoSize = true;
            this.fps_text.Location = new System.Drawing.Point(1116, 72);
            this.fps_text.Name = "fps_text";
            this.fps_text.Size = new System.Drawing.Size(11, 12);
            this.fps_text.TabIndex = 18;
            this.fps_text.Text = "0";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(874, 72);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(29, 12);
            this.time.TabIndex = 19;
            this.time.Text = "time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Resolution";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "Initial Position";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(89, 389);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(86, 21);
            this.width.TabIndex = 26;
            this.width.Text = "4656";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(89, 428);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(86, 21);
            this.height.TabIndex = 27;
            this.height.Text = "3522";
            // 
            // pointX
            // 
            this.pointX.Location = new System.Drawing.Point(89, 512);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(86, 21);
            this.pointX.TabIndex = 28;
            this.pointX.Text = "0";
            // 
            // pointY
            // 
            this.pointY.Location = new System.Drawing.Point(89, 553);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(86, 21);
            this.pointY.TabIndex = 29;
            this.pointY.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.pointY);
            this.Controls.Add(this.pointX);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.fps_text);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.Live);
            this.Controls.Add(this.ConnectLive);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usbTraffic);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.gain);
            this.Controls.Add(this.exposure);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.single);
            this.Controls.Add(this.DisConnection);
            this.Controls.Add(this.Connection);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.Button DisConnection;
        private System.Windows.Forms.Button single;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox exposure;
        private System.Windows.Forms.TextBox gain;
        private System.Windows.Forms.TextBox offset;
        private System.Windows.Forms.TextBox usbTraffic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ConnectLive;
        private System.Windows.Forms.Button Live;
        private System.Windows.Forms.Label fps;
        private System.Windows.Forms.Label fps_text;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox pointX;
        private System.Windows.Forms.TextBox pointY;
    }
}

