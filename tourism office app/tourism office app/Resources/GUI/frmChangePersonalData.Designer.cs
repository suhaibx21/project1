
namespace tourism_office_app.Resources.GUI
{
    partial class frmChangePersonalData
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblpas = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangepass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(52, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblpas
            // 
            this.lblpas.AutoSize = true;
            this.lblpas.Location = new System.Drawing.Point(52, 112);
            this.lblpas.Name = "lblpas";
            this.lblpas.Size = new System.Drawing.Size(69, 17);
            this.lblpas.TabIndex = 1;
            this.lblpas.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 50);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Suhaib.khresha@gmil.com";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 33);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "1232152";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Location = new System.Drawing.Point(429, 50);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(93, 35);
            this.btnChangeEmail.TabIndex = 4;
            this.btnChangeEmail.Text = "Change";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            // 
            // btnChangepass
            // 
            this.btnChangepass.Location = new System.Drawing.Point(429, 112);
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.Size = new System.Drawing.Size(93, 35);
            this.btnChangepass.TabIndex = 5;
            this.btnChangepass.Text = "Change";
            this.btnChangepass.UseVisualStyleBackColor = true;
            // 
            // frmChangePersonalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangepass);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblpas);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmChangePersonalData";
            this.Text = "frmChangePersonalData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblpas;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Button btnChangepass;
    }
}