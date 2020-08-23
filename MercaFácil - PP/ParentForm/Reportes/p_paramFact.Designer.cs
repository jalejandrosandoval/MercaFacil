namespace ParentForm
{
    partial class p_paramFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(p_paramFact));
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.dGrid_ShoppingCart = new System.Windows.Forms.DataGridView();
            this.numeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaMultipleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMultiplesTablas = new ParentForm.DataSetMultiplesTablas();
            this.factura_MultipleTableAdapter = new ParentForm.DataSetMultiplesTablasTableAdapters.Factura_MultipleTableAdapter();
            this.btn_show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_ShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaMultipleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMultiplesTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(49, 119);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(200, 22);
            this.dtp_begin.TabIndex = 0;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(373, 119);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 22);
            this.dtp_end.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 67);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(305, 7);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(279, 44);
            this.lbl_Ventas.TabIndex = 3;
            this.lbl_Ventas.Text = "Reporte de Facturas";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Confirm.Location = new System.Drawing.Point(267, 117);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(90, 29);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Confirmar";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dGrid_ShoppingCart
            // 
            this.dGrid_ShoppingCart.AllowUserToAddRows = false;
            this.dGrid_ShoppingCart.AllowUserToDeleteRows = false;
            this.dGrid_ShoppingCart.AutoGenerateColumns = false;
            this.dGrid_ShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid_ShoppingCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_ShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_ShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.anotacionDataGridViewTextBoxColumn,
            this.usuarioNombresDataGridViewTextBoxColumn,
            this.usuarioApellidosDataGridViewTextBoxColumn,
            this.clienteNombresDataGridViewTextBoxColumn,
            this.clienteApellidosDataGridViewTextBoxColumn});
            this.dGrid_ShoppingCart.DataSource = this.facturaMultipleBindingSource;
            this.dGrid_ShoppingCart.Location = new System.Drawing.Point(49, 161);
            this.dGrid_ShoppingCart.Name = "dGrid_ShoppingCart";
            this.dGrid_ShoppingCart.ReadOnly = true;
            this.dGrid_ShoppingCart.RowTemplate.Height = 24;
            this.dGrid_ShoppingCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid_ShoppingCart.Size = new System.Drawing.Size(758, 262);
            this.dGrid_ShoppingCart.TabIndex = 5;
            this.dGrid_ShoppingCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_ShoppingCart_CellClick);
            // 
            // numeroFacturaDataGridViewTextBoxColumn
            // 
            this.numeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Factura";
            this.numeroFacturaDataGridViewTextBoxColumn.HeaderText = "Numero_Factura";
            this.numeroFacturaDataGridViewTextBoxColumn.Name = "numeroFacturaDataGridViewTextBoxColumn";
            this.numeroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anotacionDataGridViewTextBoxColumn
            // 
            this.anotacionDataGridViewTextBoxColumn.DataPropertyName = "Anotacion";
            this.anotacionDataGridViewTextBoxColumn.HeaderText = "Anotacion";
            this.anotacionDataGridViewTextBoxColumn.Name = "anotacionDataGridViewTextBoxColumn";
            this.anotacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioNombresDataGridViewTextBoxColumn
            // 
            this.usuarioNombresDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Nombres";
            this.usuarioNombresDataGridViewTextBoxColumn.HeaderText = "Usuario_Nombres";
            this.usuarioNombresDataGridViewTextBoxColumn.Name = "usuarioNombresDataGridViewTextBoxColumn";
            this.usuarioNombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioApellidosDataGridViewTextBoxColumn
            // 
            this.usuarioApellidosDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Apellidos";
            this.usuarioApellidosDataGridViewTextBoxColumn.HeaderText = "Usuario_Apellidos";
            this.usuarioApellidosDataGridViewTextBoxColumn.Name = "usuarioApellidosDataGridViewTextBoxColumn";
            this.usuarioApellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteNombresDataGridViewTextBoxColumn
            // 
            this.clienteNombresDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Nombres";
            this.clienteNombresDataGridViewTextBoxColumn.HeaderText = "Cliente_Nombres";
            this.clienteNombresDataGridViewTextBoxColumn.Name = "clienteNombresDataGridViewTextBoxColumn";
            this.clienteNombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteApellidosDataGridViewTextBoxColumn
            // 
            this.clienteApellidosDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Apellidos";
            this.clienteApellidosDataGridViewTextBoxColumn.HeaderText = "Cliente_Apellidos";
            this.clienteApellidosDataGridViewTextBoxColumn.Name = "clienteApellidosDataGridViewTextBoxColumn";
            this.clienteApellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaMultipleBindingSource
            // 
            this.facturaMultipleBindingSource.DataMember = "Factura_Multiple";
            this.facturaMultipleBindingSource.DataSource = this.dataSetMultiplesTablas;
            // 
            // dataSetMultiplesTablas
            // 
            this.dataSetMultiplesTablas.DataSetName = "DataSetMultiplesTablas";
            this.dataSetMultiplesTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factura_MultipleTableAdapter
            // 
            this.factura_MultipleTableAdapter.ClearBeforeFill = true;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_show.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_show.Location = new System.Drawing.Point(344, 466);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(156, 32);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Ver Factura";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // p_paramFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 553);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dGrid_ShoppingCart);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_begin);
            this.Name = "p_paramFact";
            this.Text = "p_paramFact";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_ShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaMultipleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMultiplesTablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridView dGrid_ShoppingCart;
        private DataSetMultiplesTablas dataSetMultiplesTablas;
        private System.Windows.Forms.BindingSource facturaMultipleBindingSource;
        private DataSetMultiplesTablasTableAdapters.Factura_MultipleTableAdapter factura_MultipleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_show;
    }
}