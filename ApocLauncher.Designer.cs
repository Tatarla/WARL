using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Launcher
{
    partial class ApocLauncher
    {
        /// <summary>
        /// Variable needed by the designer.
        /// </ summary>
        private IContainer components = null;

        /// <summary>
        /// Cleaning the resources used.
        /// </ summary>
        /// <param name = "disposing"> true if the managed resources should be deleted; otherwise, false. </ param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Method required to support the designer - do not modify
        /// the contents of this method with the code editor.
        /// </ summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApocLauncher));
            this.T_username = new System.Windows.Forms.TextBox();
            this.T_password = new System.Windows.Forms.MaskedTextBox();
            this.RealmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLauncherServer = new System.Windows.Forms.Label();
            this.bnConnectToServer = new System.Windows.Forms.Button();
            this.edHashCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bnCreateUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edPassword = new System.Windows.Forms.MaskedTextBox();
            this.edNewUserCode = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.bnClose = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDownloading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bnMinimise = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // T_username
            // 
            this.T_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.T_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_username.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.T_username.Location = new System.Drawing.Point(54, 221);
            this.T_username.Margin = new System.Windows.Forms.Padding(0);
            this.T_username.MaxLength = 50;
            this.T_username.Multiline = true;
            this.T_username.Name = "T_username";
            this.T_username.Size = new System.Drawing.Size(200, 36);
            this.T_username.TabIndex = 0;
            this.T_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_username_KeyDown);
            // 
            // T_password
            // 
            this.T_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.T_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_password.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.T_password.Location = new System.Drawing.Point(54, 284);
            this.T_password.Margin = new System.Windows.Forms.Padding(0);
            this.T_password.Name = "T_password";
            this.T_password.Size = new System.Drawing.Size(200, 36);
            this.T_password.TabIndex = 1;
            this.T_password.UseSystemPasswordChar = true;
            this.T_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_password_KeyDown);
            // 
            // RealmName
            // 
            this.RealmName.Name = "RealmName";
            // 
            // Online
            // 
            this.Online.Name = "Online";
            // 
            // Players
            // 
            this.Players.Name = "Players";
            // 
            // Destruction
            // 
            this.Destruction.Name = "Destruction";
            // 
            // Order
            // 
            this.Order.Name = "Order";
            // 
            // lblLauncherServer
            // 
            this.lblLauncherServer.AutoSize = true;
            this.lblLauncherServer.Location = new System.Drawing.Point(12, 117);
            this.lblLauncherServer.Name = "lblLauncherServer";
            this.lblLauncherServer.Size = new System.Drawing.Size(0, 13);
            this.lblLauncherServer.TabIndex = 11;
            // 
            // bnConnectToServer
            // 
            this.bnConnectToServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bnConnectToServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnConnectToServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bnConnectToServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnConnectToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnConnectToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnConnectToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bnConnectToServer.ForeColor = System.Drawing.Color.White;
            this.bnConnectToServer.Location = new System.Drawing.Point(100, 336);
            this.bnConnectToServer.Margin = new System.Windows.Forms.Padding(0);
            this.bnConnectToServer.Name = "bnConnectToServer";
            this.bnConnectToServer.Size = new System.Drawing.Size(115, 40);
            this.bnConnectToServer.TabIndex = 12;
            this.bnConnectToServer.Text = "Вход";
            this.bnConnectToServer.UseVisualStyleBackColor = false;
            this.bnConnectToServer.Click += new System.EventHandler(this.bnConnectToServer_Click);
            // 
            // edHashCode
            // 
            this.edHashCode.Location = new System.Drawing.Point(6, 78);
            this.edHashCode.Name = "edHashCode";
            this.edHashCode.Size = new System.Drawing.Size(385, 20);
            this.edHashCode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hash Code";
            // 
            // bnCreateUser
            // 
            this.bnCreateUser.Location = new System.Drawing.Point(0, 0);
            this.bnCreateUser.Name = "bnCreateUser";
            this.bnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.bnCreateUser.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Account";
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(198, 39);
            this.edPassword.Name = "edPassword";
            this.edPassword.Size = new System.Drawing.Size(193, 20);
            this.edPassword.TabIndex = 5;
            // 
            // edNewUserCode
            // 
            this.edNewUserCode.Location = new System.Drawing.Point(6, 39);
            this.edNewUserCode.Name = "edNewUserCode";
            this.edNewUserCode.Size = new System.Drawing.Size(175, 20);
            this.edNewUserCode.TabIndex = 4;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConnection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConnection.Location = new System.Drawing.Point(12, 388);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(286, 24);
            this.lblConnection.TabIndex = 13;
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnClose
            // 
            this.bnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnClose.FlatAppearance.BorderSize = 0;
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bnClose.Location = new System.Drawing.Point(282, -1);
            this.bnClose.Margin = new System.Windows.Forms.Padding(0);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(30, 30);
            this.bnClose.TabIndex = 14;
            this.bnClose.Text = "X";
            this.bnClose.UseVisualStyleBackColor = false;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblVersion.Location = new System.Drawing.Point(126, 430);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDownloading
            // 
            this.lblDownloading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDownloading.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloading.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDownloading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDownloading.Location = new System.Drawing.Point(12, 388);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.Size = new System.Drawing.Size(286, 24);
            this.lblDownloading.TabIndex = 27;
            this.lblDownloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 16F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(49, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "Логин:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 16F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(49, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "Пароль:";
            // 
            // bnMinimise
            // 
            this.bnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnMinimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnMinimise.FlatAppearance.BorderSize = 0;
            this.bnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnMinimise.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnMinimise.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bnMinimise.Location = new System.Drawing.Point(252, -6);
            this.bnMinimise.Margin = new System.Windows.Forms.Padding(0);
            this.bnMinimise.Name = "bnMinimise";
            this.bnMinimise.Size = new System.Drawing.Size(30, 35);
            this.bnMinimise.TabIndex = 31;
            this.bnMinimise.Text = "_";
            this.bnMinimise.UseVisualStyleBackColor = false;
            this.bnMinimise.Click += new System.EventHandler(this.bnMinimise_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 35);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(88, 47);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 131);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(54, 148);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(224, 148);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // ApocLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 421);
            this.Controls.Add(this.bnMinimise);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.bnConnectToServer);
            this.Controls.Add(this.lblLauncherServer);
            this.Controls.Add(this.T_password);
            this.Controls.Add(this.T_username);
            this.Controls.Add(this.lblDownloading);
            this.Controls.Add(this.lblConnection);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApocLauncher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAR: Dammaz Kron";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Disconnect);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_username;
        private System.Windows.Forms.MaskedTextBox T_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Online;
        private System.Windows.Forms.DataGridViewTextBoxColumn Players;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.Label lblLauncherServer;
        private System.Windows.Forms.Button bnConnectToServer;
        private System.Windows.Forms.Button bnCreateUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox edPassword;
        private System.Windows.Forms.TextBox edNewUserCode;
        private System.Windows.Forms.TextBox edHashCode;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Label lblVersion;
        private Timer timer1;
        private Label lblDownloading;
        private Label label4;
        private Label label8;
        private Button bnMinimise;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}

