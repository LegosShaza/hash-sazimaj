namespace hash_sazimaj
{
    partial class Form4
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
            this.labelNewusername = new System.Windows.Forms.Label();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewusername
            // 
            this.labelNewusername.AutoSize = true;
            this.labelNewusername.Location = new System.Drawing.Point(20, 20);
            this.labelNewusername.Name = "labelNewusername";
            this.labelNewusername.Size = new System.Drawing.Size(123, 13);
            this.labelNewusername.TabIndex = 0;
            this.labelNewusername.Text = "Nové uživatelské jméno:";
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Location = new System.Drawing.Point(150, 20);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(150, 20);
            this.textBoxNewUsername.TabIndex = 1;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(20, 60);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(64, 13);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "Nové heslo:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(150, 60);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(150, 90);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsAdmin.TabIndex = 4;
            this.checkBoxIsAdmin.Text = "Je admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(150, 130);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveUser.TabIndex = 5;
            this.buttonSaveUser.Text = "Uložit";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.textBoxNewUsername);
            this.Controls.Add(this.labelNewusername);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewusername;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Button buttonSaveUser;
    }
}