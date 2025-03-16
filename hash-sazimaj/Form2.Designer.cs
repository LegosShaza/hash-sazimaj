namespace hash_sazimaj
{
    partial class Form2
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(20, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(78, 13);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Vítejte, [jméno]";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(20, 60);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(150, 30);
            this.buttonChangePassword.TabIndex = 1;
            this.buttonChangePassword.Text = "Změnit heslo";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Location = new System.Drawing.Point(20, 100);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(150, 30);
            this.buttonManageUsers.TabIndex = 2;
            this.buttonManageUsers.Text = "Správa uživatelů";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Odhlásit se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonManageUsers);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button button1;
    }
}