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
   public partial class ProducerForm : Form
   {
      public ProducerForm(OleDbConnection cn, String email)
      {
         InitializeComponent();
         this.cn = cn;
         this.email = email;
         emailTextbox.Text = email.Trim();

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
            changeIngWarehouseComboBox.Items.Add(reader["Name"].ToString());
         }

         String sqlGetProductList = "select Name from Products";
         OleDbCommand cmdGetProductList = new OleDbCommand(sqlGetProductList, cn);
         reader = cmdGetProductList.ExecuteReader();
         while (reader.Read())
         {
            howMuchProdComboBox.Items.Add(reader["Name"].ToString());
            changeProdWarProdComboBox.Items.Add(reader["Name"].ToString());
            recipeProdComboBox.Items.Add(reader["Name"].ToString());
         }

         String sqlGetDeliveriesList = "select NumDel from Deliveries";
         OleDbCommand cmdGetDeliveriesList = new OleDbCommand(sqlGetDeliveriesList, cn);
         reader = cmdGetDeliveriesList.ExecuteReader();
         while (reader.Read())
         {
            changeOrderOrderComboBox.Items.Add(reader["NumDel"].ToString());
         }

         String sqlGetStatusList = "select Name from [Order Statuses]";
         OleDbCommand cmdGetStatusList = new OleDbCommand(sqlGetStatusList, cn);
         reader = cmdGetStatusList.ExecuteReader();
         while (reader.Read())
         {
            changeOrderStatusComboBox.Items.Add(reader["Name"].ToString());
         }
      }

      private OleDbConnection cn;
      private String email;
      private Table ingWarehouseTable, prodWarehouseTable, recipesTable, clientOrdersTable;

      private void ProducerForm_Load(object sender, EventArgs e)
      {

      }

      private void addProviderButton_Click(object sender, EventArgs e)
      {
         if (changeIngWarehouseComboBox.SelectedItem == null)
         {
             MessageBox.Show("Для изменения данных склада нужно заполнить ингредиент", "Ошибка обновления данных", MessageBoxButtons.OK);
             return;
         }

         if (changeIngWarehouseAmountTextBox.Text.Length == 0)
         {
            MessageBox.Show("Для изменения данных склада нужно заполнить количество ингредиента", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         float weight;
         try
         {
            weight = float.Parse(changeIngWarehouseAmountTextBox.Text);
            if (weight <= 0)
            {
               throw new Exception();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Масса должна представлять из себя положительное действительное число", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         int numIng;
         String sqlGetNumIng = "select NumIng from Ingredients where Name = \'" + changeIngWarehouseComboBox.Text + "\'";
         OleDbDataReader reader = new OleDbCommand(sqlGetNumIng, cn).ExecuteReader();
         reader.Read();
         numIng = int.Parse(reader["NumIng"].ToString());

         String sqlCheckExistence = "select Name, Weight from [Ingredient Warehouse]"
               + " inner join Ingredients on Ingredients.NumIng = [Ingredient Warehouse].NumIng"
               + " where Name = \'" + changeIngWarehouseComboBox.Text + '\'';
         OleDbCommand cmdCheckExistence = new OleDbCommand(sqlCheckExistence, cn);
         reader = cmdCheckExistence.ExecuteReader();
         if (reader.HasRows)
         {
            String sqlUpdateIngWarehouse = "update [Ingredient Warehouse] set Weight = " + changeIngWarehouseAmountTextBox.Text.Replace(",", ".")
                  + " where NumIng = " + numIng;
            OleDbCommand cmdUpdateIngWarehouse = new OleDbCommand(sqlUpdateIngWarehouse, cn);
            cmdUpdateIngWarehouse.ExecuteNonQuery();
         }
         else
         {
            String sqlAddIngWarehouse = "insert into [Ingredient Warehouse] (NumIng, Weight) values (?, ?)";
            OleDbCommand cmdAddIngWarehouse = new OleDbCommand(sqlAddIngWarehouse, cn);
            
            cmdAddIngWarehouse.Parameters.Add("@p1", OleDbType.Integer);
            cmdAddIngWarehouse.Parameters.Add("@p2", OleDbType.Double);

            cmdAddIngWarehouse.Parameters[0].Value = numIng;
            cmdAddIngWarehouse.Parameters[1].Value = weight;

            cmdAddIngWarehouse.ExecuteNonQuery();
         }

         MessageBox.Show("Данные склада успешно обновлены", "Обновление данных", MessageBoxButtons.OK);
      }

      private void howMuchButton_Click(object sender, EventArgs e)
      {
         if (howMuchProdComboBox.SelectedItem == null)
         {
            MessageBox.Show("Для расчета доступного для создания продукта нужно заполнить продукт", "Ошибка", MessageBoxButtons.OK);
            return;
         }

         String sqlGetAmount = "select min([Ingredient Warehouse].Weight / Proportions.Weight) as Amount from Products"
               + " inner join Proportions on Proportions.NumProd = Products.NumProd"
               + " inner join Ingredients on Ingredients.NumIng = Proportions.NumIng"
               + " inner join[Ingredient Warehouse] on[Ingredient Warehouse].NumIng = Ingredients.NumIng"
               + " where Products.Name = \'" + howMuchProdComboBox.Text + "\'"
               + " group by Products.Name";
         OleDbDataReader reader = new OleDbCommand(sqlGetAmount, cn).ExecuteReader();
         reader.Read();
         howMuchAmountTextBox.Text = ((int)float.Parse(reader["Amount"].ToString())).ToString();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (changeProdWarProdComboBox.SelectedItem == null)
         {
            MessageBox.Show("Для изменения данных склада нужно заполнить продукт", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         if (changeProdWarAmountTextBox.Text.Length == 0)
         {
            MessageBox.Show("Для изменения данных склада нужно заполнить количество продукта", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         int amount;
         try
         {
            amount = int.Parse(changeProdWarAmountTextBox.Text);
            if (amount <= 0)
            {
               throw new Exception();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Кол-во продукта должно представлять из себя положительное целое число", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         int numProd;
         String sqlGetNumProd = "select NumProd from products where Name = \'" + changeProdWarProdComboBox.Text + "\'";
         OleDbDataReader reader = new OleDbCommand(sqlGetNumProd, cn).ExecuteReader();
         reader.Read();
         numProd = int.Parse(reader["NumProd"].ToString());

         String sqlCheckExistence = "select Name from [Product Warehouse]"
               + " inner join Products on Products.NumProd = [Product Warehouse].NumProd"
               + " where Name = \'" + changeProdWarProdComboBox.Text + '\'';
         OleDbCommand cmdCheckExistence = new OleDbCommand(sqlCheckExistence, cn);
         reader = cmdCheckExistence.ExecuteReader();
         if (reader.HasRows)
         {
            String sqlUpdateProdWarehouse = "update [Product Warehouse] set Amount = " + int.Parse(changeProdWarAmountTextBox.Text)
                  + " where NumProd = " + numProd;
            OleDbCommand cmdUpdateProdWarehouse = new OleDbCommand(sqlUpdateProdWarehouse, cn);
            cmdUpdateProdWarehouse.ExecuteNonQuery();
         }
         else
         {
            String sqlAddProdWarehouse = "insert into [Product Warehouse] (NumProd, Amount) values (?, ?)";
            OleDbCommand cmdAddProdWarehouse = new OleDbCommand(sqlAddProdWarehouse, cn);

            cmdAddProdWarehouse.Parameters.Add("@p1", OleDbType.Integer);
            cmdAddProdWarehouse.Parameters.Add("@p2", OleDbType.Integer);

            cmdAddProdWarehouse.Parameters[0].Value = numProd;
            cmdAddProdWarehouse.Parameters[1].Value = int.Parse(changeProdWarAmountTextBox.Text);

            cmdAddProdWarehouse.ExecuteNonQuery();
         }

         MessageBox.Show("Данные склада успешно обновлены", "Обновление данных", MessageBoxButtons.OK);
      }

      private void openProdWarTable_Click(object sender, EventArgs e)
      {
         if (!Table.prodWarehouse)
         {
            prodWarehouseTable = new Table(cn, "[Product Warehouse]");
            prodWarehouseTable.Show();
         }
         else
         {
            prodWarehouseTable.Activate();
         }
      }

      private void openRecipesButton_Click(object sender, EventArgs e)
      {
         if (!Table.recipes)
         {
            recipesTable = new Table(cn, "Recipes");
            recipesTable.Show();
         }
         else
         {
            recipesTable.Activate();
         }
      }

      private void showRecipeButton_Click(object sender, EventArgs e)
      {
         if (recipeProdComboBox.SelectedItem == null)
         {
            MessageBox.Show("Чтобы показать рецепт, его нужно сначала выбрать", "Ошибка", MessageBoxButtons.OK);
            return;
         }

         new Table(cn, "Recipe", recipeProdComboBox.SelectedItem.ToString()).Show();
      }

      private void button1_Click_1(object sender, EventArgs e)
      {
         if (!Table.deliveries)
         {
            clientOrdersTable = new Table(cn, "Deliveries");
            clientOrdersTable.Show();
         }
         else
         {
            clientOrdersTable.Activate();
         }
      }

      private void changeOrderButton_Click(object sender, EventArgs e)
      {
         if (changeOrderOrderComboBox.SelectedItem == null)
         {
            MessageBox.Show("Чтобы изменить статус заказа, нужно указать его номер", "Ошибка изменения статуса", MessageBoxButtons.OK);
            return;
         }

         if (changeOrderStatusComboBox.SelectedItem == null)
         {
            MessageBox.Show("Чтобы изменить статус заказа, нужно указать новый статус", "Ошибка изменения статуса", MessageBoxButtons.OK);
            return;
         }

         String sqlChangeOrderStatus = "update [Deliveries] set NumStat = "
                     + "(select NumStat from [Order Statuses] where Name = \'" + changeOrderStatusComboBox.Text
                     + "\')"
               + " where NumDel = " + int.Parse(changeOrderOrderComboBox.Text);
         OleDbCommand cmdChangeOrderStatus = new OleDbCommand(sqlChangeOrderStatus, cn);
         cmdChangeOrderStatus.ExecuteNonQuery();

         MessageBox.Show("Статус заказа успешно изменен", "Изменение статуса", MessageBoxButtons.OK);
      }

      private void productWarehousePage_Click(object sender, EventArgs e)
      {

      }

      private void ProducerForm_FormClosing(object sender, FormClosingEventArgs e)
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

         if (nameTextbox.Text.Contains('\''))
         {
            MessageBox.Show("Текстовое поле не может содержать одинарные кавычки", "Ошибка обновления данных", MessageBoxButtons.OK);
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

         if (emailTextbox.Text.Contains('\''))
         {
            MessageBox.Show("Текстовое поле не может содержать одинарные кавычки", "Ошибка обновления данных", MessageBoxButtons.OK);
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

      private void openIngWarehouseTableButton_Click(object sender, EventArgs e)
      {
         if (!Table.ingWarehouse)
         {
            ingWarehouseTable = new Table(cn, "[Ingredient Warehouse]");
            ingWarehouseTable.Show();
         }
         else
         {
            ingWarehouseTable.Activate();
         }
      }
   }
}
