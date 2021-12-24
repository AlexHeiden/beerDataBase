
namespace BeerCourseWork
{
   partial class PurchaserForm
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
         this.profileLabel = new System.Windows.Forms.Label();
         this.nameLabel = new System.Windows.Forms.Label();
         this.nameTextbox = new System.Windows.Forms.TextBox();
         this.emailLabel = new System.Windows.Forms.Label();
         this.userEmailLabel = new System.Windows.Forms.Label();
         this.emailTextbox = new System.Windows.Forms.TextBox();
         this.changeProfileButton = new System.Windows.Forms.Button();
         this.mainMenuTab = new System.Windows.Forms.TabControl();
         this.profilePage = new System.Windows.Forms.TabPage();
         this.providerPage = new System.Windows.Forms.TabPage();
         this.openProviderTableButton = new System.Windows.Forms.Button();
         this.addProviderLabel = new System.Windows.Forms.Label();
         this.addProviderButton = new System.Windows.Forms.Button();
         this.addProviderAddressTextbox = new System.Windows.Forms.TextBox();
         this.addProviderNameTextBox = new System.Windows.Forms.TextBox();
         this.addressLabel = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.providerPricesPage = new System.Windows.Forms.TabPage();
         this.openProviderPricesButton = new System.Windows.Forms.Button();
         this.analyzePriceButton = new System.Windows.Forms.Button();
         this.analyzePriceIngredientComboBox = new System.Windows.Forms.ComboBox();
         this.analyzePriceIngredientLabel = new System.Windows.Forms.Label();
         this.analyzePriceLabel = new System.Windows.Forms.Label();
         this.addPriceLabel = new System.Windows.Forms.Label();
         this.addPriceButton = new System.Windows.Forms.Button();
         this.addPricePriceTextBox = new System.Windows.Forms.TextBox();
         this.addPriceIngredientComboBox = new System.Windows.Forms.ComboBox();
         this.addPriceProviderComboBox = new System.Windows.Forms.ComboBox();
         this.addPricePriceLabel = new System.Windows.Forms.Label();
         this.addPriceIngredientLabel = new System.Windows.Forms.Label();
         this.addPriceProviderLabel = new System.Windows.Forms.Label();
         this.orderPage = new System.Windows.Forms.TabPage();
         this.addOrderLabel = new System.Windows.Forms.Label();
         this.addOrderProviderLabel = new System.Windows.Forms.Label();
         this.addOrderIngredientLabel = new System.Windows.Forms.Label();
         this.addOrderWeightLabel = new System.Windows.Forms.Label();
         this.addOrderDateLabel = new System.Windows.Forms.Label();
         this.addOrderProviderComboBox = new System.Windows.Forms.ComboBox();
         this.addOrderIngredientComboBox = new System.Windows.Forms.ComboBox();
         this.addOrderWeightTextBox = new System.Windows.Forms.TextBox();
         this.addOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.addOrderButton = new System.Windows.Forms.Button();
         this.changeOrderStatusLabel = new System.Windows.Forms.Label();
         this.changeOrderStatusNumberLabel = new System.Windows.Forms.Label();
         this.changeOrderStatusStatusLabel = new System.Windows.Forms.Label();
         this.changeOrderStatusStatusComboBox = new System.Windows.Forms.ComboBox();
         this.changeOrderStatusButton = new System.Windows.Forms.Button();
         this.openIngredientOrdersTable = new System.Windows.Forms.Button();
         this.changeOrderStatusNumberComboBox = new System.Windows.Forms.ComboBox();
         this.mainMenuTab.SuspendLayout();
         this.profilePage.SuspendLayout();
         this.providerPage.SuspendLayout();
         this.providerPricesPage.SuspendLayout();
         this.orderPage.SuspendLayout();
         this.SuspendLayout();
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
         // nameTextbox
         // 
         this.nameTextbox.Location = new System.Drawing.Point(344, 89);
         this.nameTextbox.Name = "nameTextbox";
         this.nameTextbox.Size = new System.Drawing.Size(195, 22);
         this.nameTextbox.TabIndex = 3;
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
         // userEmailLabel
         // 
         this.userEmailLabel.AutoSize = true;
         this.userEmailLabel.Location = new System.Drawing.Point(416, 180);
         this.userEmailLabel.Name = "userEmailLabel";
         this.userEmailLabel.Size = new System.Drawing.Size(0, 17);
         this.userEmailLabel.TabIndex = 5;
         // 
         // emailTextbox
         // 
         this.emailTextbox.Location = new System.Drawing.Point(344, 140);
         this.emailTextbox.Name = "emailTextbox";
         this.emailTextbox.Size = new System.Drawing.Size(195, 22);
         this.emailTextbox.TabIndex = 6;
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
         // mainMenuTab
         // 
         this.mainMenuTab.Controls.Add(this.profilePage);
         this.mainMenuTab.Controls.Add(this.providerPage);
         this.mainMenuTab.Controls.Add(this.providerPricesPage);
         this.mainMenuTab.Controls.Add(this.orderPage);
         this.mainMenuTab.Location = new System.Drawing.Point(12, 12);
         this.mainMenuTab.Name = "mainMenuTab";
         this.mainMenuTab.SelectedIndex = 0;
         this.mainMenuTab.Size = new System.Drawing.Size(610, 482);
         this.mainMenuTab.TabIndex = 8;
         this.mainMenuTab.SelectedIndexChanged += new System.EventHandler(this.mainMenuTab_SelectedIndexChanged);
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
         this.profilePage.Size = new System.Drawing.Size(602, 453);
         this.profilePage.TabIndex = 0;
         this.profilePage.Text = "Мой профиль";
         this.profilePage.UseVisualStyleBackColor = true;
         // 
         // providerPage
         // 
         this.providerPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.providerPage.Controls.Add(this.openProviderTableButton);
         this.providerPage.Controls.Add(this.addProviderLabel);
         this.providerPage.Controls.Add(this.addProviderButton);
         this.providerPage.Controls.Add(this.addProviderAddressTextbox);
         this.providerPage.Controls.Add(this.addProviderNameTextBox);
         this.providerPage.Controls.Add(this.addressLabel);
         this.providerPage.Controls.Add(this.label1);
         this.providerPage.Location = new System.Drawing.Point(4, 25);
         this.providerPage.Name = "providerPage";
         this.providerPage.Size = new System.Drawing.Size(602, 453);
         this.providerPage.TabIndex = 2;
         this.providerPage.Text = "Поставщики";
         this.providerPage.UseVisualStyleBackColor = true;
         // 
         // openProviderTableButton
         // 
         this.openProviderTableButton.Location = new System.Drawing.Point(203, 294);
         this.openProviderTableButton.Name = "openProviderTableButton";
         this.openProviderTableButton.Size = new System.Drawing.Size(177, 40);
         this.openProviderTableButton.TabIndex = 11;
         this.openProviderTableButton.Text = "Открыть таблицу";
         this.openProviderTableButton.UseVisualStyleBackColor = true;
         this.openProviderTableButton.Click += new System.EventHandler(this.openProviderLabelButton_Click);
         // 
         // addProviderLabel
         // 
         this.addProviderLabel.AutoSize = true;
         this.addProviderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.addProviderLabel.Location = new System.Drawing.Point(151, 36);
         this.addProviderLabel.Name = "addProviderLabel";
         this.addProviderLabel.Size = new System.Drawing.Size(293, 31);
         this.addProviderLabel.TabIndex = 10;
         this.addProviderLabel.Text = "Добавить поставщика";
         // 
         // addProviderButton
         // 
         this.addProviderButton.Location = new System.Drawing.Point(245, 218);
         this.addProviderButton.Name = "addProviderButton";
         this.addProviderButton.Size = new System.Drawing.Size(98, 31);
         this.addProviderButton.TabIndex = 9;
         this.addProviderButton.Text = "Добавить";
         this.addProviderButton.UseVisualStyleBackColor = true;
         this.addProviderButton.Click += new System.EventHandler(this.addProviderButton_Click);
         // 
         // addProviderAddressTextbox
         // 
         this.addProviderAddressTextbox.Location = new System.Drawing.Point(335, 156);
         this.addProviderAddressTextbox.Name = "addProviderAddressTextbox";
         this.addProviderAddressTextbox.Size = new System.Drawing.Size(189, 22);
         this.addProviderAddressTextbox.TabIndex = 8;
         // 
         // addProviderNameTextBox
         // 
         this.addProviderNameTextBox.Location = new System.Drawing.Point(335, 101);
         this.addProviderNameTextBox.Name = "addProviderNameTextBox";
         this.addProviderNameTextBox.Size = new System.Drawing.Size(189, 22);
         this.addProviderNameTextBox.TabIndex = 7;
         // 
         // addressLabel
         // 
         this.addressLabel.AutoSize = true;
         this.addressLabel.Location = new System.Drawing.Point(79, 161);
         this.addressLabel.Name = "addressLabel";
         this.addressLabel.Size = new System.Drawing.Size(48, 17);
         this.addressLabel.TabIndex = 6;
         this.addressLabel.Text = "Адрес";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(79, 106);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(199, 17);
         this.label1.TabIndex = 5;
         this.label1.Text = "Имя / Название организации";
         // 
         // providerPricesPage
         // 
         this.providerPricesPage.Controls.Add(this.openProviderPricesButton);
         this.providerPricesPage.Controls.Add(this.analyzePriceButton);
         this.providerPricesPage.Controls.Add(this.analyzePriceIngredientComboBox);
         this.providerPricesPage.Controls.Add(this.analyzePriceIngredientLabel);
         this.providerPricesPage.Controls.Add(this.analyzePriceLabel);
         this.providerPricesPage.Controls.Add(this.addPriceLabel);
         this.providerPricesPage.Controls.Add(this.addPriceButton);
         this.providerPricesPage.Controls.Add(this.addPricePriceTextBox);
         this.providerPricesPage.Controls.Add(this.addPriceIngredientComboBox);
         this.providerPricesPage.Controls.Add(this.addPriceProviderComboBox);
         this.providerPricesPage.Controls.Add(this.addPricePriceLabel);
         this.providerPricesPage.Controls.Add(this.addPriceIngredientLabel);
         this.providerPricesPage.Controls.Add(this.addPriceProviderLabel);
         this.providerPricesPage.Location = new System.Drawing.Point(4, 25);
         this.providerPricesPage.Name = "providerPricesPage";
         this.providerPricesPage.Padding = new System.Windows.Forms.Padding(3);
         this.providerPricesPage.Size = new System.Drawing.Size(602, 453);
         this.providerPricesPage.TabIndex = 1;
         this.providerPricesPage.Text = "Цены поставщиков";
         this.providerPricesPage.UseVisualStyleBackColor = true;
         // 
         // openProviderPricesButton
         // 
         this.openProviderPricesButton.Location = new System.Drawing.Point(176, 357);
         this.openProviderPricesButton.Name = "openProviderPricesButton";
         this.openProviderPricesButton.Size = new System.Drawing.Size(177, 40);
         this.openProviderPricesButton.TabIndex = 19;
         this.openProviderPricesButton.Text = "Открыть таблицу";
         this.openProviderPricesButton.UseVisualStyleBackColor = true;
         this.openProviderPricesButton.Click += new System.EventHandler(this.openProviderPricesButton_Click);
         // 
         // analyzePriceButton
         // 
         this.analyzePriceButton.Location = new System.Drawing.Point(213, 303);
         this.analyzePriceButton.Name = "analyzePriceButton";
         this.analyzePriceButton.Size = new System.Drawing.Size(90, 30);
         this.analyzePriceButton.TabIndex = 18;
         this.analyzePriceButton.Text = "Свести";
         this.analyzePriceButton.UseVisualStyleBackColor = true;
         this.analyzePriceButton.Click += new System.EventHandler(this.analyzePriceButton_Click);
         // 
         // analyzePriceIngredientComboBox
         // 
         this.analyzePriceIngredientComboBox.FormattingEnabled = true;
         this.analyzePriceIngredientComboBox.Location = new System.Drawing.Point(316, 250);
         this.analyzePriceIngredientComboBox.Name = "analyzePriceIngredientComboBox";
         this.analyzePriceIngredientComboBox.Size = new System.Drawing.Size(121, 24);
         this.analyzePriceIngredientComboBox.TabIndex = 17;
         // 
         // analyzePriceIngredientLabel
         // 
         this.analyzePriceIngredientLabel.AutoSize = true;
         this.analyzePriceIngredientLabel.Location = new System.Drawing.Point(105, 257);
         this.analyzePriceIngredientLabel.Name = "analyzePriceIngredientLabel";
         this.analyzePriceIngredientLabel.Size = new System.Drawing.Size(86, 17);
         this.analyzePriceIngredientLabel.TabIndex = 16;
         this.analyzePriceIngredientLabel.Text = "Ингредиент";
         // 
         // analyzePriceLabel
         // 
         this.analyzePriceLabel.AutoSize = true;
         this.analyzePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.analyzePriceLabel.Location = new System.Drawing.Point(209, 224);
         this.analyzePriceLabel.Name = "analyzePriceLabel";
         this.analyzePriceLabel.Size = new System.Drawing.Size(117, 20);
         this.analyzePriceLabel.TabIndex = 15;
         this.analyzePriceLabel.Text = "Свести цены";
         // 
         // addPriceLabel
         // 
         this.addPriceLabel.AutoSize = true;
         this.addPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.addPriceLabel.Location = new System.Drawing.Point(161, 13);
         this.addPriceLabel.Name = "addPriceLabel";
         this.addPriceLabel.Size = new System.Drawing.Size(221, 20);
         this.addPriceLabel.TabIndex = 14;
         this.addPriceLabel.Text = "Добавить/изменить цену";
         // 
         // addPriceButton
         // 
         this.addPriceButton.Location = new System.Drawing.Point(176, 171);
         this.addPriceButton.Name = "addPriceButton";
         this.addPriceButton.Size = new System.Drawing.Size(177, 39);
         this.addPriceButton.TabIndex = 13;
         this.addPriceButton.Text = "Добавить/изменить";
         this.addPriceButton.UseVisualStyleBackColor = true;
         this.addPriceButton.Click += new System.EventHandler(this.addPriceButton_Click);
         // 
         // addPricePriceTextBox
         // 
         this.addPricePriceTextBox.Location = new System.Drawing.Point(316, 125);
         this.addPricePriceTextBox.Name = "addPricePriceTextBox";
         this.addPricePriceTextBox.Size = new System.Drawing.Size(121, 22);
         this.addPricePriceTextBox.TabIndex = 12;
         // 
         // addPriceIngredientComboBox
         // 
         this.addPriceIngredientComboBox.FormattingEnabled = true;
         this.addPriceIngredientComboBox.Location = new System.Drawing.Point(316, 87);
         this.addPriceIngredientComboBox.Name = "addPriceIngredientComboBox";
         this.addPriceIngredientComboBox.Size = new System.Drawing.Size(121, 24);
         this.addPriceIngredientComboBox.TabIndex = 11;
         // 
         // addPriceProviderComboBox
         // 
         this.addPriceProviderComboBox.FormattingEnabled = true;
         this.addPriceProviderComboBox.Location = new System.Drawing.Point(316, 49);
         this.addPriceProviderComboBox.Name = "addPriceProviderComboBox";
         this.addPriceProviderComboBox.Size = new System.Drawing.Size(204, 24);
         this.addPriceProviderComboBox.TabIndex = 10;
         // 
         // addPricePriceLabel
         // 
         this.addPricePriceLabel.AutoSize = true;
         this.addPricePriceLabel.Location = new System.Drawing.Point(110, 130);
         this.addPricePriceLabel.Name = "addPricePriceLabel";
         this.addPricePriceLabel.Size = new System.Drawing.Size(90, 17);
         this.addPricePriceLabel.TabIndex = 9;
         this.addPricePriceLabel.Text = "Цена за 1 кг";
         // 
         // addPriceIngredientLabel
         // 
         this.addPriceIngredientLabel.AutoSize = true;
         this.addPriceIngredientLabel.Location = new System.Drawing.Point(110, 94);
         this.addPriceIngredientLabel.Name = "addPriceIngredientLabel";
         this.addPriceIngredientLabel.Size = new System.Drawing.Size(86, 17);
         this.addPriceIngredientLabel.TabIndex = 8;
         this.addPriceIngredientLabel.Text = "Ингредиент";
         // 
         // addPriceProviderLabel
         // 
         this.addPriceProviderLabel.AutoSize = true;
         this.addPriceProviderLabel.Location = new System.Drawing.Point(110, 56);
         this.addPriceProviderLabel.Name = "addPriceProviderLabel";
         this.addPriceProviderLabel.Size = new System.Drawing.Size(81, 17);
         this.addPriceProviderLabel.TabIndex = 7;
         this.addPriceProviderLabel.Text = "Поставщик";
         // 
         // orderPage
         // 
         this.orderPage.Controls.Add(this.changeOrderStatusNumberComboBox);
         this.orderPage.Controls.Add(this.openIngredientOrdersTable);
         this.orderPage.Controls.Add(this.changeOrderStatusButton);
         this.orderPage.Controls.Add(this.changeOrderStatusStatusComboBox);
         this.orderPage.Controls.Add(this.changeOrderStatusStatusLabel);
         this.orderPage.Controls.Add(this.changeOrderStatusNumberLabel);
         this.orderPage.Controls.Add(this.changeOrderStatusLabel);
         this.orderPage.Controls.Add(this.addOrderButton);
         this.orderPage.Controls.Add(this.addOrderDateTimePicker);
         this.orderPage.Controls.Add(this.addOrderWeightTextBox);
         this.orderPage.Controls.Add(this.addOrderIngredientComboBox);
         this.orderPage.Controls.Add(this.addOrderProviderComboBox);
         this.orderPage.Controls.Add(this.addOrderDateLabel);
         this.orderPage.Controls.Add(this.addOrderWeightLabel);
         this.orderPage.Controls.Add(this.addOrderIngredientLabel);
         this.orderPage.Controls.Add(this.addOrderProviderLabel);
         this.orderPage.Controls.Add(this.addOrderLabel);
         this.orderPage.Location = new System.Drawing.Point(4, 25);
         this.orderPage.Name = "orderPage";
         this.orderPage.Size = new System.Drawing.Size(602, 453);
         this.orderPage.TabIndex = 3;
         this.orderPage.Text = "Заказы ингредиентов";
         this.orderPage.UseVisualStyleBackColor = true;
         // 
         // addOrderLabel
         // 
         this.addOrderLabel.AutoSize = true;
         this.addOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.addOrderLabel.Location = new System.Drawing.Point(215, 14);
         this.addOrderLabel.Name = "addOrderLabel";
         this.addOrderLabel.Size = new System.Drawing.Size(148, 25);
         this.addOrderLabel.TabIndex = 0;
         this.addOrderLabel.Text = "Создать заказ";
         // 
         // addOrderProviderLabel
         // 
         this.addOrderProviderLabel.AutoSize = true;
         this.addOrderProviderLabel.Location = new System.Drawing.Point(92, 65);
         this.addOrderProviderLabel.Name = "addOrderProviderLabel";
         this.addOrderProviderLabel.Size = new System.Drawing.Size(81, 17);
         this.addOrderProviderLabel.TabIndex = 1;
         this.addOrderProviderLabel.Text = "Поставщик";
         // 
         // addOrderIngredientLabel
         // 
         this.addOrderIngredientLabel.AutoSize = true;
         this.addOrderIngredientLabel.Location = new System.Drawing.Point(92, 100);
         this.addOrderIngredientLabel.Name = "addOrderIngredientLabel";
         this.addOrderIngredientLabel.Size = new System.Drawing.Size(86, 17);
         this.addOrderIngredientLabel.TabIndex = 2;
         this.addOrderIngredientLabel.Text = "Ингредиент";
         // 
         // addOrderWeightLabel
         // 
         this.addOrderWeightLabel.AutoSize = true;
         this.addOrderWeightLabel.Location = new System.Drawing.Point(92, 134);
         this.addOrderWeightLabel.Name = "addOrderWeightLabel";
         this.addOrderWeightLabel.Size = new System.Drawing.Size(32, 17);
         this.addOrderWeightLabel.TabIndex = 3;
         this.addOrderWeightLabel.Text = "Вес";
         // 
         // addOrderDateLabel
         // 
         this.addOrderDateLabel.AutoSize = true;
         this.addOrderDateLabel.Location = new System.Drawing.Point(92, 170);
         this.addOrderDateLabel.Name = "addOrderDateLabel";
         this.addOrderDateLabel.Size = new System.Drawing.Size(42, 17);
         this.addOrderDateLabel.TabIndex = 4;
         this.addOrderDateLabel.Text = "Дата";
         // 
         // addOrderProviderComboBox
         // 
         this.addOrderProviderComboBox.FormattingEnabled = true;
         this.addOrderProviderComboBox.Location = new System.Drawing.Point(339, 58);
         this.addOrderProviderComboBox.Name = "addOrderProviderComboBox";
         this.addOrderProviderComboBox.Size = new System.Drawing.Size(204, 24);
         this.addOrderProviderComboBox.TabIndex = 5;
         // 
         // addOrderIngredientComboBox
         // 
         this.addOrderIngredientComboBox.FormattingEnabled = true;
         this.addOrderIngredientComboBox.Location = new System.Drawing.Point(339, 93);
         this.addOrderIngredientComboBox.Name = "addOrderIngredientComboBox";
         this.addOrderIngredientComboBox.Size = new System.Drawing.Size(136, 24);
         this.addOrderIngredientComboBox.TabIndex = 6;
         // 
         // addOrderWeightTextBox
         // 
         this.addOrderWeightTextBox.Location = new System.Drawing.Point(339, 128);
         this.addOrderWeightTextBox.Name = "addOrderWeightTextBox";
         this.addOrderWeightTextBox.Size = new System.Drawing.Size(136, 22);
         this.addOrderWeightTextBox.TabIndex = 7;
         // 
         // addOrderDateTimePicker
         // 
         this.addOrderDateTimePicker.Location = new System.Drawing.Point(339, 164);
         this.addOrderDateTimePicker.Name = "addOrderDateTimePicker";
         this.addOrderDateTimePicker.Size = new System.Drawing.Size(200, 22);
         this.addOrderDateTimePicker.TabIndex = 8;
         // 
         // addOrderButton
         // 
         this.addOrderButton.Location = new System.Drawing.Point(220, 208);
         this.addOrderButton.Name = "addOrderButton";
         this.addOrderButton.Size = new System.Drawing.Size(133, 32);
         this.addOrderButton.TabIndex = 9;
         this.addOrderButton.Text = "Создать";
         this.addOrderButton.UseVisualStyleBackColor = true;
         this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
         // 
         // changeOrderStatusLabel
         // 
         this.changeOrderStatusLabel.AutoSize = true;
         this.changeOrderStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.changeOrderStatusLabel.Location = new System.Drawing.Point(165, 256);
         this.changeOrderStatusLabel.Name = "changeOrderStatusLabel";
         this.changeOrderStatusLabel.Size = new System.Drawing.Size(244, 25);
         this.changeOrderStatusLabel.TabIndex = 10;
         this.changeOrderStatusLabel.Text = "Изменить статус заказа";
         // 
         // changeOrderStatusNumberLabel
         // 
         this.changeOrderStatusNumberLabel.AutoSize = true;
         this.changeOrderStatusNumberLabel.Location = new System.Drawing.Point(95, 301);
         this.changeOrderStatusNumberLabel.Name = "changeOrderStatusNumberLabel";
         this.changeOrderStatusNumberLabel.Size = new System.Drawing.Size(100, 17);
         this.changeOrderStatusNumberLabel.TabIndex = 11;
         this.changeOrderStatusNumberLabel.Text = "Номер заказа";
         // 
         // changeOrderStatusStatusLabel
         // 
         this.changeOrderStatusStatusLabel.AutoSize = true;
         this.changeOrderStatusStatusLabel.Location = new System.Drawing.Point(95, 334);
         this.changeOrderStatusStatusLabel.Name = "changeOrderStatusStatusLabel";
         this.changeOrderStatusStatusLabel.Size = new System.Drawing.Size(53, 17);
         this.changeOrderStatusStatusLabel.TabIndex = 12;
         this.changeOrderStatusStatusLabel.Text = "Статус";
         // 
         // changeOrderStatusStatusComboBox
         // 
         this.changeOrderStatusStatusComboBox.FormattingEnabled = true;
         this.changeOrderStatusStatusComboBox.Location = new System.Drawing.Point(339, 325);
         this.changeOrderStatusStatusComboBox.Name = "changeOrderStatusStatusComboBox";
         this.changeOrderStatusStatusComboBox.Size = new System.Drawing.Size(136, 24);
         this.changeOrderStatusStatusComboBox.TabIndex = 14;
         // 
         // changeOrderStatusButton
         // 
         this.changeOrderStatusButton.Location = new System.Drawing.Point(220, 363);
         this.changeOrderStatusButton.Name = "changeOrderStatusButton";
         this.changeOrderStatusButton.Size = new System.Drawing.Size(133, 33);
         this.changeOrderStatusButton.TabIndex = 15;
         this.changeOrderStatusButton.Text = "Изменить";
         this.changeOrderStatusButton.UseVisualStyleBackColor = true;
         this.changeOrderStatusButton.Click += new System.EventHandler(this.changeOrderStatusButton_Click);
         // 
         // openIngredientOrdersTable
         // 
         this.openIngredientOrdersTable.Location = new System.Drawing.Point(195, 402);
         this.openIngredientOrdersTable.Name = "openIngredientOrdersTable";
         this.openIngredientOrdersTable.Size = new System.Drawing.Size(177, 40);
         this.openIngredientOrdersTable.TabIndex = 20;
         this.openIngredientOrdersTable.Text = "Открыть таблицу";
         this.openIngredientOrdersTable.UseVisualStyleBackColor = true;
         this.openIngredientOrdersTable.Click += new System.EventHandler(this.openIngredientOrdersTable_Click);
         // 
         // changeOrderStatusNumberComboBox
         // 
         this.changeOrderStatusNumberComboBox.FormattingEnabled = true;
         this.changeOrderStatusNumberComboBox.Location = new System.Drawing.Point(339, 292);
         this.changeOrderStatusNumberComboBox.Name = "changeOrderStatusNumberComboBox";
         this.changeOrderStatusNumberComboBox.Size = new System.Drawing.Size(136, 24);
         this.changeOrderStatusNumberComboBox.TabIndex = 21;
         // 
         // PurchaserForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.ClientSize = new System.Drawing.Size(631, 506);
         this.Controls.Add(this.mainMenuTab);
         this.Controls.Add(this.userEmailLabel);
         this.Name = "PurchaserForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Закупщик";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchaserForm_FormClosing);
         this.Load += new System.EventHandler(this.PurchaserForm_Load);
         this.mainMenuTab.ResumeLayout(false);
         this.profilePage.ResumeLayout(false);
         this.profilePage.PerformLayout();
         this.providerPage.ResumeLayout(false);
         this.providerPage.PerformLayout();
         this.providerPricesPage.ResumeLayout(false);
         this.providerPricesPage.PerformLayout();
         this.orderPage.ResumeLayout(false);
         this.orderPage.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label profileLabel;
      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.TextBox nameTextbox;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.Label userEmailLabel;
      private System.Windows.Forms.TextBox emailTextbox;
      private System.Windows.Forms.Button changeProfileButton;
      private System.Windows.Forms.TabControl mainMenuTab;
      private System.Windows.Forms.TabPage profilePage;
      private System.Windows.Forms.TabPage providerPage;
      private System.Windows.Forms.TabPage providerPricesPage;
      private System.Windows.Forms.TabPage orderPage;
      private System.Windows.Forms.Button openProviderTableButton;
      private System.Windows.Forms.Label addProviderLabel;
      private System.Windows.Forms.Button addProviderButton;
      private System.Windows.Forms.TextBox addProviderAddressTextbox;
      private System.Windows.Forms.TextBox addProviderNameTextBox;
      private System.Windows.Forms.Label addressLabel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button addPriceButton;
      private System.Windows.Forms.TextBox addPricePriceTextBox;
      private System.Windows.Forms.ComboBox addPriceIngredientComboBox;
      private System.Windows.Forms.ComboBox addPriceProviderComboBox;
      private System.Windows.Forms.Label addPricePriceLabel;
      private System.Windows.Forms.Label addPriceIngredientLabel;
      private System.Windows.Forms.Label addPriceProviderLabel;
      private System.Windows.Forms.Button analyzePriceButton;
      private System.Windows.Forms.ComboBox analyzePriceIngredientComboBox;
      private System.Windows.Forms.Label analyzePriceIngredientLabel;
      private System.Windows.Forms.Label analyzePriceLabel;
      private System.Windows.Forms.Label addPriceLabel;
      private System.Windows.Forms.Button openProviderPricesButton;
      private System.Windows.Forms.Label addOrderDateLabel;
      private System.Windows.Forms.Label addOrderWeightLabel;
      private System.Windows.Forms.Label addOrderIngredientLabel;
      private System.Windows.Forms.Label addOrderProviderLabel;
      private System.Windows.Forms.Label addOrderLabel;
      private System.Windows.Forms.ComboBox changeOrderStatusStatusComboBox;
      private System.Windows.Forms.Label changeOrderStatusStatusLabel;
      private System.Windows.Forms.Label changeOrderStatusNumberLabel;
      private System.Windows.Forms.Label changeOrderStatusLabel;
      private System.Windows.Forms.Button addOrderButton;
      private System.Windows.Forms.DateTimePicker addOrderDateTimePicker;
      private System.Windows.Forms.TextBox addOrderWeightTextBox;
      private System.Windows.Forms.ComboBox addOrderIngredientComboBox;
      private System.Windows.Forms.ComboBox addOrderProviderComboBox;
      private System.Windows.Forms.Button openIngredientOrdersTable;
      private System.Windows.Forms.Button changeOrderStatusButton;
      private System.Windows.Forms.ComboBox changeOrderStatusNumberComboBox;
   }
}