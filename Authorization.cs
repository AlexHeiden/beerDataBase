using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.OleDb;

namespace BeerCourseWork
{
   public partial class Authorization : Form
   {
      public Authorization()
      {
         InitializeComponent();
         try
         {
            cn.Open();
         }
         catch (Exception)
         {
            MessageBox.Show("Программа не смогла подключиться к серверу! Скорее всего ведутся технические работы, попробуйте подключиться позже!", "Соединение", MessageBoxButtons.OK);
            Application.Exit();
         }
      }

      private void BeerManiaLogin_Load(object sender, EventArgs e)
      {

      }

      private void registerButton_Click(object sender, EventArgs e)
      {
         Registration registration = new Registration(cn, this);
         registration.Show();
         Hide();
      }

      private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
      {
         cn.Close();
         Application.Exit();
      }

      private void loginButton_Click(object sender, EventArgs e)
      {
         if (emailTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для входа нужно заполнить email", "Ошибка входа", MessageBoxButtons.OK);
            return;
         }

         if (emailTextbox.Text.Length > 50)
         {
            MessageBox.Show("Email может занимать не более 50 символов", "Ошибка входа", MessageBoxButtons.OK);
            return;
         }

         if (passwordTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для входа нужно заполнить пароль", "Ошибка входа", MessageBoxButtons.OK);
            return;
         }

         if (passwordTextbox.Text.Length > 20)
         {
            MessageBox.Show("Пароль должен занимать не более 20 символов", "Ошибка входа", MessageBoxButtons.OK);
            return;
         }

         String sqlGetLoginData = "select NumRole, HashedPassword from Users where Email = \'" + emailTextbox.Text + '\'';
         OleDbCommand cmdGetLoginData = new OleDbCommand(sqlGetLoginData, cn);
         OleDbDataReader reader = cmdGetLoginData.ExecuteReader();
         
         if (!reader.HasRows)
         {
            MessageBox.Show("Аккаунт с таким email еще не создан", "Ошибка входа", MessageBoxButtons.OK);
            return;
         }

         reader.Read();
         String userHashedPassword = Registration.getHashedPassword(passwordTextbox.Text.Trim());
         if (!userHashedPassword.Equals(reader["HashedPassword"].ToString().Trim()))
         {
            MessageBox.Show("Неверный пароль", "Ошибка входа", MessageBoxButtons.OK);
            return;
         }

         int roleIndex = (int)reader["NumRole"];
         String sqlGetRoleName = "select Name from Roles where NumRole = \'" + roleIndex + '\'';
         OleDbCommand cmdGetRoleName = new OleDbCommand(sqlGetRoleName, cn);
         reader = cmdGetRoleName.ExecuteReader();
         reader.Read();
         switch (reader["Name"].ToString().Trim())
         {
            case "Закупщик":
            {
                  new PurchaserForm(cn, emailTextbox.Text).Show();
                  break;
            }
            case "Производитель":
            {
                  new ProducerForm(cn, emailTextbox.Text).Show();
                  break;
            }
            case "Клиент":
            {
                  new ClientForm(cn, emailTextbox.Text).Show();
                  break;
            }
         }

         Hide();
      }
   }
}
