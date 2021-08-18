
namespace C969___PA
{
    partial class LoginScreen
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(265, 31);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Scheduling Calendar";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(109, 54);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 24);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login ";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(29, 134);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(66, 13);
            this.userName.TabIndex = 2;
            this.userName.Text = "User Name: ";
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(113, 127);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(100, 20);
            this.userNameTB.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(29, 173);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(113, 173);
            this.passwordTB.MaxLength = 25;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 5;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(58, 237);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(157, 237);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 316);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.mainLabel);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button closeButton;
    }
}

