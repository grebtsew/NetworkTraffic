namespace NetWorkTraffic
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.connected = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.gIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HName = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.mac = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.OwnIP = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.connected);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.gIP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.HName);
            this.groupBox3.Controls.Add(this.HostName);
            this.groupBox3.Controls.Add(this.mac);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.OwnIP);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(888, 554);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your Information";
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Location = new System.Drawing.Point(85, 119);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(10, 13);
            this.connected.TabIndex = 22;
            this.connected.Text = "-";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 119);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 13);
            this.label34.TabIndex = 21;
            this.label34.Text = "Connected";
            // 
            // gIP
            // 
            this.gIP.AutoSize = true;
            this.gIP.Location = new System.Drawing.Point(85, 77);
            this.gIP.Name = "gIP";
            this.gIP.Size = new System.Drawing.Size(10, 13);
            this.gIP.TabIndex = 17;
            this.gIP.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "IP";
            // 
            // HName
            // 
            this.HName.AutoSize = true;
            this.HName.Location = new System.Drawing.Point(85, 64);
            this.HName.Name = "HName";
            this.HName.Size = new System.Drawing.Size(10, 13);
            this.HName.TabIndex = 15;
            this.HName.Text = "-";
            // 
            // HostName
            // 
            this.HostName.AutoSize = true;
            this.HostName.Location = new System.Drawing.Point(6, 64);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(57, 13);
            this.HostName.TabIndex = 14;
            this.HostName.Text = "HostName";
            // 
            // mac
            // 
            this.mac.AutoSize = true;
            this.mac.Location = new System.Drawing.Point(85, 51);
            this.mac.Name = "mac";
            this.mac.Size = new System.Drawing.Size(10, 13);
            this.mac.TabIndex = 13;
            this.mac.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(524, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 13);
            this.label30.TabIndex = 11;
            this.label30.Text = "All Information";
            // 
            // OwnIP
            // 
            this.OwnIP.AutoSize = true;
            this.OwnIP.Location = new System.Drawing.Point(85, 16);
            this.OwnIP.Name = "OwnIP";
            this.OwnIP.Size = new System.Drawing.Size(10, 13);
            this.OwnIP.TabIndex = 10;
            this.OwnIP.Text = "-";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(374, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(508, 518);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 106);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 13);
            this.label28.TabIndex = 8;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Mac";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Local IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 573);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "NetworkTraffic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label mac;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label OwnIP;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label HName;
        private System.Windows.Forms.Label HostName;
        private System.Windows.Forms.Label gIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connected;
        private System.Windows.Forms.Label label34;
    }
}

