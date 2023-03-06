namespace Kassa_Systeem
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
            this.password_login = new System.Windows.Forms.TextBox();
            this.userName_login = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.text_Username = new System.Windows.Forms.Label();
            this.Text_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_login
            // 
            this.password_login.Location = new System.Drawing.Point(872, 527);
            this.password_login.Name = "password_login";
            this.password_login.Size = new System.Drawing.Size(259, 23);
            this.password_login.TabIndex = 0;
            this.password_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userName_login
            // 
            this.userName_login.Location = new System.Drawing.Point(872, 464);
            this.userName_login.Name = "userName_login";
            this.userName_login.Size = new System.Drawing.Size(259, 23);
            this.userName_login.TabIndex = 1;
            this.userName_login.TextChanged += new System.EventHandler(this.userName_login_TextChanged);
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(872, 575);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(102, 44);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_Username
            // 
            this.text_Username.AutoSize = true;
            this.text_Username.Location = new System.Drawing.Point(872, 433);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(60, 15);
            this.text_Username.TabIndex = 3;
            this.text_Username.Text = "Username";
            this.text_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Text_Password
            // 
            this.Text_Password.AutoSize = true;
            this.Text_Password.Location = new System.Drawing.Point(872, 509);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(57, 15);
            this.Text_Password.TabIndex = 4;
            this.Text_Password.Text = "Password";
            // 
            // starscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1010);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.text_Username);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.userName_login);
            this.Controls.Add(this.password_login);
            this.Name = "starscherm";
            this.Text = "starscherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox password_login;
        private TextBox userName_login;
        private Button login_Button;
        private Label text_Username;
        private Label Text_Password;
    }
}