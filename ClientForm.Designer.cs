
namespace BeerCourseWork
{
   partial class ClientForm
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
         this.ordersPage = new System.Windows.Forms.TabPage();
         this.openMyOrdersButton = new System.Windows.Forms.Button();
         this.createOrderButton = new System.Windows.Forms.Button();
         this.sumTextBox = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.addToCartButton = new System.Windows.Forms.Button();
         this.amountTextBox = new System.Windows.Forms.TextBox();
         this.productComboBox = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.profilePage = new System.Windows.Forms.TabPage();
         this.nameTextbox = new System.Windows.Forms.TextBox();
         this.emailTextbox = new System.Windows.Forms.TextBox();
         this.profileLabel = new System.Windows.Forms.Label();
         this.emailLabel = new System.Windows.Forms.Label();
         this.changeProfileButton = new System.Windows.Forms.Button();
         this.nameLabel = new System.Windows.Forms.Label();
         this.mainMenuTab = new System.Windows.Forms.TabControl();
         this.ordersPage.SuspendLayout();
         this.profilePage.SuspendLayout();
         this.mainMenuTab.SuspendLayout();
         this.SuspendLayout();
         // 
         // ordersPage
         // 
         this.ordersPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.ordersPage.Controls.Add(this.openMyOrdersButton);
         this.ordersPage.Controls.Add(this.createOrderButton);
         this.ordersPage.Controls.Add(this.sumTextBox);
         this.ordersPage.Controls.Add(this.label4);
         this.ordersPage.Controls.Add(this.addToCartButton);
         this.ordersPage.Controls.Add(this.amountTextBox);
         this.ordersPage.Controls.Add(this.productComboBox);
         this.ordersPage.Controls.Add(this.label3);
         this.ordersPage.Controls.Add(this.label2);
         this.ordersPage.Controls.Add(this.label1);
         this.ordersPage.Location = new System.Drawing.Point(4, 25);
         this.ordersPage.Name = "ordersPage";
         this.ordersPage.Size = new System.Drawing.Size(617, 431);
         this.ordersPage.TabIndex = 2;
         this.ordersPage.Text = "Мои заказы";
         this.ordersPage.UseVisualStyleBackColor = true;
         // 
         // openMyOrdersButton
         // 
         this.openMyOrdersButton.Location = new System.Drawing.Point(235, 353);
         this.openMyOrdersButton.Name = "openMyOrdersButton";
         this.openMyOrdersButton.Size = new System.Drawing.Size(144, 48);
         this.openMyOrdersButton.TabIndex = 10;
         this.openMyOrdersButton.Text = "Мои заказы";
         this.openMyOrdersButton.UseVisualStyleBackColor = true;
         this.openMyOrdersButton.Click += new System.EventHandler(this.openMyOrdersButton_Click);
         // 
         // createOrderButton
         // 
         this.createOrderButton.Location = new System.Drawing.Point(325, 244);
         this.createOrderButton.Name = "createOrderButton";
         this.createOrderButton.Size = new System.Drawing.Size(113, 45);
         this.createOrderButton.TabIndex = 9;
         this.createOrderButton.Text = "Оформить заказ";
         this.createOrderButton.UseVisualStyleBackColor = true;
         this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
         // 
         // sumTextBox
         // 
         this.sumTextBox.Location = new System.Drawing.Point(325, 170);
         this.sumTextBox.Name = "sumTextBox";
         this.sumTextBox.Size = new System.Drawing.Size(151, 22);
         this.sumTextBox.TabIndex = 7;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(110, 175);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(113, 17);
         this.label4.TabIndex = 6;
         this.label4.Text = "Итоговая сумма";
         // 
         // addToCartButton
         // 
         this.addToCartButton.Location = new System.Drawing.Point(171, 243);
         this.addToCartButton.Name = "addToCartButton";
         this.addToCartButton.Size = new System.Drawing.Size(119, 46);
         this.addToCartButton.TabIndex = 5;
         this.addToCartButton.Text = "Добавить в корзину";
         this.addToCartButton.UseVisualStyleBackColor = true;
         this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
         // 
         // amountTextBox
         // 
         this.amountTextBox.Location = new System.Drawing.Point(325, 122);
         this.amountTextBox.Name = "amountTextBox";
         this.amountTextBox.Size = new System.Drawing.Size(151, 22);
         this.amountTextBox.TabIndex = 4;
         // 
         // productComboBox
         // 
         this.productComboBox.FormattingEnabled = true;
         this.productComboBox.Location = new System.Drawing.Point(325, 73);
         this.productComboBox.Name = "productComboBox";
         this.productComboBox.Size = new System.Drawing.Size(151, 24);
         this.productComboBox.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(110, 128);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(86, 17);
         this.label3.TabIndex = 2;
         this.label3.Text = "Количество";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(110, 80);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(63, 17);
         this.label2.TabIndex = 1;
         this.label2.Text = "Продукт";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(201, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(200, 31);
         this.label1.TabIndex = 0;
         this.label1.Text = "Сделать заказ";
         // 
         // profilePage
         // 
         this.profilePage.Controls.Add(this.nameTextbox);
         this.profilePage.Controls.Add(this.emailTextbox);
         this.profilePage.Controls.Add(this.profileLabel);
         this.profilePage.Controls.Add(this.emailLabel);
         this.profilePage.Controls.Add(this.changeProfileButton);
         this.profilePage.Controls.Add(this.nameLabel);
         this.profilePage.Location = new System.Drawing.Point(4, 25);
         this.profilePage.Name = "profilePage";
         this.profilePage.Padding = new System.Windows.Forms.Padding(3);
         this.profilePage.Size = new System.Drawing.Size(617, 431);
         this.profilePage.TabIndex = 0;
         this.profilePage.Text = "Мой профиль";
         this.profilePage.UseVisualStyleBackColor = true;
         // 
         // nameTextbox
         // 
         this.nameTextbox.Location = new System.Drawing.Point(344, 89);
         this.nameTextbox.Name = "nameTextbox";
         this.nameTextbox.Size = new System.Drawing.Size(195, 22);
         this.nameTextbox.TabIndex = 3;
         // 
         // emailTextbox
         // 
         this.emailTextbox.Location = new System.Drawing.Point(344, 140);
         this.emailTextbox.Name = "emailTextbox";
         this.emailTextbox.Size = new System.Drawing.Size(195, 22);
         this.emailTextbox.TabIndex = 6;
         // 
         // profileLabel
         // 
         this.profileLabel.AutoSize = true;
         this.profileLabel.BackColor = System.Drawing.Color.Transparent;
         this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.profileLabel.ForeColor = System.Drawing.SystemColors.ControlText;
         this.profileLabel.Location = new System.Drawing.Point(216, 27);
         this.profileLabel.Name = "profileLabel";
         this.profileLabel.Size = new System.Drawing.Size(184, 31);
         this.profileLabel.TabIndex = 1;
         this.profileLabel.Text = "Мой профиль";
         this.profileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // emailLabel
         // 
         this.emailLabel.AutoSize = true;
         this.emailLabel.BackColor = System.Drawing.Color.Transparent;
         this.emailLabel.Location = new System.Drawing.Point(49, 143);
         this.emailLabel.Name = "emailLabel";
         this.emailLabel.Size = new System.Drawing.Size(42, 17);
         this.emailLabel.TabIndex = 4;
         this.emailLabel.Text = "Email";
         // 
         // changeProfileButton
         // 
         this.changeProfileButton.Location = new System.Drawing.Point(222, 219);
         this.changeProfileButton.Name = "changeProfileButton";
         this.changeProfileButton.Size = new System.Drawing.Size(178, 60);
         this.changeProfileButton.TabIndex = 7;
         this.changeProfileButton.Text = "Обновить данные профиля";
         this.changeProfileButton.UseVisualStyleBackColor = true;
         this.changeProfileButton.Click += new System.EventHandler(this.changeProfileButton_Click);
         // 
         // nameLabel
         // 
         this.nameLabel.AutoSize = true;
         this.nameLabel.BackColor = System.Drawing.Color.Transparent;
         this.nameLabel.Location = new System.Drawing.Point(50, 94);
         this.nameLabel.Name = "nameLabel";
         this.nameLabel.Size = new System.Drawing.Size(197, 17);
         this.nameLabel.TabIndex = 2;
         this.nameLabel.Text = "Имя / название организации";
         // 
         // mainMenuTab
         // 
         this.mainMenuTab.Controls.Add(this.profilePage);
         this.mainMenuTab.Controls.Add(this.ordersPage);
         this.mainMenuTab.Location = new System.Drawing.Point(12, 12);
         this.mainMenuTab.Name = "mainMenuTab";
         this.mainMenuTab.SelectedIndex = 0;
         this.mainMenuTab.Size = new System.Drawing.Size(625, 460);
         this.mainMenuTab.TabIndex = 10;
         // 
         // ClientForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(649, 484);
         this.Controls.Add(this.mainMenuTab);
         this.Name = "ClientForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ClientForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
         this.Load += new System.EventHandler(this.ClientForm_Load);
         this.ordersPage.ResumeLayout(false);
         this.ordersPage.PerformLayout();
         this.profilePage.ResumeLayout(false);
         this.profilePage.PerformLayout();
         this.mainMenuTab.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabPage ordersPage;
      private System.Windows.Forms.TabPage profilePage;
      private System.Windows.Forms.TextBox nameTextbox;
      private System.Windows.Forms.TextBox emailTextbox;
      private System.Windows.Forms.Label profileLabel;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.Button changeProfileButton;
      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.TabControl mainMenuTab;
      private System.Windows.Forms.TextBox sumTextBox;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button addToCartButton;
      private System.Windows.Forms.TextBox amountTextBox;
      private System.Windows.Forms.ComboBox productComboBox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button createOrderButton;
      private System.Windows.Forms.Button openMyOrdersButton;
   }
}