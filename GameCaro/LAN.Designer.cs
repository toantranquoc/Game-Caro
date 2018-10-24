namespace GameCaro
{
    partial class LAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAN));
            this.pn = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.grChat = new System.Windows.Forms.GroupBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn.Location = new System.Drawing.Point(12, 38);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(501, 501);
            this.pn.TabIndex = 1;
            this.pn.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Paint);
            this.pn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameCaro.Properties.Resources.Caroo;
            this.pictureBox2.Location = new System.Drawing.Point(556, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(553, 230);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(53, 13);
            this.lbIP.TabIndex = 3;
            this.lbIP.Text = "Địa chỉ IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(556, 246);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 20);
            this.txtIP.TabIndex = 4;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(725, 246);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(75, 23);
            this.btnLAN.TabIndex = 5;
            this.btnLAN.Text = "Connect";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // grChat
            // 
            this.grChat.Controls.Add(this.txtChat);
            this.grChat.Location = new System.Drawing.Point(556, 286);
            this.grChat.Name = "grChat";
            this.grChat.Size = new System.Drawing.Size(244, 164);
            this.grChat.TabIndex = 6;
            this.grChat.TabStop = false;
            this.grChat.Text = "Chat";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(556, 466);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(157, 20);
            this.txtSend.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(725, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(556, 509);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 30);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(697, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtChat
            // 
            this.txtChat.Enabled = false;
            this.txtChat.Location = new System.Drawing.Point(0, 19);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.Size = new System.Drawing.Size(244, 145);
            this.txtChat.TabIndex = 0;
            // 
            // LAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.grChat);
            this.Controls.Add(this.btnLAN);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Cờ cá rô";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LAN_FormClosing);
            this.Shown += new System.EventHandler(this.LAN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grChat.ResumeLayout(false);
            this.grChat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.GroupBox grChat;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtChat;
    }
}