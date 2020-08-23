namespace ParentForm
{
    partial class DevolucionDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucionDetalles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.lbl_NumFact = new System.Windows.Forms.Label();
            this.lbl_Fact = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_devPro = new System.Windows.Forms.Label();
            this.lbl_Products = new System.Windows.Forms.Label();
            this.dGrid_Dev = new System.Windows.Forms.DataGridView();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.dGrid_detailReturn = new System.Windows.Forms.DataGridView();
            this.numeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarrasProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleFacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.lbl_UsuarioName = new System.Windows.Forms.Label();
            this.detalle_Factura_VentaTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.Detalle_Factura_VentaTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Dev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_detailReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 84);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(419, 18);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(126, 44);
            this.lbl_Ventas.TabIndex = 5;
            this.lbl_Ventas.Text = "Detalles";
            // 
            // lbl_NumFact
            // 
            this.lbl_NumFact.AutoSize = true;
            this.lbl_NumFact.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumFact.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_NumFact.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_NumFact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_NumFact.Location = new System.Drawing.Point(129, 49);
            this.lbl_NumFact.Name = "lbl_NumFact";
            this.lbl_NumFact.Size = new System.Drawing.Size(179, 29);
            this.lbl_NumFact.TabIndex = 5;
            this.lbl_NumFact.Text = "Numero de Factura";
            // 
            // lbl_Fact
            // 
            this.lbl_Fact.AutoSize = true;
            this.lbl_Fact.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fact.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Fact.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Fact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Fact.Location = new System.Drawing.Point(23, 49);
            this.lbl_Fact.Name = "lbl_Fact";
            this.lbl_Fact.Size = new System.Drawing.Size(90, 29);
            this.lbl_Fact.TabIndex = 5;
            this.lbl_Fact.Text = "Factura: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_devPro);
            this.groupBox1.Controls.Add(this.lbl_Products);
            this.groupBox1.Controls.Add(this.dGrid_Dev);
            this.groupBox1.Controls.Add(this.btn_Minus);
            this.groupBox1.Controls.Add(this.btn_AddProduct);
            this.groupBox1.Controls.Add(this.btn_Return);
            this.groupBox1.Controls.Add(this.btn_Plus);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.dGrid_detailReturn);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.lbl_Desc);
            this.groupBox1.Controls.Add(this.lbl_User);
            this.groupBox1.Controls.Add(this.lbl_Fact);
            this.groupBox1.Controls.Add(this.lbl_ClientName);
            this.groupBox1.Controls.Add(this.lbl_Amount);
            this.groupBox1.Controls.Add(this.lbl_Client);
            this.groupBox1.Controls.Add(this.lbl_UsuarioName);
            this.groupBox1.Controls.Add(this.lbl_NumFact);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(28, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 732);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lbl_devPro
            // 
            this.lbl_devPro.AutoSize = true;
            this.lbl_devPro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_devPro.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_devPro.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_devPro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_devPro.Location = new System.Drawing.Point(23, 559);
            this.lbl_devPro.Name = "lbl_devPro";
            this.lbl_devPro.Size = new System.Drawing.Size(108, 58);
            this.lbl_devPro.TabIndex = 13;
            this.lbl_devPro.Text = "Productos\r\nDevolución";
            // 
            // lbl_Products
            // 
            this.lbl_Products.AutoSize = true;
            this.lbl_Products.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Products.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Products.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Products.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Products.Location = new System.Drawing.Point(32, 341);
            this.lbl_Products.Name = "lbl_Products";
            this.lbl_Products.Size = new System.Drawing.Size(99, 58);
            this.lbl_Products.TabIndex = 12;
            this.lbl_Products.Text = "Productos\r\n  Factura";
            // 
            // dGrid_Dev
            // 
            this.dGrid_Dev.AllowUserToAddRows = false;
            this.dGrid_Dev.AllowUserToDeleteRows = false;
            this.dGrid_Dev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid_Dev.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_Dev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_Dev.Location = new System.Drawing.Point(153, 495);
            this.dGrid_Dev.Name = "dGrid_Dev";
            this.dGrid_Dev.ReadOnly = true;
            this.dGrid_Dev.RowTemplate.Height = 24;
            this.dGrid_Dev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGrid_Dev.Size = new System.Drawing.Size(553, 150);
            this.dGrid_Dev.TabIndex = 14;
            // 
            // btn_Minus
            // 
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minus.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Minus.Location = new System.Drawing.Point(881, 283);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(25, 25);
            this.btn_Minus.TabIndex = 11;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click_1);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_AddProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddProduct.Location = new System.Drawing.Point(747, 448);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(134, 56);
            this.btn_AddProduct.TabIndex = 13;
            this.btn_AddProduct.Text = "Asignar \r\nProducto";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.btn_Return.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Return.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Return.Location = new System.Drawing.Point(389, 677);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(156, 31);
            this.btn_Return.TabIndex = 15;
            this.btn_Return.Text = "Devolución";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Plus.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Plus.Location = new System.Drawing.Point(881, 258);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(25, 25);
            this.btn_Plus.TabIndex = 10;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click_1);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(850, 272);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(31, 24);
            this.txt_Amount.TabIndex = 9;
            // 
            // dGrid_detailReturn
            // 
            this.dGrid_detailReturn.AllowUserToAddRows = false;
            this.dGrid_detailReturn.AllowUserToDeleteRows = false;
            this.dGrid_detailReturn.AutoGenerateColumns = false;
            this.dGrid_detailReturn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_detailReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_detailReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFacturaDataGridViewTextBoxColumn,
            this.codBarrasProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioTotalDataGridViewTextBoxColumn});
            this.dGrid_detailReturn.DataSource = this.detalleFacturaVentaBindingSource;
            this.dGrid_detailReturn.Location = new System.Drawing.Point(153, 267);
            this.dGrid_detailReturn.Name = "dGrid_detailReturn";
            this.dGrid_detailReturn.ReadOnly = true;
            this.dGrid_detailReturn.RowTemplate.Height = 24;
            this.dGrid_detailReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid_detailReturn.Size = new System.Drawing.Size(553, 179);
            this.dGrid_detailReturn.TabIndex = 12;
            this.dGrid_detailReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_detailReturn_CellClick);
            // 
            // numeroFacturaDataGridViewTextBoxColumn
            // 
            this.numeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Factura";
            this.numeroFacturaDataGridViewTextBoxColumn.HeaderText = "Numero_Factura";
            this.numeroFacturaDataGridViewTextBoxColumn.Name = "numeroFacturaDataGridViewTextBoxColumn";
            this.numeroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroFacturaDataGridViewTextBoxColumn.Width = 138;
            // 
            // codBarrasProductoDataGridViewTextBoxColumn
            // 
            this.codBarrasProductoDataGridViewTextBoxColumn.DataPropertyName = "CodBarras_Producto";
            this.codBarrasProductoDataGridViewTextBoxColumn.HeaderText = "CodBarras_Producto";
            this.codBarrasProductoDataGridViewTextBoxColumn.Name = "codBarrasProductoDataGridViewTextBoxColumn";
            this.codBarrasProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBarrasProductoDataGridViewTextBoxColumn.Width = 163;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 92;
            // 
            // precioTotalDataGridViewTextBoxColumn
            // 
            this.precioTotalDataGridViewTextBoxColumn.DataPropertyName = "Precio_Total";
            this.precioTotalDataGridViewTextBoxColumn.HeaderText = "Precio_Total";
            this.precioTotalDataGridViewTextBoxColumn.Name = "precioTotalDataGridViewTextBoxColumn";
            this.precioTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioTotalDataGridViewTextBoxColumn.Width = 113;
            // 
            // detalleFacturaVentaBindingSource
            // 
            this.detalleFacturaVentaBindingSource.DataMember = "Detalle_Factura_Venta";
            this.detalleFacturaVentaBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(153, 156);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Description.MaxLength = 100;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(553, 68);
            this.txt_Description.TabIndex = 7;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Desc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Desc.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Desc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Desc.Location = new System.Drawing.Point(23, 174);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(119, 29);
            this.lbl_Desc.TabIndex = 5;
            this.lbl_Desc.Text = "Descripción:";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_User.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_User.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_User.Location = new System.Drawing.Point(23, 100);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(108, 29);
            this.lbl_User.TabIndex = 5;
            this.lbl_User.Text = "Vendedor: ";
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ClientName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_ClientName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_ClientName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ClientName.Location = new System.Drawing.Point(761, 49);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(146, 29);
            this.lbl_ClientName.TabIndex = 5;
            this.lbl_ClientName.Text = "Nombre cliente";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Amount.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Amount.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Amount.Location = new System.Drawing.Point(724, 253);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(99, 29);
            this.lbl_Amount.TabIndex = 5;
            this.lbl_Amount.Text = "Cantidad:";
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Client.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Client.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Client.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Client.Location = new System.Drawing.Point(665, 49);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(81, 29);
            this.lbl_Client.TabIndex = 5;
            this.lbl_Client.Text = "Cliente:";
            // 
            // lbl_UsuarioName
            // 
            this.lbl_UsuarioName.AutoSize = true;
            this.lbl_UsuarioName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UsuarioName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_UsuarioName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_UsuarioName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_UsuarioName.Location = new System.Drawing.Point(137, 100);
            this.lbl_UsuarioName.Name = "lbl_UsuarioName";
            this.lbl_UsuarioName.Size = new System.Drawing.Size(168, 29);
            this.lbl_UsuarioName.TabIndex = 5;
            this.lbl_UsuarioName.Text = "Nombre vendedor";
            // 
            // detalle_Factura_VentaTableAdapter
            // 
            this.detalle_Factura_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // DevolucionDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 832);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DevolucionDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DevolucionDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Dev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_detailReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Label lbl_NumFact;
        private System.Windows.Forms.Label lbl_Fact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.Label lbl_UsuarioName;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.DataGridView dGrid_detailReturn;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Button btn_Return;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource detalleFacturaVentaBindingSource;
        private MercaFacil_2DataSetTableAdapters.Detalle_Factura_VentaTableAdapter detalle_Factura_VentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarrasProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.DataGridView dGrid_Dev;
        private System.Windows.Forms.Label lbl_devPro;
        private System.Windows.Forms.Label lbl_Products;
    }
}