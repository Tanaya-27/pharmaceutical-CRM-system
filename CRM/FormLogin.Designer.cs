
namespace FontusHealthCRM
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.btnConfirmNewPass = new System.Windows.Forms.Button();
            this.btnOpenDash = new System.Windows.Forms.Button();
            this.picShowPass = new System.Windows.Forms.PictureBox();
            this.picShowNewPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNewPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(26, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(29, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(29, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(26, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(230, 94);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 57);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Wheat;
            this.btnChangePass.Enabled = false;
            this.btnChangePass.Location = new System.Drawing.Point(29, 206);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(298, 24);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.OldLace;
            this.txtNewPass.Location = new System.Drawing.Point(29, 270);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(195, 20);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.Visible = false;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(26, 243);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(81, 13);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "New Password:";
            this.lblNewPass.Visible = false;
            // 
            // btnConfirmNewPass
            // 
            this.btnConfirmNewPass.BackColor = System.Drawing.Color.Wheat;
            this.btnConfirmNewPass.Location = new System.Drawing.Point(259, 269);
            this.btnConfirmNewPass.Name = "btnConfirmNewPass";
            this.btnConfirmNewPass.Size = new System.Drawing.Size(68, 21);
            this.btnConfirmNewPass.TabIndex = 7;
            this.btnConfirmNewPass.Text = "Confirm";
            this.btnConfirmNewPass.UseVisualStyleBackColor = false;
            this.btnConfirmNewPass.Visible = false;
            this.btnConfirmNewPass.Click += new System.EventHandler(this.btnConfirmNewPass_Click);
            // 
            // btnOpenDash
            // 
            this.btnOpenDash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenDash.Enabled = false;
            this.btnOpenDash.Location = new System.Drawing.Point(343, 53);
            this.btnOpenDash.Name = "btnOpenDash";
            this.btnOpenDash.Size = new System.Drawing.Size(102, 137);
            this.btnOpenDash.TabIndex = 8;
            this.btnOpenDash.Text = "Open Dash";
            this.btnOpenDash.UseVisualStyleBackColor = false;
            this.btnOpenDash.Click += new System.EventHandler(this.btnOpenDash_Click);
            // 
            // picShowPass
            // 
            this.picShowPass.Image = ((System.Drawing.Image)(resources.GetObject("picShowPass.Image")));
            this.picShowPass.Location = new System.Drawing.Point(197, 132);
            this.picShowPass.Name = "picShowPass";
            this.picShowPass.Size = new System.Drawing.Size(27, 20);
            this.picShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowPass.TabIndex = 9;
            this.picShowPass.TabStop = false;
            // 
            // picShowNewPass
            // 
            this.picShowNewPass.Image = ((System.Drawing.Image)(resources.GetObject("picShowNewPass.Image")));
            this.picShowNewPass.Location = new System.Drawing.Point(226, 269);
            this.picShowNewPass.Name = "picShowNewPass";
            this.picShowNewPass.Size = new System.Drawing.Size(27, 20);
            this.picShowNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowNewPass.TabIndex = 9;
            this.picShowNewPass.TabStop = false;
            this.picShowNewPass.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 317);
            this.Controls.Add(this.picShowNewPass);
            this.Controls.Add(this.picShowPass);
            this.Controls.Add(this.btnOpenDash);
            this.Controls.Add(this.btnConfirmNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNewPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Button btnConfirmNewPass;
        private System.Windows.Forms.Button btnOpenDash;
        private System.Windows.Forms.PictureBox picShowPass;
        private System.Windows.Forms.PictureBox picShowNewPass;
    }
}