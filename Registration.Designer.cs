
namespace BeerCourseWork
{
   partial class Registration
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
         this.nameLabel = new System.Windows.Forms.Label();
         this.emailLabel = new System.Windows.Forms.Label();
         this.positionLabel = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.nameTextbox = new System.Windows.Forms.TextBox();
         this.emailTextbox = new System.Windows.Forms.TextBox();
         this.positionComboBox = new System.Windows.Forms.ComboBox();
         this.passwordTextbox = new System.Windows.Forms.TextBox();
         this.registerButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // nameLabel
         // 
         this.nameLabel.AutoSize = true;
         this.nameLabel.Location = new System.Drawing.Point(86, 65);
         this.nameLabel.Name = "nameLabel";
         this.nameLabel.Size = new System.Drawing.Size(233, 17);
         this.nameLabel.TabIndex = 0;
         this.nameLabel.Text = "Имя / Наименование организации";
         // 
         // emailLabel
         // 
         this.emailLabel.AutoSize = true;
         this.emailLabel.Location = new System.Drawing.Point(86, 113);
         this.emailLabel.Name = "emailLabel";
         this.emailLabel.Size = new System.Drawing.Size(42, 17);
         this.emailLabel.TabIndex = 1;
         this.emailLabel.Text = "Email";
         // 
         // positionLabel
         // 
         this.positionLabel.AutoSize = true;
         this.positionLabel.Location = new System.Drawing.Point(86, 164);
         this.positionLabel.Name = "positionLabel";
         this.positionLabel.Size = new System.Drawing.Size(65, 17);
         this.positionLabel.TabIndex = 2;
         this.positionLabel.Text = "Позиция";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(86, 216);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 17);
         this.label1.TabIndex = 3;
         this.label1.Text = "Пароль";
         // 
         // nameTextbox
         // 
         this.nameTextbox.Location = new System.Drawing.Point(432, 60);
         this.nameTextbox.Name = "nameTextbox";
         this.nameTextbox.Size = new System.Drawing.Size(229, 22);
         this.nameTextbox.TabIndex = 4;
         // 
         // emailTextbox
         // 
         this.emailTextbox.Location = new System.Drawing.Point(432, 108);
         this.emailTextbox.Name = "emailTextbox";
         this.emailTextbox.Size = new System.Drawing.Size(229, 22);
         this.emailTextbox.TabIndex = 5;
         // 
         // positionComboBox
         // 
         this.positionComboBox.FormattingEnabled = true;
         this.positionComboBox.Location = new System.Drawing.Point(432, 157);
         this.positionComboBox.Name = "positionComboBox";
         this.positionComboBox.Size = new System.Drawing.Size(229, 24);
         this.positionComboBox.TabIndex = 6;
         // 
         // passwordTextbox
         // 
         this.passwordTextbox.Location = new System.Drawing.Point(432, 211);
         this.passwordTextbox.Name = "passwordTextbox";
         this.passwordTextbox.Size = new System.Drawing.Size(229, 22);
         this.passwordTextbox.TabIndex = 7;
         // 
         // registerButton
         // 
         this.registerButton.Location = new System.Drawing.Point(571, 278);
         this.registerButton.Name = "registerButton";
         this.registerButton.Size = new System.Drawing.Size(187, 44);
         this.registerButton.TabIndex = 8;
         this.registerButton.Text = "Зарегистрироваться";
         this.registerButton.UseVisualStyleBackColor = true;
         this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
         // 
         // Registration
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 359);
         this.Controls.Add(this.registerButton);
         this.Controls.Add(this.passwordTextbox);
         this.Controls.Add(this.positionComboBox);
         this.Controls.Add(this.emailTextbox);
         this.Controls.Add(this.nameTextbox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.positionLabel);
         this.Controls.Add(this.emailLabel);
         this.Controls.Add(this.nameLabel);
         this.Name = "Registration";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Регистрация";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
         this.Load += new System.EventHandler(this.Registration_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.Label positionLabel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox nameTextbox;
      private System.Windows.Forms.TextBox emailTextbox;
      private System.Windows.Forms.ComboBox positionComboBox;
      private System.Windows.Forms.TextBox passwordTextbox;
      private System.Windows.Forms.Button registerButton;
   }
}