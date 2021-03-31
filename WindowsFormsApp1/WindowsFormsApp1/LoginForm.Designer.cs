namespace WindowsFormsApp1
{
    partial class Login_window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Authorization_button = new System.Windows.Forms.Button();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 21);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(29, 13);
            this.Login.TabIndex = 0;
            this.Login.Text = "Имя";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(11, 51);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(45, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Пароль";
            // 
            // Authorization_button
            // 
            this.Authorization_button.Location = new System.Drawing.Point(67, 70);
            this.Authorization_button.Name = "Authorization_button";
            this.Authorization_button.Size = new System.Drawing.Size(121, 27);
            this.Authorization_button.TabIndex = 2;
            this.Authorization_button.Text = "Вход";
            this.Authorization_button.UseVisualStyleBackColor = true;
            this.Authorization_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(67, 14);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(121, 20);
            this.Login_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(67, 44);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(121, 20);
            this.Password_textBox.TabIndex = 4;
            // 
            // Login_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(195, 104);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Authorization_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(211, 143);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(211, 143);
            this.Name = "Login_window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Authorization_button;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
    }
}

