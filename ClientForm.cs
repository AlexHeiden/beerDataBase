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
   public partial class ClientForm : Form
   {
      public ClientForm(OleDbConnection cn, String email)
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

         String sqlGetProductList = "select Name from Products";
         OleDbCommand cmdGetProductList = new OleDbCommand(sqlGetProductList, cn);
         reader = cmdGetProductList.ExecuteReader();
         while (reader.Read())
         {
            productComboBox.Items.Add(reader["Name"].ToString());
         }
      }

      private OleDbConnection cn;
      private String email;
      private Table myOrders;
      private Cart cart;

      private void ClientForm_Load(object sender, EventArgs e)
      {

      }

      private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
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

      private void openMyOrdersButton_Click(object sender, EventArgs e)
      {
         if (!Table.clientOrders)
         {
            String sqlGetUserId = "select NumUser from Users where Email = \'" + email + '\'';            
            OleDbDataReader reader = new OleDbCommand(sqlGetUserId, cn).ExecuteReader();
            reader.Read();
            myOrders = new Table(cn, "ClientOrders", reader["NumUser"].ToString());
            myOrders.Show();
         }
         else
         {
            myOrders.Activate();
         }
      }

      private void addToCartButton_Click(object sender, EventArgs e)
      {
         if (productComboBox.SelectedItem == null)
         {
            MessageBox.Show("Чтобы добавить продукт в корзину, нужно указать продукт", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         if (amountTextBox.Text.Length == 0)
         {
            MessageBox.Show("Чтобы добавить продукт в корзину, нужно указать количество", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }

         int amount;
         try
         {
            amount = int.Parse(amountTextBox.Text);
            if (amount <= 0)
            {
               throw new Exception();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Количество должно быть целым положительным числом", "Ошибка обновления данных", MessageBoxButtons.OK);
            return;
         }         

         String product = productComboBox.Text;
         String sqlGetCategoryPrice = "select [Product Categories].Name, Products.Price from Products"
               + " inner join [Product Categories] on [Product Categories].NumCat = Products.NumCat"
               + " where Products.Name = \'" + product + '\'';
         OleDbDataReader reader = new OleDbCommand(sqlGetCategoryPrice, cn).ExecuteReader();
         reader.Read();
         String category = reader["Name"].ToString();
         float price = amount * float.Parse(reader["Price"].ToString());

         if (!Cart.isCartOpen)
         {
            cart = new Cart(cn);
            cart.Show();
         }

         cart.add(product, category, amount, price);
         sumTextBox.Text = cart.getPrice().ToString();
         MessageBox.Show("Вы успешно добавили продукт в корзину", "Добавление в корзину", MessageBoxButtons.OK);
      }

      private void createOrderButton_Click(object sender, EventArgs e)
      {
         if (!Cart.isCartOpen)
         {
            MessageBox.Show("Чтобы оформить заказ, нужно добавить продукты в корзину", "Оформление заказа", MessageBoxButtons.OK);
            return;
         }

         DialogResult dialog = MessageBox.Show("Вы уверены, что хотите оформить заказ?", "Оформление заказа", MessageBoxButtons.YesNo);
         if (dialog == DialogResult.No)
         {
            return;
         }

         cart.createOrder(email);

         MessageBox.Show("Ваш заказ успешно оформлен", "Оформление заказа", MessageBoxButtons.OK);
         cart.Close();
      }
   }
}
