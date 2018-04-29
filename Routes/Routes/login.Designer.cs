namespace Routes
{
    partial class login
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
            this.lnkReset = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmdRegistration = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lnklblLogin = new System.Windows.Forms.LinkLabel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // lnkReset
            // 
            this.lnkReset.AutoSize = true;
            this.lnkReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReset.LinkColor = System.Drawing.Color.Maroon;
            this.lnkReset.Location = new System.Drawing.Point(36, 219);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(57, 20);
            this.lnkReset.TabIndex = 33;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset";
            this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 104);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 32);
            this.txtPassword.TabIndex = 32;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(157, 54);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(130, 28);
            this.txtUsername.TabIndex = 31;
            // 
            // cmdRegistration
            // 
            this.cmdRegistration.BackColor = System.Drawing.Color.White;
            this.cmdRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistration.ForeColor = System.Drawing.Color.Maroon;
            this.cmdRegistration.Location = new System.Drawing.Point(253, 165);
            this.cmdRegistration.Name = "cmdRegistration";
            this.cmdRegistration.Size = new System.Drawing.Size(97, 36);
            this.cmdRegistration.TabIndex = 30;
            this.cmdRegistration.Text = "Login";
            this.cmdRegistration.UseVisualStyleBackColor = false;
            this.cmdRegistration.Click += new System.EventHandler(this.cmdRegistration_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblPassword.Location = new System.Drawing.Point(27, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Password";
            // 
            // lnklblLogin
            // 
            this.lnklblLogin.AutoSize = true;
            this.lnklblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLogin.LinkColor = System.Drawing.Color.Maroon;
            this.lnklblLogin.Location = new System.Drawing.Point(36, 259);
            this.lnklblLogin.Name = "lnklblLogin";
            this.lnklblLogin.Size = new System.Drawing.Size(100, 20);
            this.lnklblLogin.TabIndex = 28;
            this.lnklblLogin.TabStop = true;
            this.lnklblLogin.Text = "registration";
            this.lnklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogin_LinkClicked);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Navy;
            this.lblUsername.Location = new System.Drawing.Point(27, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 27;
            this.lblUsername.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 358);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lnkReset);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmdRegistration);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lnklblLogin);
            this.Controls.Add(this.lblUsername);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkReset;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button cmdRegistration;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lnklblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}