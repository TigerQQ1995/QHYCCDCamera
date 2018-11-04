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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(23, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(75, 23);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // DisConnection
            // 
            this.DisConnection.Location = new System.Drawing.Point(23, 70);
            this.DisConnection.Name = "DisConnection";
            this.DisConnection.Size = new System.Drawing.Size(75, 23);
            this.DisConnection.TabIndex = 1;
            this.DisConnection.Text = "DisConnection";
            this.DisConnection.UseVisualStyleBackColor = true;
            this.DisConnection.Click += new System.EventHandler(this.DisConnection_Click);
            // 
            // single
            // 
            this.single.Location = new System.Drawing.Point(607, 12);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(75, 23);
            this.single.TabIndex = 2;
            this.single.Text = "16位图像";
            this.single.UseVisualStyleBackColor = true;
            this.single.Click += new System.EventHandler(this.single_Click);
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(503, 20);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(75, 23);
            this.setting.TabIndex = 3;
            this.setting.Text = "Settings";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SdkDemo08.Properties.Resources.Tulips;
            this.pictureBox1.Location = new System.Drawing.Point(23, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exposure
            // 
            this.exposure.Location = new System.Drawing.Point(172, 20);
            this.exposure.Name = "exposure";
            this.exposure.Size = new System.Drawing.Size(100, 21);
            this.exposure.TabIndex = 5;
            this.exposure.Text = "40000";
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(172, 65);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(100, 21);
            this.gain.TabIndex = 6;
            this.gain.Text = "1";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(357, 22);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(100, 21);
            this.offset.TabIndex = 7;
            this.offset.Text = "115";
            // 
            // usbTraffic
            // 
            this.usbTraffic.Location = new System.Drawing.Point(357, 65);
            this.usbTraffic.Name = "usbTraffic";
            this.usbTraffic.Size = new System.Drawing.Size(100, 21);
            this.usbTraffic.TabIndex = 8;
            this.usbTraffic.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "exposure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "offSet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "usbTraffic";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "8位图像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "灰度图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConnectLive
            // 
            this.ConnectLive.Location = new System.Drawing.Point(23, 41);
            this.ConnectLive.Name = "ConnectLive";
            this.ConnectLive.Size = new System.Drawing.Size(75, 23);
            this.ConnectLive.TabIndex = 15;
            this.ConnectLive.Text = "ConnectLive";
            this.ConnectLive.UseVisualStyleBackColor = true;
            this.ConnectLive.Click += new System.EventHandler(this.ConnectLive_Click);
            // 
            // Live
            // 
            this.Live.Location = new System.Drawing.Point(700, 14);
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(75, 23);
            this.Live.TabIndex = 16;
            this.Live.Text = "连续模式";
            this.Live.UseVisualStyleBackColor = true;
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 677);
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
    }
}

