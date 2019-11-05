namespace TvSeriesApplication
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.txtNewUserPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewUserPass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegister.Location = new System.Drawing.Point(212, 164);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(187, 40);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(100, 20);
            this.txtNewUser.TabIndex = 3;
            // 
            // txtNewUserPass
            // 
            this.txtNewUserPass.Location = new System.Drawing.Point(187, 79);
            this.txtNewUserPass.Name = "txtNewUserPass";
            this.txtNewUserPass.PasswordChar = '*';
            this.txtNewUserPass.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // txtNewUserPass2
            // 
            this.txtNewUserPass2.Location = new System.Drawing.Point(187, 122);
            this.txtNewUserPass2.Name = "txtNewUserPass2";
            this.txtNewUserPass2.PasswordChar = '*';
            this.txtNewUserPass2.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserPass2.TabIndex = 6;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(342, 223);
            this.Controls.Add(this.txtNewUserPass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewUserPass);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.TextBox txtNewUser;
        public System.Windows.Forms.TextBox txtNewUserPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewUserPass2;
    }
}