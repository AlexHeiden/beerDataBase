
namespace BeerCourseWork
{
   partial class Cart
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
         this.dgTable = new System.Windows.Forms.DataGrid();
         this.ds = new System.Data.DataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
         this.SuspendLayout();
         // 
         // dgTable
         // 
         this.dgTable.DataMember = "";
         this.dgTable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dgTable.Location = new System.Drawing.Point(12, 12);
         this.dgTable.Name = "dgTable";
         this.dgTable.Size = new System.Drawing.Size(776, 426);
         this.dgTable.TabIndex = 0;
         // 
         // ds
         // 
         this.ds.DataSetName = "NewDataSet";
         // 
         // Cart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.dgTable);
         this.Name = "Cart";
         this.Text = "Корзина";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cart_FormClosing);
         this.Load += new System.EventHandler(this.Cart_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.DataGrid dgTable;
      private System.Data.DataSet ds;
   }
}