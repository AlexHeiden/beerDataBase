
namespace BeerCourseWork
{
   partial class BeerManiaLogin
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
         this.cn = new System.Data.OleDb.OleDbConnection();
         this.SuspendLayout();
         // 
         // cn
         // 
         this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-MCCPRDD\\GREENKNIGHT;Integrated Security=SS" +
    "PI;Initial Catalog=Beer";
         // 
         // BeerManiaLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Name = "BeerManiaLogin";
         this.Text = "BeerMania Login";
         this.Load += new System.EventHandler(this.BeerManiaLogin_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Data.OleDb.OleDbConnection cn;
   }
}

