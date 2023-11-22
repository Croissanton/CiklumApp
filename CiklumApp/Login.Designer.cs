namespace CiklumApp
{
    partial class Login
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
            this.lUsername = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bSignin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(345, 120);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(55, 13);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "Username";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(345, 186);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(53, 13);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(290, 150);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(177, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(290, 217);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(177, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // bSignin
            // 
            this.bSignin.Location = new System.Drawing.Point(326, 281);
            this.bSignin.Name = "bSignin";
            this.bSignin.Size = new System.Drawing.Size(89, 38);
            this.bSignin.TabIndex = 4;
            this.bSignin.Text = "Sign in";
            this.bSignin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSignin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bSignin;
    }
}