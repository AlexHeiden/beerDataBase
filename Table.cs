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
   public partial class Table : Form
   {
      public static bool providers, providerPrices, orderDetails, ingWarehouse, prodWarehouse, recipes,
            deliveries, clientOrders = false;
      public Table(OleDbConnection cn, String tableName, String analyzeIngredient = null)
      {
         InitializeComponent();
         this.cn = cn;
         this.tableName = tableName;
         this.analyzeIngredient = analyzeIngredient;
         String sqlRequest = getSqlRequestForTable(tableName);
         da = new OleDbDataAdapter(sqlRequest, cn);
         DataTable tableCustomers = new DataTable(tableName);         
         ds.Tables.Add(tableCustomers);
         dgTable.SetDataBinding(ds, tableName);
         da.Fill(ds, tableName);
         dgTable.DataMember = tableName;
         switch (tableName)
         {
            case "Providers":
            {
                  Text = "Поставщики";
                  providers = true;
                  break;
            }
            case "[Provider Prices]":
            {
                  Text = "Цены поставщиков";
                  providerPrices = true;
                  break;
            }
            case "OrderDetails":
            {
                  Text = "Заказы ингредиентов";
                  orderDetails = true;
                  break;
            }
            case "PriceAnalyze":
            {
                  Text = "Сведение цен";
                  break;
            }
            case "[Ingredient Warehouse]":
            {
                  Text = "Склад ингредиентов";
                  ingWarehouse = true;
                  break;
            }
            case "[Product Warehouse]":
            {
                  Text = "Склад продуктов";
                  prodWarehouse = true;
                  break;
            }
            case "Recipes":
            {
                  Text = "Рецепты";
                  recipes = true;
                  break;
            }
            case "Recipe":
            {
                  Text = "Рецепт";
                  break;
            }
            case "Deliveries":
            {
                  Text = "Заказы клиентов";
                  deliveries = true;
                  break;
            }
            case "ClientOrders":
            {
                  Text = "Мои заказы";
                  clientOrders = true;
                  break;
            }
         }
      }

      private OleDbDataAdapter da;
      private OleDbConnection cn;
      private String tableName;
      private String analyzeIngredient;

      private void Table_Load(object sender, EventArgs e)
      {

      }

      private void Table_FormClosing(object sender, FormClosingEventArgs e)
      {
        switch (Text)
        {
            case "Поставщики":
            {
                  providers = false;
                  break;
            }
            case "Цены поставщиков":
            {
                  providerPrices = false;
                  break;
            }
            case "Заказы ингредиентов":
            {
                  orderDetails = false;
                  break;
            }
            case "Склад ингредиентов":
            {
                  ingWarehouse = false;
                  break;
            }
            case "Склад продуктов":
            {
                  prodWarehouse = false;
                  break;
            }
            case "Рецепты":
            {
                  recipes = false;
                  break;
            }
            case "Заказы клиентов":
            {
                  deliveries = false;
                  break;
            }
            case "Мои заказы":
            {
                  clientOrders = false;
                  break;
            }
         }
      }

      private void refreshButton_Click(object sender, EventArgs e)
      {
         refresh(tableName);
      }

      private void refresh(String str)
      {
         da = new OleDbDataAdapter(getSqlRequestForTable(str), cn);
         DataTable tableCustomers = new DataTable();
         ds.Clear();
         ds.Tables.Add(tableCustomers);
         dgTable.SetDataBinding(ds, str);
         da.Fill(ds, str);
         dgTable.DataMember = str;
      }

      private String getSqlRequestForTable(String str)
      {
         switch (str)
         {
            case "Providers":
            {
                  return "select * from " + str;
            }
            case "[Provider Prices]":
            {
                  return "select NumPrice, Providers.Name, Ingredients.Name as Ingredient, PriceKilo from " + str
                        + " inner join Providers on " + str + ".NumProv = Providers.NumProv"
                        + " inner join Ingredients on " + str + ".NumIng = Ingredients.NumIng";
            }
            case "OrderDetails":
            {
                  return "select " + str + ".NumOrder, Providers.Name, Ingredients.Name as Ingredient, Weight, [Order Statuses].Name as Status, [Ingredient Orders].Date from " + str 
                        + " inner join [Ingredient Orders] on " + str + ".NumOrder = [Ingredient Orders].NumOrder" 
                        + " inner join Providers on Providers.NumProv = [Ingredient Orders].NumProv"
                        + " inner join Ingredients on Ingredients.NumIng = " + str + ".NumIng" 
                        + " inner join [Order Statuses] on [Order Statuses].NumStat = [Ingredient Orders].NumStat";
            }
            case "PriceAnalyze":
            {
                  return "select Providers.Name as Provider, Ingredients.Name as Ingredient, PriceKilo from [Provider Prices]" 
                        + " inner join Providers on Providers.NumProv = [Provider Prices].NumProv" 
                        + " inner join Ingredients on Ingredients.NumIng = [Provider Prices].NumIng" 
                        + " where Ingredients.Name = \'" + analyzeIngredient + "\'";
            }
            case "[Ingredient Warehouse]":
            {
                  return "select Ingredients.Name as Ingredient, Weight from " + str
                        + " inner join Ingredients on Ingredients.NumIng = " + str + ".NumIng";
            }
            case "[Product Warehouse]":
            {
                  return "select Products.Name as Product, Amount from " + str
                        + " inner join Products on Products.NumProd = " + str + ".NumProd";
            }
            case "Recipes":
            {
                  return "select Products.Name as Product, Ingredients.Name as Ingredient, Weight from Products"
                        + " inner join Proportions on Proportions.NumProd = Products.NumProd"
                        + " inner join Ingredients on Ingredients.NumIng = Proportions.NumIng";
            }
            case "Recipe":
            {
                  return "select Products.Name as Product, Ingredients.Name as Ingredient, Weight from Products"
                        + " inner join Proportions on Proportions.NumProd = Products.NumProd"
                        + " inner join Ingredients on Ingredients.NumIng = Proportions.NumIng"
                        + " where Products.Name = \'" + analyzeIngredient + '\'';
            }
            case "Deliveries":
            {
                  return "select Deliveries.NumDel, Users.Name as Client, Products.Name as Product, [Order Statuses].Name as Status,"
                        + " Date from Deliveries"
                        + " inner join Users on Users.NumUser = Deliveries.NumClient"
                        + " inner join [Order Statuses] on [Order Statuses].NumStat = Deliveries.NumStat"
                        + " inner join [Delivery Details] on [Delivery Details].NumDel = Deliveries.NumDel"
                        + " inner join Products on Products.NumProd = [Delivery Details].NumProd";
            }
            case "ClientOrders":
            {
                  return "select Deliveries.NumDel, Products.Name as Product, [Product Categories].Name as Category," 
                        + " Amount, Price * Amount as Price, [Order Statuses].Name as Status, Deliveries.Date from Deliveries"
                        + " inner join [Order Statuses] on [Order Statuses].NumStat = Deliveries.NumStat"
                        + " inner join [Delivery Details] on [Delivery Details].NumDel = Deliveries.NumDel"
                        + " inner join Products on Products.NumProd = [Delivery Details].NumProd"
                        + " inner join [Product Categories] on [Product Categories].NumCat = Products.NumCat"
                        + " where NumClient = " + analyzeIngredient;
            }
         }

         throw new Exception();
      }
   }
}
