
namespace BeerCourseWork
{
   partial class Authorization
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
         this.cn = new System.Data.OleDb.OleDbConnection();
         this.emailLabel = new System.Windows.Forms.Label();
         this.passwordLabel = new System.Windows.Forms.Label();
         this.emailTextbox = new System.Windows.Forms.TextBox();
         this.passwordTextbox = new System.Windows.Forms.TextBox();
         this.loginButton = new System.Windows.Forms.Button();
         this.registerButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // cn
         // 
         this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-MCCPRDD\\GREENKNIGHT;Integrated Security=SS" +
    "PI;Initial Catalog=Beer";
         // 
         // emailLabel
         // 
         this.emailLabel.AutoSize = true;
         this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.emailLabel.Location = new System.Drawing.Point(78, 90);
         this.emailLabel.Name = "emailLabel";
         this.emailLabel.Size = new System.Drawing.Size(42, 17);
         this.emailLabel.TabIndex = 0;
         this.emailLabel.Text = "Email";
         // 
         // passwordLabel
         // 
         this.passwordLabel.AutoSize = true;
         this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.passwordLabel.Location = new System.Drawing.Point(78, 146);
         this.passwordLabel.Name = "passwordLabel";
         this.passwordLabel.Size = new System.Drawing.Size(57, 17);
         this.passwordLabel.TabIndex = 1;
         this.passwordLabel.Text = "Пароль";
         // 
         // emailTextbox
         // 
         this.emailTextbox.Location = new System.Drawing.Point(205, 90);
         this.emailTextbox.Name = "emailTextbox";
         this.emailTextbox.Size = new System.Drawing.Size(249, 22);
         this.emailTextbox.TabIndex = 2;
         // 
         // passwordTextbox
         // 
         this.passwordTextbox.Location = new System.Drawing.Point(205, 146);
         this.passwordTextbox.Name = "passwordTextbox";
         this.passwordTextbox.Size = new System.Drawing.Size(249, 22);
         this.passwordTextbox.TabIndex = 3;
         // 
         // loginButton
         // 
         this.loginButton.Location = new System.Drawing.Point(205, 204);
         this.loginButton.Name = "loginButton";
         this.loginButton.Size = new System.Drawing.Size(116, 33);
         this.loginButton.TabIndex = 5;
         this.loginButton.Text = "Войти";
         this.loginButton.UseVisualStyleBackColor = true;
         this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
         // 
         // registerButton
         // 
         this.registerButton.Location = new System.Drawing.Point(382, 288);
         this.registerButton.Name = "registerButton";
         this.registerButton.Size = new System.Drawing.Size(121, 36);
         this.registerButton.TabIndex = 6;
         this.registerButton.Text = "Регистрация";
         this.registerButton.UseVisualStyleBackColor = true;
         this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(78, 298);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(186, 17);
         this.label1.TabIndex = 4;
         this.label1.Text = "У вас нет учетной записи?";
         // 
         // Authorization
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(552, 383);
         this.Controls.Add(this.registerButton);
         this.Controls.Add(this.loginButton);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.passwordTextbox);
         this.Controls.Add(this.emailTextbox);
         this.Controls.Add(this.passwordLabel);
         this.Controls.Add(this.emailLabel);
         this.Name = "Authorization";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Авторизация";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
         this.Load += new System.EventHandler(this.BeerManiaLogin_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Data.OleDb.OleDbConnection cn;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.Label passwordLabel;
      private System.Windows.Forms.TextBox emailTextbox;
      private System.Windows.Forms.TextBox passwordTextbox;
      private System.Windows.Forms.Button loginButton;
      private System.Windows.Forms.Button registerButton;
      private System.Windows.Forms.Label label1;
   }
}

