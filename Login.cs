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
   public partial class BeerManiaLogin : Form
   {
      public BeerManiaLogin()
      {
         InitializeComponent();
         try
         {
            cn.Open();            
         }
         catch (Exception)
         {
            MessageBox.Show("The program couldn't connect to database! The server is probably offline currently. Try again later!", "Connection", MessageBoxButtons.OK);
         }
      }

      private void BeerManiaLogin_Load(object sender, EventArgs e)
      {

      }
   }
}
