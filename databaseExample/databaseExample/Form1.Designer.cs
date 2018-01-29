namespace databaseExample
{
    partial class frmMain
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
            this.cookbookDataSet = new databaseExample.cookbookDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "cookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recipes";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 16;
            this.lstRecipes.Location = new System.Drawing.Point(16, 34);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(153, 196);
            this.lstRecipes.TabIndex = 3;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 414);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cookbookDataSet cookbookDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRecipes;
    }
}

