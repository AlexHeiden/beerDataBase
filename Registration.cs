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
   public partial class Registration : Form
   {      
      public Registration(OleDbConnection cn, Authorization authorization)
      {
         InitializeComponent();
         isUserRegistered = false;
         this.cn = cn;
         this.authorization = authorization;
         String sqlAddPositionsToComboBox = "select Name from Roles";
         OleDbCommand cmdAddPositionsToComboBox = new OleDbCommand(sqlAddPositionsToComboBox, cn);
         OleDbDataReader reader = cmdAddPositionsToComboBox.ExecuteReader();
         while (reader.Read())
         {
            positionComboBox.Items.Add(reader["Name"].ToString());
         }

         if (positionComboBox.Items.Count == 0)
         {
            MessageBox.Show("В базе на данный момент нет ни одной позиции. Регистрация невозможна!", "Внутренняя ошибка", MessageBoxButtons.OK);
            Application.Exit();
         }
      }

      public static bool isEmailInDatabase(String userEmail, OleDbConnection cn)
      {
         String sqlGetEmails = "select Email from Users";
         OleDbCommand cmdGetEmails = new OleDbCommand(sqlGetEmails, cn);
         OleDbDataReader reader = cmdGetEmails.ExecuteReader();
         userEmail = userEmail.Trim(' ');
         while (reader.Read())
         {
            if (userEmail.Equals(reader["Email"].ToString().Trim(' ')))
            {
               return true;
            }
         }

         return false;
      }

      public static String getHashedPassword(String password)
      {
         String hashedPassword = "";
         foreach (char i in password)
         {
            char newPasswordPart = i;
            newPasswordPart++;
            hashedPassword = hashedPassword + newPasswordPart;
         }

         return hashedPassword;
      }

      public static int getRoleId(String role, OleDbConnection cn)
      {
         int roleIndex = 1;
         String sqlGetRoleIndex = "select NumRole, Name from Roles where Name = \'" + role + '\'';
         OleDbCommand cmdGetRoleIndex = new OleDbCommand(sqlGetRoleIndex, cn);
         OleDbDataReader reader = cmdGetRoleIndex.ExecuteReader();
         reader.Read();
         roleIndex = (int)reader["NumRole"];
         return roleIndex;
      }

      private OleDbConnection cn;
      private Authorization authorization;
      private bool isUserRegistered;

      private void Registration_Load(object sender, EventArgs e)
      {

      }

      private void Registration_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (!isUserRegistered)
         {
            cn.Close();
            Application.Exit();
         }         
      }

      private void registerButton_Click(object sender, EventArgs e)
      {
         if (nameTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для регистрации нужно заполнить имя / наименование организации", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (nameTextbox.Text.Length > 50)
         {
            MessageBox.Show("Имя / наименование организации должно занимать не более 50 символов", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (emailTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для регистрации нужно заполнить email", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (emailTextbox.Text.Length > 50)
         {
            MessageBox.Show("Email должен занимать не более 50 символов", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (positionComboBox.SelectedItem == null)
         {
            MessageBox.Show("Для регистрации нужно выбрать вашу позицию", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (passwordTextbox.Text.Length == 0)
         {
            MessageBox.Show("Для регистрации нужно заполнить пароль", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (passwordTextbox.Text.Length > 20)
         {
            MessageBox.Show("Пароль должен занимать не более 20 символов", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         if (passwordTextbox.Text.Contains(' '))
         {
            MessageBox.Show("В пароле нельзя использовать символ пробела", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         //проверка на использование email пользователя в базе
         if (isEmailInDatabase(emailTextbox.Text, cn))
         {
            MessageBox.Show("Данный Email уже используется другим пользователем", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         //получение id позиции пользователя
         int roleIndex = getRoleId(positionComboBox.Text, cn);

         //шифрование пароля
         String hashedPassword = getHashedPassword(passwordTextbox.Text);

         string sqlRegister = "insert into Users (Name, NumRole, Email, HashedPassword) values (?, ?, ?, ?)";
         OleDbCommand cmdRegister = new OleDbCommand(sqlRegister, cn);
         
         cmdRegister.Parameters.Add("@p1", OleDbType.VarChar, 50);
         cmdRegister.Parameters.Add("@p2", OleDbType.Integer);
         cmdRegister.Parameters.Add("@p3", OleDbType.VarChar, 50);
         cmdRegister.Parameters.Add("@p4", OleDbType.VarChar, 20);

         cmdRegister.Parameters[0].Value = nameTextbox.Text.Trim(' ');
         cmdRegister.Parameters[1].Value = roleIndex;
         cmdRegister.Parameters[2].Value = emailTextbox.Text.Trim(' ');
         cmdRegister.Parameters[3].Value = hashedPassword;

         try
         {
            cmdRegister.ExecuteNonQuery();            
         }
         catch (OleDbException ex)
         {
            MessageBox.Show("Ошибка запроса регистрации. Попробуйте зарегистрироваться позже", "Ошибка регистрации", MessageBoxButtons.OK);
            return;
         }

         MessageBox.Show("Вы успешно зарегистрированы!", "Регистрация", MessageBoxButtons.OK);
         isUserRegistered = true;
         authorization.Show();
         Close();
      }      
   }
}
