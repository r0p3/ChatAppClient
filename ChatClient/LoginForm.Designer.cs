namespace ChatClient
{
    partial class LoginForm
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.cbAutoLogin = new System.Windows.Forms.CheckBox();
            this.lblRegisterHere = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSureName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordHint = new System.Windows.Forms.Label();
            this.lblEmailHint = new System.Windows.Forms.Label();
            this.lblSureNameHint = new System.Windows.Forms.Label();
            this.lblLastNameHint = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbUsername.Location = new System.Drawing.Point(12, 135);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(726, 36);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Tag = "username...";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBSubmit_KeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPassword.Location = new System.Drawing.Point(12, 177);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(726, 36);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Tag = "password...";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBSubmit_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "ChatApp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAction
            // 
            this.btnAction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAction.FlatAppearance.BorderSize = 2;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAction.Location = new System.Drawing.Point(521, 253);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(217, 57);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Login";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbRememberMe.Location = new System.Drawing.Point(12, 249);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(155, 22);
            this.cbRememberMe.TabIndex = 4;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UseVisualStyleBackColor = false;
            // 
            // cbAutoLogin
            // 
            this.cbAutoLogin.AutoSize = true;
            this.cbAutoLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbAutoLogin.Location = new System.Drawing.Point(12, 277);
            this.cbAutoLogin.Name = "cbAutoLogin";
            this.cbAutoLogin.Size = new System.Drawing.Size(120, 22);
            this.cbAutoLogin.TabIndex = 5;
            this.cbAutoLogin.Text = "Auto Login";
            this.cbAutoLogin.UseVisualStyleBackColor = true;
            // 
            // lblRegisterHere
            // 
            this.lblRegisterHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegisterHere.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHere.ForeColor = System.Drawing.Color.Maroon;
            this.lblRegisterHere.Location = new System.Drawing.Point(606, 36);
            this.lblRegisterHere.Name = "lblRegisterHere";
            this.lblRegisterHere.Size = new System.Drawing.Size(145, 18);
            this.lblRegisterHere.TabIndex = 6;
            this.lblRegisterHere.Text = "Register account";
            this.lblRegisterHere.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRegisterHere.Click += new System.EventHandler(this.lblRegisterHere_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Controls.Add(this.lblMinimize);
            this.pHeader.Controls.Add(this.lblX);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(754, 33);
            this.pHeader.TabIndex = 7;
            this.pHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseDown);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(701, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(22, 25);
            this.lblMinimize.TabIndex = 9;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.ControlButtons_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.ControlButtons_MouseLeave);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(725, 3);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            this.lblX.MouseEnter += new System.EventHandler(this.ControlButtons_MouseEnter);
            this.lblX.MouseLeave += new System.EventHandler(this.ControlButtons_MouseLeave);
            // 
            // lblUsernameHint
            // 
            this.lblUsernameHint.AutoSize = true;
            this.lblUsernameHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUsernameHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsernameHint.Location = new System.Drawing.Point(12, 135);
            this.lblUsernameHint.Name = "lblUsernameHint";
            this.lblUsernameHint.Size = new System.Drawing.Size(65, 13);
            this.lblUsernameHint.TabIndex = 8;
            this.lblUsernameHint.Text = "Username";
            // 
            // lblPasswordHint
            // 
            this.lblPasswordHint.AutoSize = true;
            this.lblPasswordHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPasswordHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPasswordHint.Location = new System.Drawing.Point(12, 177);
            this.lblPasswordHint.Name = "lblPasswordHint";
            this.lblPasswordHint.Size = new System.Drawing.Size(61, 13);
            this.lblPasswordHint.TabIndex = 9;
            this.lblPasswordHint.Text = "Password";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lblForgotPassword.Location = new System.Drawing.Point(549, 229);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(193, 18);
            this.lblForgotPassword.TabIndex = 10;
            this.lblForgotPassword.Text = "Forgot your password?";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbConfirmPassword.Location = new System.Drawing.Point(12, 219);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(726, 36);
            this.tbConfirmPassword.TabIndex = 11;
            this.tbConfirmPassword.Tag = "password...";
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmPassword.Visible = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbEmail.Location = new System.Drawing.Point(12, 260);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(726, 36);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.Tag = "password...";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmail.Visible = false;
            // 
            // tbSureName
            // 
            this.tbSureName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbSureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSureName.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSureName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSureName.Location = new System.Drawing.Point(12, 302);
            this.tbSureName.Name = "tbSureName";
            this.tbSureName.Size = new System.Drawing.Size(726, 36);
            this.tbSureName.TabIndex = 13;
            this.tbSureName.Tag = "password...";
            this.tbSureName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbLastName.Location = new System.Drawing.Point(12, 344);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(726, 36);
            this.tbLastName.TabIndex = 14;
            this.tbLastName.Tag = "password...";
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirmPasswordHint
            // 
            this.lblConfirmPasswordHint.AutoSize = true;
            this.lblConfirmPasswordHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblConfirmPasswordHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConfirmPasswordHint.Location = new System.Drawing.Point(12, 219);
            this.lblConfirmPasswordHint.Name = "lblConfirmPasswordHint";
            this.lblConfirmPasswordHint.Size = new System.Drawing.Size(111, 13);
            this.lblConfirmPasswordHint.TabIndex = 15;
            this.lblConfirmPasswordHint.Text = "Confirm password";
            this.lblConfirmPasswordHint.Visible = false;
            // 
            // lblEmailHint
            // 
            this.lblEmailHint.AutoSize = true;
            this.lblEmailHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEmailHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmailHint.Location = new System.Drawing.Point(12, 261);
            this.lblEmailHint.Name = "lblEmailHint";
            this.lblEmailHint.Size = new System.Drawing.Size(38, 13);
            this.lblEmailHint.TabIndex = 16;
            this.lblEmailHint.Text = "Email";
            this.lblEmailHint.Visible = false;
            // 
            // lblSureNameHint
            // 
            this.lblSureNameHint.AutoSize = true;
            this.lblSureNameHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblSureNameHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSureNameHint.Location = new System.Drawing.Point(12, 302);
            this.lblSureNameHint.Name = "lblSureNameHint";
            this.lblSureNameHint.Size = new System.Drawing.Size(66, 13);
            this.lblSureNameHint.TabIndex = 17;
            this.lblSureNameHint.Text = "Surename";
            // 
            // lblLastNameHint
            // 
            this.lblLastNameHint.AutoSize = true;
            this.lblLastNameHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLastNameHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLastNameHint.Location = new System.Drawing.Point(12, 344);
            this.lblLastNameHint.Name = "lblLastNameHint";
            this.lblLastNameHint.Size = new System.Drawing.Size(62, 13);
            this.lblLastNameHint.TabIndex = 18;
            this.lblLastNameHint.Text = "Lastname";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 33);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(754, 321);
            this.Controls.Add(this.lblLastNameHint);
            this.Controls.Add(this.lblSureNameHint);
            this.Controls.Add(this.lblEmailHint);
            this.Controls.Add(this.lblConfirmPasswordHint);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.lblPasswordHint);
            this.Controls.Add(this.lblUsernameHint);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.lblRegisterHere);
            this.Controls.Add(this.cbAutoLogin);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSureName);
            this.Controls.Add(this.tbLastName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.CheckBox cbAutoLogin;
        private System.Windows.Forms.Label lblRegisterHere;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSureName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblConfirmPasswordHint;
        private System.Windows.Forms.Label lblEmailHint;
        private System.Windows.Forms.Label lblSureNameHint;
        private System.Windows.Forms.Label lblLastNameHint;
        private System.Windows.Forms.Label lblTitle;
    }
}

