namespace Routes
{
    partial class Reset
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
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtConfirmpassword = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblConfirmpassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogin.LinkColor = System.Drawing.Color.Maroon;
            this.lnkLogin.Location = new System.Drawing.Point(40, 251);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(62, 24);
            this.lnkLogin.TabIndex = 32;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Login";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.White;
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.Maroon;
            this.cmdOK.Location = new System.Drawing.Point(236, 191);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(104, 35);
            this.cmdOK.TabIndex = 31;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.Location = new System.Drawing.Point(213, 137);
            this.txtConfirmpassword.Multiline = true;
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(127, 32);
            this.txtConfirmpassword.TabIndex = 30;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(213, 90);
            this.txtPassword1.Multiline = true;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(127, 30);
            this.txtPassword1.TabIndex = 29;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(213, 32);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(127, 31);
            this.txtUsername.TabIndex = 28;
            // 
            // lblConfirmpassword
            // 
            this.lblConfirmpassword.AutoSize = true;
            this.lblConfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmpassword.ForeColor = System.Drawing.Color.Navy;
            this.lblConfirmpassword.Location = new System.Drawing.Point(37, 138);
            this.lblConfirmpassword.Name = "lblConfirmpassword";
            this.lblConfirmpassword.Size = new System.Drawing.Size(144, 20);
            this.lblConfirmpassword.TabIndex = 27;
            this.lblConfirmpassword.Text = "confirmpassword";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblPassword.Location = new System.Drawing.Point(37, 88);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 20);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Navy;
            this.lblUsername.Location = new System.Drawing.Point(40, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 20);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "username";
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 339);
            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtConfirmpassword);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblConfirmpassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "Reset";
            this.Text = "Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TextBox txtConfirmpassword;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblConfirmpassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}