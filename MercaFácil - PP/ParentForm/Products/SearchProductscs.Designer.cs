namespace ParentForm
{
    partial class SearchProductscs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProductscs));
            this.grid_SearchProducts = new System.Windows.Forms.DataGridView();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_Products = new System.Windows.Forms.TextBox();
            this.btn_EditProducts = new System.Windows.Forms.Button();
            this.productoTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_SearchProducts
            // 
            this.grid_SearchProducts.AllowUserToAddRows = false;
            this.grid_SearchProducts.AllowUserToDeleteRows = false;
            this.grid_SearchProducts.AutoGenerateColumns = false;
            this.grid_SearchProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_SearchProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SearchProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.porcentajeIvaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.borradoDataGridViewTextBoxColumn});
            this.grid_SearchProducts.DataSource = this.productoBindingSource;
            this.grid_SearchProducts.Location = new System.Drawing.Point(12, 150);
            this.grid_SearchProducts.Name = "grid_SearchProducts";
            this.grid_SearchProducts.ReadOnly = true;
            this.grid_SearchProducts.RowTemplate.Height = 24;
            this.grid_SearchProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SearchProducts.Size = new System.Drawing.Size(843, 229);
            this.grid_SearchProducts.TabIndex = 8;
            this.grid_SearchProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SearchProducts_CellClick);
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Barras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "Codigo_Barras";
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            this.codigoBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio_Venta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeIvaDataGridViewTextBoxColumn
            // 
            this.porcentajeIvaDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje_Iva";
            this.porcentajeIvaDataGridViewTextBoxColumn.HeaderText = "Porcentaje_Iva";
            this.porcentajeIvaDataGridViewTextBoxColumn.Name = "porcentajeIvaDataGridViewTextBoxColumn";
            this.porcentajeIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borradoDataGridViewTextBoxColumn
            // 
            this.borradoDataGridViewTextBoxColumn.DataPropertyName = "Borrado";
            this.borradoDataGridViewTextBoxColumn.HeaderText = "Borrado";
            this.borradoDataGridViewTextBoxColumn.Name = "borradoDataGridViewTextBoxColumn";
            this.borradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(661, 111);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(52, 17);
            this.lbl_Search.TabIndex = 7;
            this.lbl_Search.Text = "Buscar";
            // 
            // txt_Products
            // 
            this.txt_Products.Location = new System.Drawing.Point(140, 108);
            this.txt_Products.Name = "txt_Products";
            this.txt_Products.Size = new System.Drawing.Size(500, 22);
            this.txt_Products.TabIndex = 6;
            this.txt_Products.TextChanged += new System.EventHandler(this.txt_Products_TextChanged);
            // 
            // btn_EditProducts
            // 
            this.btn_EditProducts.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditProducts.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_EditProducts.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EditProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EditProducts.Location = new System.Drawing.Point(387, 402);
            this.btn_EditProducts.Name = "btn_EditProducts";
            this.btn_EditProducts.Size = new System.Drawing.Size(84, 32);
            this.btn_EditProducts.TabIndex = 9;
            this.btn_EditProducts.Text = "Editar";
            this.btn_EditProducts.UseVisualStyleBackColor = false;
            this.btn_EditProducts.Click += new System.EventHandler(this.btn_EditProducts_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 68);
            this.panel1.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(373, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 44);
            this.label11.TabIndex = 1;
            this.label11.Text = "Buscar";
            // 
            // SearchProductscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EditProducts);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Products);
            this.Controls.Add(this.grid_SearchProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchProductscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_SearchProducts;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Products;
        private System.Windows.Forms.Button btn_EditProducts;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private MercaFacil_2DataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}