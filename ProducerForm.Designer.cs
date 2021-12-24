
namespace BeerCourseWork
{
   partial class ProducerForm
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
         this.mainMenuTab = new System.Windows.Forms.TabControl();
         this.profilePage = new System.Windows.Forms.TabPage();
         this.nameTextbox = new System.Windows.Forms.TextBox();
         this.emailTextbox = new System.Windows.Forms.TextBox();
         this.profileLabel = new System.Windows.Forms.Label();
         this.emailLabel = new System.Windows.Forms.Label();
         this.changeProfileButton = new System.Windows.Forms.Button();
         this.nameLabel = new System.Windows.Forms.Label();
         this.ingredientWarehousePage = new System.Windows.Forms.TabPage();
         this.howMuchButton = new System.Windows.Forms.Button();
         this.howMuchAmountTextBox = new System.Windows.Forms.TextBox();
         this.howMuchProdComboBox = new System.Windows.Forms.ComboBox();
         this.howMuchAmountLabel = new System.Windows.Forms.Label();
         this.howMuchProdLabel = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.changeIngWarehouseComboBox = new System.Windows.Forms.ComboBox();
         this.openIngWarehouseTableButton = new System.Windows.Forms.Button();
         this.addProviderLabel = new System.Windows.Forms.Label();
         this.addProviderButton = new System.Windows.Forms.Button();
         this.changeIngWarehouseAmountTextBox = new System.Windows.Forms.TextBox();
         this.changeIngWarehouseAmountLabel = new System.Windows.Forms.Label();
         this.changeIngWarehouseIngLabel = new System.Windows.Forms.Label();
         this.productWarehousePage = new System.Windows.Forms.TabPage();
         this.openProdWarTable = new System.Windows.Forms.Button();
         this.changeProdWarProdComboBox = new System.Windows.Forms.ComboBox();
         this.changeProdWarLabel = new System.Windows.Forms.Label();
         this.changeProdWarButton = new System.Windows.Forms.Button();
         this.changeProdWarAmountTextBox = new System.Windows.Forms.TextBox();
         this.changeProdWarAmountLabel = new System.Windows.Forms.Label();
         this.changeProdWarProdLabel = new System.Windows.Forms.Label();
         this.recipesPage = new System.Windows.Forms.TabPage();
         this.deliveriesPage = new System.Windows.Forms.TabPage();
         this.changeOrderOrderComboBox = new System.Windows.Forms.ComboBox();
         this.openDeliveriesButton = new System.Windows.Forms.Button();
         this.changeOrderButton = new System.Windows.Forms.Button();
         this.changeOrderStatusComboBox = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.recipeProdComboBox = new System.Windows.Forms.ComboBox();
         this.showRecipeButton = new System.Windows.Forms.Button();
         this.openRecipesButton = new System.Windows.Forms.Button();
         this.mainMenuTab.SuspendLayout();
         this.profilePage.SuspendLayout();
         this.ingredientWarehousePage.SuspendLayout();
         this.productWarehousePage.SuspendLayout();
         this.recipesPage.SuspendLayout();
         this.deliveriesPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // mainMenuTab
         // 
         this.mainMenuTab.Controls.Add(this.profilePage);
         this.mainMenuTab.Controls.Add(this.ingredientWarehousePage);
         this.mainMenuTab.Controls.Add(this.productWarehousePage);
         this.mainMenuTab.Controls.Add(this.recipesPage);
         this.mainMenuTab.Controls.Add(this.deliveriesPage);
         this.mainMenuTab.Location = new System.Drawing.Point(12, 12);
         this.mainMenuTab.Name = "mainMenuTab";
         this.mainMenuTab.SelectedIndex = 0;
         this.mainMenuTab.Size = new System.Drawing.Size(620, 457);
         this.mainMenuTab.TabIndex = 9;
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
         this.profilePage.Size = new System.Drawing.Size(612, 428);
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
         // ingredientWarehousePage
         // 
         this.ingredientWarehousePage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.ingredientWarehousePage.Controls.Add(this.howMuchButton);
         this.ingredientWarehousePage.Controls.Add(this.howMuchAmountTextBox);
         this.ingredientWarehousePage.Controls.Add(this.howMuchProdComboBox);
         this.ingredientWarehousePage.Controls.Add(this.howMuchAmountLabel);
         this.ingredientWarehousePage.Controls.Add(this.howMuchProdLabel);
         this.ingredientWarehousePage.Controls.Add(this.label1);
         this.ingredientWarehousePage.Controls.Add(this.changeIngWarehouseComboBox);
         this.ingredientWarehousePage.Controls.Add(this.openIngWarehouseTableButton);
         this.ingredientWarehousePage.Controls.Add(this.addProviderLabel);
         this.ingredientWarehousePage.Controls.Add(this.addProviderButton);
         this.ingredientWarehousePage.Controls.Add(this.changeIngWarehouseAmountTextBox);
         this.ingredientWarehousePage.Controls.Add(this.changeIngWarehouseAmountLabel);
         this.ingredientWarehousePage.Controls.Add(this.changeIngWarehouseIngLabel);
         this.ingredientWarehousePage.Location = new System.Drawing.Point(4, 25);
         this.ingredientWarehousePage.Name = "ingredientWarehousePage";
         this.ingredientWarehousePage.Size = new System.Drawing.Size(612, 428);
         this.ingredientWarehousePage.TabIndex = 2;
         this.ingredientWarehousePage.Text = "Склад ингредиентов";
         this.ingredientWarehousePage.UseVisualStyleBackColor = true;
         // 
         // howMuchButton
         // 
         this.howMuchButton.Location = new System.Drawing.Point(226, 318);
         this.howMuchButton.Name = "howMuchButton";
         this.howMuchButton.Size = new System.Drawing.Size(98, 33);
         this.howMuchButton.TabIndex = 18;
         this.howMuchButton.Text = "Рассчитать";
         this.howMuchButton.UseVisualStyleBackColor = true;
         this.howMuchButton.Click += new System.EventHandler(this.howMuchButton_Click);
         // 
         // howMuchAmountTextBox
         // 
         this.howMuchAmountTextBox.Location = new System.Drawing.Point(335, 274);
         this.howMuchAmountTextBox.Name = "howMuchAmountTextBox";
         this.howMuchAmountTextBox.Size = new System.Drawing.Size(189, 22);
         this.howMuchAmountTextBox.TabIndex = 17;
         // 
         // howMuchProdComboBox
         // 
         this.howMuchProdComboBox.FormattingEnabled = true;
         this.howMuchProdComboBox.Location = new System.Drawing.Point(335, 239);
         this.howMuchProdComboBox.Name = "howMuchProdComboBox";
         this.howMuchProdComboBox.Size = new System.Drawing.Size(189, 24);
         this.howMuchProdComboBox.TabIndex = 16;
         // 
         // howMuchAmountLabel
         // 
         this.howMuchAmountLabel.AutoSize = true;
         this.howMuchAmountLabel.Location = new System.Drawing.Point(79, 280);
         this.howMuchAmountLabel.Name = "howMuchAmountLabel";
         this.howMuchAmountLabel.Size = new System.Drawing.Size(108, 17);
         this.howMuchAmountLabel.TabIndex = 15;
         this.howMuchAmountLabel.Text = "Количество шт";
         // 
         // howMuchProdLabel
         // 
         this.howMuchProdLabel.AutoSize = true;
         this.howMuchProdLabel.Location = new System.Drawing.Point(79, 239);
         this.howMuchProdLabel.Name = "howMuchProdLabel";
         this.howMuchProdLabel.Size = new System.Drawing.Size(63, 17);
         this.howMuchProdLabel.TabIndex = 14;
         this.howMuchProdLabel.Text = "Продукт";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(119, 196);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(344, 25);
         this.label1.TabIndex = 13;
         this.label1.Text = "Сколько продуктов можно создать";
         // 
         // changeIngWarehouseComboBox
         // 
         this.changeIngWarehouseComboBox.FormattingEnabled = true;
         this.changeIngWarehouseComboBox.Location = new System.Drawing.Point(335, 63);
         this.changeIngWarehouseComboBox.Name = "changeIngWarehouseComboBox";
         this.changeIngWarehouseComboBox.Size = new System.Drawing.Size(189, 24);
         this.changeIngWarehouseComboBox.TabIndex = 12;
         // 
         // openIngWarehouseTableButton
         // 
         this.openIngWarehouseTableButton.Location = new System.Drawing.Point(187, 367);
         this.openIngWarehouseTableButton.Name = "openIngWarehouseTableButton";
         this.openIngWarehouseTableButton.Size = new System.Drawing.Size(177, 40);
         this.openIngWarehouseTableButton.TabIndex = 11;
         this.openIngWarehouseTableButton.TabStop = false;
         this.openIngWarehouseTableButton.Text = "Открыть таблицу";
         this.openIngWarehouseTableButton.UseVisualStyleBackColor = true;
         this.openIngWarehouseTableButton.Click += new System.EventHandler(this.openIngWarehouseTableButton_Click);
         // 
         // addProviderLabel
         // 
         this.addProviderLabel.AutoSize = true;
         this.addProviderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.addProviderLabel.Location = new System.Drawing.Point(164, 18);
         this.addProviderLabel.Name = "addProviderLabel";
         this.addProviderLabel.Size = new System.Drawing.Size(252, 25);
         this.addProviderLabel.TabIndex = 10;
         this.addProviderLabel.Text = "Изменить данные склада";
         // 
         // addProviderButton
         // 
         this.addProviderButton.Location = new System.Drawing.Point(226, 147);
         this.addProviderButton.Name = "addProviderButton";
         this.addProviderButton.Size = new System.Drawing.Size(98, 31);
         this.addProviderButton.TabIndex = 9;
         this.addProviderButton.Text = "Изменить";
         this.addProviderButton.UseVisualStyleBackColor = true;
         this.addProviderButton.Click += new System.EventHandler(this.addProviderButton_Click);
         // 
         // changeIngWarehouseAmountTextBox
         // 
         this.changeIngWarehouseAmountTextBox.Location = new System.Drawing.Point(335, 107);
         this.changeIngWarehouseAmountTextBox.Name = "changeIngWarehouseAmountTextBox";
         this.changeIngWarehouseAmountTextBox.Size = new System.Drawing.Size(189, 22);
         this.changeIngWarehouseAmountTextBox.TabIndex = 8;
         // 
         // changeIngWarehouseAmountLabel
         // 
         this.changeIngWarehouseAmountLabel.AutoSize = true;
         this.changeIngWarehouseAmountLabel.Location = new System.Drawing.Point(79, 112);
         this.changeIngWarehouseAmountLabel.Name = "changeIngWarehouseAmountLabel";
         this.changeIngWarehouseAmountLabel.Size = new System.Drawing.Size(123, 17);
         this.changeIngWarehouseAmountLabel.TabIndex = 6;
         this.changeIngWarehouseAmountLabel.Text = "Количество (в кг)";
         // 
         // changeIngWarehouseIngLabel
         // 
         this.changeIngWarehouseIngLabel.AutoSize = true;
         this.changeIngWarehouseIngLabel.Location = new System.Drawing.Point(79, 72);
         this.changeIngWarehouseIngLabel.Name = "changeIngWarehouseIngLabel";
         this.changeIngWarehouseIngLabel.Size = new System.Drawing.Size(86, 17);
         this.changeIngWarehouseIngLabel.TabIndex = 5;
         this.changeIngWarehouseIngLabel.Text = "Ингредиент";
         // 
         // productWarehousePage
         // 
         this.productWarehousePage.Controls.Add(this.openProdWarTable);
         this.productWarehousePage.Controls.Add(this.changeProdWarProdComboBox);
         this.productWarehousePage.Controls.Add(this.changeProdWarLabel);
         this.productWarehousePage.Controls.Add(this.changeProdWarButton);
         this.productWarehousePage.Controls.Add(this.changeProdWarAmountTextBox);
         this.productWarehousePage.Controls.Add(this.changeProdWarAmountLabel);
         this.productWarehousePage.Controls.Add(this.changeProdWarProdLabel);
         this.productWarehousePage.Location = new System.Drawing.Point(4, 25);
         this.productWarehousePage.Name = "productWarehousePage";
         this.productWarehousePage.Padding = new System.Windows.Forms.Padding(3);
         this.productWarehousePage.Size = new System.Drawing.Size(612, 428);
         this.productWarehousePage.TabIndex = 1;
         this.productWarehousePage.Text = "Склад продуктов";
         this.productWarehousePage.UseVisualStyleBackColor = true;
         this.productWarehousePage.Click += new System.EventHandler(this.productWarehousePage_Click);
         // 
         // openProdWarTable
         // 
         this.openProdWarTable.Location = new System.Drawing.Point(205, 294);
         this.openProdWarTable.Name = "openProdWarTable";
         this.openProdWarTable.Size = new System.Drawing.Size(177, 40);
         this.openProdWarTable.TabIndex = 20;
         this.openProdWarTable.TabStop = false;
         this.openProdWarTable.Text = "Открыть таблицу";
         this.openProdWarTable.UseVisualStyleBackColor = true;
         this.openProdWarTable.Click += new System.EventHandler(this.openProdWarTable_Click);
         // 
         // changeProdWarProdComboBox
         // 
         this.changeProdWarProdComboBox.FormattingEnabled = true;
         this.changeProdWarProdComboBox.Location = new System.Drawing.Point(340, 108);
         this.changeProdWarProdComboBox.Name = "changeProdWarProdComboBox";
         this.changeProdWarProdComboBox.Size = new System.Drawing.Size(189, 24);
         this.changeProdWarProdComboBox.TabIndex = 19;
         // 
         // changeProdWarLabel
         // 
         this.changeProdWarLabel.AutoSize = true;
         this.changeProdWarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.changeProdWarLabel.Location = new System.Drawing.Point(144, 45);
         this.changeProdWarLabel.Name = "changeProdWarLabel";
         this.changeProdWarLabel.Size = new System.Drawing.Size(336, 31);
         this.changeProdWarLabel.TabIndex = 18;
         this.changeProdWarLabel.Text = "Изменить данные склада";
         // 
         // changeProdWarButton
         // 
         this.changeProdWarButton.Location = new System.Drawing.Point(244, 222);
         this.changeProdWarButton.Name = "changeProdWarButton";
         this.changeProdWarButton.Size = new System.Drawing.Size(98, 31);
         this.changeProdWarButton.TabIndex = 17;
         this.changeProdWarButton.Text = "Изменить";
         this.changeProdWarButton.UseVisualStyleBackColor = true;
         this.changeProdWarButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // changeProdWarAmountTextBox
         // 
         this.changeProdWarAmountTextBox.Location = new System.Drawing.Point(340, 167);
         this.changeProdWarAmountTextBox.Name = "changeProdWarAmountTextBox";
         this.changeProdWarAmountTextBox.Size = new System.Drawing.Size(189, 22);
         this.changeProdWarAmountTextBox.TabIndex = 16;
         // 
         // changeProdWarAmountLabel
         // 
         this.changeProdWarAmountLabel.AutoSize = true;
         this.changeProdWarAmountLabel.Location = new System.Drawing.Point(107, 172);
         this.changeProdWarAmountLabel.Name = "changeProdWarAmountLabel";
         this.changeProdWarAmountLabel.Size = new System.Drawing.Size(86, 17);
         this.changeProdWarAmountLabel.TabIndex = 15;
         this.changeProdWarAmountLabel.Text = "Количество";
         // 
         // changeProdWarProdLabel
         // 
         this.changeProdWarProdLabel.AutoSize = true;
         this.changeProdWarProdLabel.Location = new System.Drawing.Point(107, 115);
         this.changeProdWarProdLabel.Name = "changeProdWarProdLabel";
         this.changeProdWarProdLabel.Size = new System.Drawing.Size(63, 17);
         this.changeProdWarProdLabel.TabIndex = 14;
         this.changeProdWarProdLabel.Text = "Продукт";
         // 
         // recipesPage
         // 
         this.recipesPage.Controls.Add(this.openRecipesButton);
         this.recipesPage.Controls.Add(this.showRecipeButton);
         this.recipesPage.Controls.Add(this.recipeProdComboBox);
         this.recipesPage.Controls.Add(this.label6);
         this.recipesPage.Controls.Add(this.label5);
         this.recipesPage.Location = new System.Drawing.Point(4, 25);
         this.recipesPage.Name = "recipesPage";
         this.recipesPage.Size = new System.Drawing.Size(612, 428);
         this.recipesPage.TabIndex = 3;
         this.recipesPage.Text = "Рецепты";
         this.recipesPage.UseVisualStyleBackColor = true;
         // 
         // deliveriesPage
         // 
         this.deliveriesPage.Controls.Add(this.changeOrderOrderComboBox);
         this.deliveriesPage.Controls.Add(this.openDeliveriesButton);
         this.deliveriesPage.Controls.Add(this.changeOrderButton);
         this.deliveriesPage.Controls.Add(this.changeOrderStatusComboBox);
         this.deliveriesPage.Controls.Add(this.label2);
         this.deliveriesPage.Controls.Add(this.label3);
         this.deliveriesPage.Controls.Add(this.label4);
         this.deliveriesPage.Location = new System.Drawing.Point(4, 25);
         this.deliveriesPage.Name = "deliveriesPage";
         this.deliveriesPage.Size = new System.Drawing.Size(612, 428);
         this.deliveriesPage.TabIndex = 4;
         this.deliveriesPage.Text = "Заказы клиентов";
         this.deliveriesPage.UseVisualStyleBackColor = true;
         // 
         // changeOrderOrderComboBox
         // 
         this.changeOrderOrderComboBox.FormattingEnabled = true;
         this.changeOrderOrderComboBox.Location = new System.Drawing.Point(360, 127);
         this.changeOrderOrderComboBox.Name = "changeOrderOrderComboBox";
         this.changeOrderOrderComboBox.Size = new System.Drawing.Size(136, 24);
         this.changeOrderOrderComboBox.TabIndex = 28;
         // 
         // openDeliveriesButton
         // 
         this.openDeliveriesButton.Location = new System.Drawing.Point(217, 310);
         this.openDeliveriesButton.Name = "openDeliveriesButton";
         this.openDeliveriesButton.Size = new System.Drawing.Size(177, 40);
         this.openDeliveriesButton.TabIndex = 27;
         this.openDeliveriesButton.Text = "Открыть таблицу";
         this.openDeliveriesButton.UseVisualStyleBackColor = true;
         this.openDeliveriesButton.Click += new System.EventHandler(this.button1_Click_1);
         // 
         // changeOrderButton
         // 
         this.changeOrderButton.Location = new System.Drawing.Point(240, 239);
         this.changeOrderButton.Name = "changeOrderButton";
         this.changeOrderButton.Size = new System.Drawing.Size(133, 33);
         this.changeOrderButton.TabIndex = 26;
         this.changeOrderButton.Text = "Изменить";
         this.changeOrderButton.UseVisualStyleBackColor = true;
         this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
         // 
         // changeOrderStatusComboBox
         // 
         this.changeOrderStatusComboBox.FormattingEnabled = true;
         this.changeOrderStatusComboBox.Location = new System.Drawing.Point(360, 182);
         this.changeOrderStatusComboBox.Name = "changeOrderStatusComboBox";
         this.changeOrderStatusComboBox.Size = new System.Drawing.Size(136, 24);
         this.changeOrderStatusComboBox.TabIndex = 25;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(116, 189);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(53, 17);
         this.label2.TabIndex = 24;
         this.label2.Text = "Статус";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(116, 134);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 17);
         this.label3.TabIndex = 23;
         this.label3.Text = "Номер заказа";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.Location = new System.Drawing.Point(148, 54);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(320, 31);
         this.label4.TabIndex = 22;
         this.label4.Text = "Изменить статус заказа";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label5.Location = new System.Drawing.Point(189, 54);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(228, 31);
         this.label5.TabIndex = 0;
         this.label5.Text = "Показать рецепт";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(152, 135);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(63, 17);
         this.label6.TabIndex = 1;
         this.label6.Text = "Продукт";
         // 
         // recipeProdComboBox
         // 
         this.recipeProdComboBox.FormattingEnabled = true;
         this.recipeProdComboBox.Location = new System.Drawing.Point(358, 128);
         this.recipeProdComboBox.Name = "recipeProdComboBox";
         this.recipeProdComboBox.Size = new System.Drawing.Size(150, 24);
         this.recipeProdComboBox.TabIndex = 2;
         // 
         // showRecipeButton
         // 
         this.showRecipeButton.Location = new System.Drawing.Point(247, 197);
         this.showRecipeButton.Name = "showRecipeButton";
         this.showRecipeButton.Size = new System.Drawing.Size(93, 32);
         this.showRecipeButton.TabIndex = 3;
         this.showRecipeButton.Text = "Показать";
         this.showRecipeButton.UseVisualStyleBackColor = true;
         this.showRecipeButton.Click += new System.EventHandler(this.showRecipeButton_Click);
         // 
         // openRecipesButton
         // 
         this.openRecipesButton.Location = new System.Drawing.Point(207, 280);
         this.openRecipesButton.Name = "openRecipesButton";
         this.openRecipesButton.Size = new System.Drawing.Size(177, 40);
         this.openRecipesButton.TabIndex = 21;
         this.openRecipesButton.TabStop = false;
         this.openRecipesButton.Text = "Открыть таблицу";
         this.openRecipesButton.UseVisualStyleBackColor = true;
         this.openRecipesButton.Click += new System.EventHandler(this.openRecipesButton_Click);
         // 
         // ProducerForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(644, 481);
         this.Controls.Add(this.mainMenuTab);
         this.Name = "ProducerForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Производитель";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProducerForm_FormClosing);
         this.Load += new System.EventHandler(this.ProducerForm_Load);
         this.mainMenuTab.ResumeLayout(false);
         this.profilePage.ResumeLayout(false);
         this.profilePage.PerformLayout();
         this.ingredientWarehousePage.ResumeLayout(false);
         this.ingredientWarehousePage.PerformLayout();
         this.productWarehousePage.ResumeLayout(false);
         this.productWarehousePage.PerformLayout();
         this.recipesPage.ResumeLayout(false);
         this.recipesPage.PerformLayout();
         this.deliveriesPage.ResumeLayout(false);
         this.deliveriesPage.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl mainMenuTab;
      private System.Windows.Forms.TabPage profilePage;
      private System.Windows.Forms.TextBox nameTextbox;
      private System.Windows.Forms.TextBox emailTextbox;
      private System.Windows.Forms.Label profileLabel;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.Button changeProfileButton;
      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.TabPage ingredientWarehousePage;
      private System.Windows.Forms.Button openIngWarehouseTableButton;
      private System.Windows.Forms.Label addProviderLabel;
      private System.Windows.Forms.Button addProviderButton;
      private System.Windows.Forms.TextBox changeIngWarehouseAmountTextBox;
      private System.Windows.Forms.Label changeIngWarehouseAmountLabel;
      private System.Windows.Forms.Label changeIngWarehouseIngLabel;
      private System.Windows.Forms.TabPage productWarehousePage;
      private System.Windows.Forms.TabPage recipesPage;
      private System.Windows.Forms.TabPage deliveriesPage;
      private System.Windows.Forms.Button howMuchButton;
      private System.Windows.Forms.TextBox howMuchAmountTextBox;
      private System.Windows.Forms.ComboBox howMuchProdComboBox;
      private System.Windows.Forms.Label howMuchAmountLabel;
      private System.Windows.Forms.Label howMuchProdLabel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox changeIngWarehouseComboBox;
      private System.Windows.Forms.Button openProdWarTable;
      private System.Windows.Forms.ComboBox changeProdWarProdComboBox;
      private System.Windows.Forms.Label changeProdWarLabel;
      private System.Windows.Forms.Button changeProdWarButton;
      private System.Windows.Forms.TextBox changeProdWarAmountTextBox;
      private System.Windows.Forms.Label changeProdWarAmountLabel;
      private System.Windows.Forms.Label changeProdWarProdLabel;
      private System.Windows.Forms.Button openRecipesButton;
      private System.Windows.Forms.Button showRecipeButton;
      private System.Windows.Forms.ComboBox recipeProdComboBox;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox changeOrderOrderComboBox;
      private System.Windows.Forms.Button openDeliveriesButton;
      private System.Windows.Forms.Button changeOrderButton;
      private System.Windows.Forms.ComboBox changeOrderStatusComboBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}