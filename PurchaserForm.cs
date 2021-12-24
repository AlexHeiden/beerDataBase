using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BeerCourseWork
{
   public partial class PurchaserForm : Form
   {
      public static bool addProvider, addPrice, analyzePrice, addOrder = false;

      public PurchaserForm(OleDbConnection cn, String email)
      {
         InitializeComponent();
         this.email = email;
         emailTextbox.Text = email.Trim();
         this.cn = cn;

         String sqlGetName = "select Name from Users where Email = \'" + email + '\'';
         OleDbCommand cmdGetRoleName = new OleDbCommand(sqlGetName, cn);
         OleDbDataReader reader = cmdGetRoleName.ExecuteReader();
         reader.Read();
         nameTextbox.Text = reader["Name"].ToString().Trim();

         String sqlGetIngredientList = "select Name from Ingredients";
         OleDbCommand cmdGetIngredientList = new OleDbCommand(sqlGetIngredientList, cn);
         reader = cmdGetIngredientList.ExecuteReader();
         while (reader.Read())
         {
            addPriceIngredientComboBox.Items.Add(reader["Name"].ToString());
            analyzePriceIngredientComboBox.Items.Add(reader["Name"].ToString());
            addOrderIngredientComboBox.Items.Add(reader["Name"].ToString());
         }

         String sqlGetNumOrderList = "select NumOrder from [Ingredient Orders]";
         OleDbCommand cmdGetNumOrderList = new OleDbCommand(sqlGetNumOrderList, cn);
         reader = cmdGetNumOrderList.ExecuteReader();
         while (reader.Read())
         {
            changeOrderStatusNumberComboBox.Items.Add(reader["NumOrder"].ToString());
         }

         String sqlGetStatusList = "select Name from [Order Statuses]";
         OleDbCommand cmdGetStatusList = new OleDbCommand(sqlGetStatusList, cn);
         reader = cmdGetStatusList.ExecuteReader();
         while (reader.Read())
         {
            changeOrderStatusStatusComboBox.Items.Add(reader["Name"].ToString());
         }         
      }

      private OleDbConnection cn;
      private String email;
      private Table providerTable, providerPricesTable, orderDetailsTable;

      private void addProviderButton_Click(object sender, EventArgs e)
      {
         if (addProviderNameTextBox.Text.Length == 0)
         {
            MessageBox.Show("Для добавления поставщика нужно заполнить имя / название организации", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         if (addProviderNameTextBox.Text.Length > 50)
         {
            MessageBox.Show("Имя / название организации может занимать не более 50 символов", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         if (addProviderAddressTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для добавления поставщика нужно заполнить его адрес", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         if (addProviderAddressTextbox.Text.Length > 50)
         {
            MessageBox.Show("Адрес может занимать не более 50 символов", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         if (isProviderInDatabase(addProviderNameTextBox.Text))
         {
            MessageBox.Show("В базе данных уже есть поставщик с таким именем", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         String sqlAddProvider = "insert into Providers (Name, Address) values (?, ?)";
         OleDbCommand cmdAddProvider = new OleDbCommand(sqlAddProvider, cn);

         cmdAddProvider.Parameters.Add("@p1", OleDbType.VarChar, 50);
         cmdAddProvider.Parameters.Add("@p2", OleDbType.VarChar, 50);

         cmdAddProvider.Parameters[0].Value = addProviderNameTextBox.Text.Trim(' ');
         cmdAddProvider.Parameters[1].Value = addProviderAddressTextbox.Text.Trim(' ');

         cmdAddProvider.ExecuteNonQuery();
         MessageBox.Show("Поставщик успешно добавлен", "Добавление поставщика", MessageBoxButtons.OK);
      }

      private void openProviderLabelButton_Click(object sender, EventArgs e)
      {
        if (!Table.providers)
         {
            providerTable = new Table(cn, "Providers");
            providerTable.Show();
         }
         else
         {
            providerTable.Activate();
         }
      }

      private void mainMenuTab_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (mainMenuTab.SelectedIndex == 2)
         {
            addPriceProviderComboBox.Items.Clear();
            String sqlGetProviderList = "select Name from Providers";
            OleDbCommand cmdGetProviderList = new OleDbCommand(sqlGetProviderList, cn);
            OleDbDataReader reader = cmdGetProviderList.ExecuteReader();
            while (reader.Read())
            {
               addPriceProviderComboBox.Items.Add(reader["Name"].ToString());
            }
         }
         else if (mainMenuTab.SelectedIndex == 3)
         {
            addOrderProviderComboBox.Items.Clear();
            String sqlGetProviderList = "select Name from Providers";
            OleDbCommand cmdGetProviderList = new OleDbCommand(sqlGetProviderList, cn);
            OleDbDataReader reader = cmdGetProviderList.ExecuteReader();
            while (reader.Read())
            {
               addOrderProviderComboBox.Items.Add(reader["Name"].ToString());
            }
         }
      }

      private void addPriceButton_Click(object sender, EventArgs e)
      {
         if (addPriceProviderComboBox.SelectedItem == null)
         {
             MessageBox.Show("Нужно указать поставщика, чтобы добавить цену", "Ошибка добавления", MessageBoxButtons.OK);
             return;
         }

         if (addPriceIngredientComboBox.SelectedItem == null)
         {
            MessageBox.Show("Нужно указать ингредиент, чтобы добавить цену", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         if (addPricePriceTextBox.Text.Length == 0)
         {
            MessageBox.Show("Нужно указать цену ингредиента, чтобы добавить цену", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }

         float priceKilo;
         try
         {
            priceKilo = float.Parse(addPricePriceTextBox.Text);
            if (priceKilo <= 0)
            {
               throw new Exception();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Цена должна представлять из себя положительное действительное число", "Ошибка добавления", MessageBoxButtons.OK);
            return;
         }         

         int numProv;
         String sqlGetNumProv = "select NumProv from Providers where Name = \'" + addPriceProviderComboBox.Text + '\'';
         OleDbCommand cmdGetNumProv = new OleDbCommand(sqlGetNumProv, cn);
         OleDbDataReader reader = cmdGetNumProv.ExecuteReader();
         reader.Read();
         numProv = int.Parse(reader["NumProv"].ToString());

         int numIng;
         String sqlGetNumIng = "select NumIng from Ingredients where Name = \'" + addPriceIngredientComboBox.Text + '\'';
         OleDbCommand cmdGetNumIng = new OleDbCommand(sqlGetNumIng, cn);
         reader = cmdGetNumIng.ExecuteReader();
         reader.Read();
         numIng = int.Parse(reader["NumIng"].ToString());

         string sqlCheckIfExists = "select NumProv, NumIng from [Provider Prices] where NumProv = " + numProv
               + " and NumIng = " + numIng;
         OleDbCommand cmdCheckIfExists = new OleDbCommand(sqlCheckIfExists, cn);
         reader = cmdCheckIfExists.ExecuteReader();

         if (reader.HasRows)
         {
            String sqlUpdatePrice = "update [Provider Prices] set PriceKilo = " + priceKilo
                  + " where NumProv = " + numProv + " and NumIng = " + numIng;
            OleDbCommand cmdUpdatePrice = new OleDbCommand(sqlUpdatePrice, cn);
            cmdUpdatePrice.ExecuteNonQuery();
         }
         else
         {
            String sqlAddPrice = "insert into [Provider Prices] (NumProv, NumIng, PriceKilo) values (?, ?, ?)";
            OleDbCommand cmdAddPrice = new OleDbCommand(sqlAddPrice, cn);

            cmdAddPrice.Parameters.Add("@p1", OleDbType.Integer);
            cmdAddPrice.Parameters.Add("@p2", OleDbType.Integer);
            cmdAddPrice.Parameters.Add("@p3", OleDbType.Double);

            cmdAddPrice.Parameters[0].Value = numProv;
            cmdAddPrice.Parameters[1].Value = numIng;
            cmdAddPrice.Parameters[2].Value = priceKilo;

            cmdAddPrice.ExecuteNonQuery();
         }

         MessageBox.Show("Цена успешно добавлена/изменена", "Добавление цены", MessageBoxButtons.OK);
      }

      private void analyzePriceButton_Click(object sender, EventArgs e)
      {
        if (analyzePriceIngredientComboBox.SelectedItem == null)
        {
            MessageBox.Show("Для сведения цены нужно указать ингредиент", "Сведение цены", MessageBoxButtons.OK);
            return;
        }

         new Table(cn, "PriceAnalyze", analyzePriceIngredientComboBox.Text).Show();
      }

      private void addOrderButton_Click(object sender, EventArgs e)
      {
         if (addOrderProviderComboBox.SelectedItem == null)
         {
             MessageBox.Show("Чтобы создать заказ, нужно указать поставщика", "Ошибка создания заказа", MessageBoxButtons.OK);
             return;
         }

         if (addOrderIngredientComboBox.SelectedItem == null)
         {
            MessageBox.Show("Чтобы создать заказ, нужно указать ингредиент", "Ошибка создания заказа", MessageBoxButtons.OK);
            return;
         }

         if (addOrderWeightTextBox.Text.Length == 0)
         {
            MessageBox.Show("Чтобы создать заказ, нужно указать вес", "Ошибка создания заказа", MessageBoxButtons.OK);
            return;
         }

         String sqlCheckPriceExistence = "select [Provider Prices].NumProv, [Provider Prices].NumIng from [Provider Prices]"
               + " inner join Providers on Providers.NumProv = [Provider Prices].NumProv"
               + " inner join Ingredients on Ingredients.NumIng = [Provider Prices].NumIng"
               + " where Providers.Name = \'" + addOrderProviderComboBox.Text
               + "\' and Ingredients.Name = \'" + addOrderIngredientComboBox.Text + '\'';
         OleDbCommand cmdCheckPriceExistence = new OleDbCommand(sqlCheckPriceExistence, cn);
         OleDbDataReader reader = cmdCheckPriceExistence.ExecuteReader();
         if (!reader.HasRows)
         {
            MessageBox.Show("Чтобы добавить заказ, нужно добавить цену на данный ингредиент у выбранного поставщика", "Ошибка создания заказа", MessageBoxButtons.OK);
            return;
         }

         float weight;
         try
         {
            weight = float.Parse(addOrderWeightTextBox.Text);
            if (weight <= 0)
            {
               throw new Exception();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Вес должен представлять из себя положительное действительное число", "Ошибка создания заказа", MessageBoxButtons.OK);
            return;
         }

         String date = addOrderDateTimePicker.Value.ToString("dd/MM/yyyy");
         String sqlAddOrder = "exec dbo.CreateIngredientOrder \'" + addOrderProviderComboBox.Text.Trim() + "\', \'"
               + addOrderIngredientComboBox.Text.Trim() + "\', " + weight + ", \'" + date + '\'';
         OleDbCommand cmdAddOrder = new OleDbCommand(sqlAddOrder, cn);
         cmdAddOrder.ExecuteNonQuery();

         changeOrderStatusNumberComboBox.Items.Clear();
         String sqlGetNumOrderList = "select NumOrder from [Ingredient Orders]";
         OleDbCommand cmdGetNumOrderList = new OleDbCommand(sqlGetNumOrderList, cn);
         reader = cmdGetNumOrderList.ExecuteReader();
         while (reader.Read())
         {
            changeOrderStatusNumberComboBox.Items.Add(reader["NumOrder"].ToString());
         }

         MessageBox.Show("Заказ успешно создан", "Создание заказа", MessageBoxButtons.OK);
      }

      private void changeOrderStatusButton_Click(object sender, EventArgs e)
      {
         if (changeOrderStatusNumberComboBox.SelectedItem == null)
         {
             MessageBox.Show("Чтобы изменить статус заказа, нужно указать его номер", "Ошибка изменения статуса", MessageBoxButtons.OK);
             return;
         }

         if (changeOrderStatusStatusComboBox.SelectedItem == null)
         {
            MessageBox.Show("Чтобы изменить статус заказа, нужно указать новый статус", "Ошибка изменения статуса", MessageBoxButtons.OK);
            return;
         }

         String sqlChangeOrderStatus = "update [Ingredient Orders] set NumStat = "
                     + "(select NumStat from [Order Statuses] where Name = \'" + changeOrderStatusStatusComboBox.Text
                     + "\')"
               + " where NumOrder = " + int.Parse(changeOrderStatusNumberComboBox.Text);
         OleDbCommand cmdChangeOrderStatus = new OleDbCommand(sqlChangeOrderStatus, cn);
         cmdChangeOrderStatus.ExecuteNonQuery();

         MessageBox.Show("Статус заказа успешно изменен", "Изменение статуса", MessageBoxButtons.OK);
      }

      private void openIngredientOrdersTable_Click(object sender, EventArgs e)
      {
         if (!Table.orderDetails)
         {
            orderDetailsTable = new Table(cn, "OrderDetails");
            orderDetailsTable.Show();
         }
         else
         {
            orderDetailsTable.Activate();
         }
      }

      private void PurchaserForm_Load(object sender, EventArgs e)
      {

      }

      private void openProviderPricesButton_Click(object sender, EventArgs e)
      {
         if (!Table.providerPrices)
         {
            providerPricesTable = new Table(cn, "[Provider Prices]");
            providerPricesTable.Show();
         }
         else
         {
            providerPricesTable.Activate();
         }
      }

      private void PurchaserForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         cn.Close();
         Application.Exit();
      }      

      private void changeProfileButton_Click(object sender, EventArgs e)
      {
         if (nameTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для обновления данных нужно заполнить имя/название организации", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         if (nameTextbox.Text.Length > 50)
         {
            MessageBox.Show("Имя/название организации должно занимать не более 50 символов", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         if (emailTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для обновления данных нужно заполнить email", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         if (emailTextbox.Text.Length > 50)
         {
            MessageBox.Show("Email может занимать не более 50 символов", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         if (Registration.isEmailInDatabase(emailTextbox.Text, cn))
         {
            MessageBox.Show("Нельзя поменять email на тот, который уже есть в базе", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         DialogResult dialog = MessageBox.Show("Хотите изменить данные?", "Мой профиль", MessageBoxButtons.YesNo);
         if (dialog == DialogResult.No)
         {
            return;
         }

         String sqlGetName = "update Users set Name = \'" + nameTextbox.Text + "\', Email = \'" + emailTextbox.Text + "\'"
               + " where Email = \'" + email + "\'";
         OleDbCommand cmdGetRoleName = new OleDbCommand(sqlGetName, cn);
         cmdGetRoleName.ExecuteNonQuery();
         email = emailTextbox.Text;

         MessageBox.Show("Данные успешно обновлены", "Мой профиль", MessageBoxButtons.OK);
         return;
      }

      private bool isProviderInDatabase(String userProvider)
      {
         String sqlGetEmails = "select Name from Providers";
         OleDbCommand cmdGetEmails = new OleDbCommand(sqlGetEmails, cn);
         OleDbDataReader reader = cmdGetEmails.ExecuteReader();
         userProvider = userProvider.Trim(' ');
         while (reader.Read())
         {
            if (userProvider.Equals(reader["Name"].ToString().Trim(' ')))
            {
               return true;
            }
         }

         return false;
      }
   }
}
