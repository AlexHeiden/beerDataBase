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
   public partial class Cart : Form
   {
      public const String tableName = "cart";
      public static bool isCartOpen = false;
      public Cart(OleDbConnection cn)
      {
         InitializeComponent();
         this.cn = cn;
         table = new DataTable(tableName);
         ds.Tables.Add(table);
         dgTable.DataMember = tableName;
         isCartOpen = true;

         table.Columns.Add("Product", typeof(String));
         table.Columns.Add("Category", typeof(String));
         table.Columns.Add("Amount", typeof(int));
         table.Columns.Add("Price", typeof(float));

         dgTable.SetDataBinding(ds, tableName);
      }

      public void add(String product, String category, int amount, float price)
      {
         foreach (DataRow row in ds.Tables[tableName].Rows)
         {
            if (row["Product"].Equals(product))
            {               
               row["Category"] = category;
               row["Amount"] = amount;
               row["Price"] = price;
               return;
            }
         }

         DataRow dRow = ds.Tables[tableName].NewRow();
         dRow["Product"] = product;
         dRow["Category"] = category;
         dRow["Amount"] = amount;
         dRow["Price"] = price;
         ds.Tables[tableName].Rows.Add(dRow);
      }

      public float getPrice()
      {
         float price = 0;
         foreach (DataRow row in ds.Tables[tableName].Rows)
         {
            price += (float)row["Price"];
         }

         return price;
      }

      public void createOrder(String email)
      {
         String getUserId = "select NumUser from Users where Email = \'" + email + '\'';
         OleDbDataReader reader = new OleDbCommand(getUserId, cn).ExecuteReader();
         reader.Read();
         int numClient = int.Parse(reader["NumUser"].ToString());

         String getStatus = "select NumStat from [Order Statuses] where Name = \'Создан\'";
         reader = new OleDbCommand(getStatus, cn).ExecuteReader();
         reader.Read();
         int numStatus = int.Parse(reader["NumStat"].ToString());

         String date = DateTime.Today.ToString("dd/MM/yyyy");

         String sqlCreateOrder = "exec dbo.AddClientOrder ?, ?, ?, ?";
         OleDbCommand cmdCreateOrder = new OleDbCommand(sqlCreateOrder, cn);

         cmdCreateOrder.Parameters.Add("@p1", OleDbType.Integer);
         cmdCreateOrder.Parameters.Add("@p2", OleDbType.Integer);
         cmdCreateOrder.Parameters.Add("@p3", OleDbType.VarChar, 50);
         cmdCreateOrder.Parameters.Add("@p4", OleDbType.Integer);

         cmdCreateOrder.Parameters[0].Value = numClient;
         cmdCreateOrder.Parameters[1].Value = numStatus;
         cmdCreateOrder.Parameters[2].Value = date;
         cmdCreateOrder.Parameters[3].Value = -1;

         cmdCreateOrder.ExecuteNonQuery();

         String getLastOrderId = "select max(NumDel) as NumDel from Deliveries";
         reader = new OleDbCommand(getLastOrderId, cn).ExecuteReader();
         reader.Read();
         int orderId = int.Parse(reader["NumDel"].ToString());

         foreach (DataRow row in ds.Tables[tableName].Rows)
         {
            String getProductId = "select NumProd from Products where Name = \'" + row["Product"] + '\'';
            reader = new OleDbCommand(getProductId, cn).ExecuteReader();
            reader.Read();
            int productId = int.Parse(reader["NumProd"].ToString());

            String insertDeliveryDetail = "insert into [Delivery Details] (NumDel, NumProd, Amount) values (?, ?, ?)";
            OleDbCommand cmdInsertDeliveryDetail = new OleDbCommand(insertDeliveryDetail, cn);

            cmdInsertDeliveryDetail.Parameters.Add("@p1", OleDbType.Integer);
            cmdInsertDeliveryDetail.Parameters.Add("@p2", OleDbType.Integer);
            cmdInsertDeliveryDetail.Parameters.Add("@p3", OleDbType.Integer);

            cmdInsertDeliveryDetail.Parameters[0].Value = orderId;
            cmdInsertDeliveryDetail.Parameters[1].Value = productId;
            cmdInsertDeliveryDetail.Parameters[2].Value = row["Amount"];

            cmdInsertDeliveryDetail.ExecuteNonQuery();
         }
      }

      private OleDbConnection cn;
      private DataTable table;
      private void Cart_Load(object sender, EventArgs e)
      {

      }

      private void Cart_FormClosing(object sender, FormClosingEventArgs e)
      {
         isCartOpen = false;
      }
   }
}
