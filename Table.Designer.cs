
namespace BeerCourseWork
{
   partial class Table
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
         this.ds = new System.Data.DataSet();
         this.dgTable = new System.Windows.Forms.DataGrid();
         this.refreshButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
         this.SuspendLayout();
         // 
         // ds
         // 
         this.ds.DataSetName = "NewDataSet";
         // 
         // dgTable
         // 
         this.dgTable.DataMember = "";
         this.dgTable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dgTable.Location = new System.Drawing.Point(12, 45);
         this.dgTable.Name = "dgTable";
         this.dgTable.Size = new System.Drawing.Size(788, 308);
         this.dgTable.TabIndex = 0;
         // 
         // refreshButton
         // 
         this.refreshButton.Location = new System.Drawing.Point(12, 12);
         this.refreshButton.Name = "refreshButton";
         this.refreshButton.Size = new System.Drawing.Size(93, 27);
         this.refreshButton.TabIndex = 1;
         this.refreshButton.Text = "Обновить";
         this.refreshButton.UseVisualStyleBackColor = true;
         this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
         // 
         // Table
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(812, 365);
         this.Controls.Add(this.refreshButton);
         this.Controls.Add(this.dgTable);
         this.Name = "Table";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Table";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Table_FormClosing);
         this.Load += new System.EventHandler(this.Table_Load);
         ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Data.DataSet ds;
      private System.Windows.Forms.DataGrid dgTable;
      private System.Windows.Forms.Button refreshButton;
   }
}