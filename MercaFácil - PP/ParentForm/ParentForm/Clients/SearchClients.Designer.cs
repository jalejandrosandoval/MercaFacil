namespace ParentForm
{
    partial class SearchClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchClients));
            this.grid_SearchVendors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_SearchVendors
            // 
            this.grid_SearchVendors.AllowUserToAddRows = false;
            this.grid_SearchVendors.AllowUserToDeleteRows = false;
            this.grid_SearchVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SearchVendors.Location = new System.Drawing.Point(12, 12);
            this.grid_SearchVendors.Name = "grid_SearchVendors";
            this.grid_SearchVendors.ReadOnly = true;
            this.grid_SearchVendors.RowTemplate.Height = 24;
            this.grid_SearchVendors.Size = new System.Drawing.Size(843, 229);
            this.grid_SearchVendors.TabIndex = 2;
            // 
            // SearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 253);
            this.Controls.Add(this.grid_SearchVendors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchClients";
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchVendors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_SearchVendors;
    }
}