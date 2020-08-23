namespace ParentForm
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.txt_NumFact = new System.Windows.Forms.TextBox();
            this.lklb_Search = new System.Windows.Forms.LinkLabel();
            this.dGrid_RePayment = new System.Windows.Forms.DataGridView();
            this.numeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.btn_Go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.factura_VentaTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.Factura_VentaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_RePayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 67);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(257, 8);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(158, 44);
            this.lbl_Ventas.TabIndex = 4;
            this.lbl_Ventas.Text = "Devolución";
            // 
            // txt_NumFact
            // 
            this.txt_NumFact.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10F, System.Drawing.FontStyle.Bold);
            this.txt_NumFact.Location = new System.Drawing.Point(163, 151);
            this.txt_NumFact.Name = "txt_NumFact";
            this.txt_NumFact.Size = new System.Drawing.Size(397, 25);
            this.txt_NumFact.TabIndex = 11;
            this.txt_NumFact.TextChanged += new System.EventHandler(this.txt_NumFact_TextChanged);
            // 
            // lklb_Search
            // 
            this.lklb_Search.AutoSize = true;
            this.lklb_Search.BackColor = System.Drawing.Color.Transparent;
            this.lklb_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lklb_Search.LinkColor = System.Drawing.Color.Snow;
            this.lklb_Search.Location = new System.Drawing.Point(588, 159);
            this.lklb_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklb_Search.Name = "lklb_Search";
            this.lklb_Search.Size = new System.Drawing.Size(52, 17);
            this.lklb_Search.TabIndex = 12;
            this.lklb_Search.TabStop = true;
            this.lklb_Search.Text = "Buscar";
            // 
            // dGrid_RePayment
            // 
            this.dGrid_RePayment.AllowUserToAddRows = false;
            this.dGrid_RePayment.AllowUserToDeleteRows = false;
            this.dGrid_RePayment.AutoGenerateColumns = false;
            this.dGrid_RePayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid_RePayment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_RePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_RePayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.usuarioIdDataGridViewTextBoxColumn});
            this.dGrid_RePayment.DataSource = this.facturaVentaBindingSource;
            this.dGrid_RePayment.Location = new System.Drawing.Point(40, 203);
            this.dGrid_RePayment.Name = "dGrid_RePayment";
            this.dGrid_RePayment.ReadOnly = true;
            this.dGrid_RePayment.RowTemplate.Height = 24;
            this.dGrid_RePayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid_RePayment.Size = new System.Drawing.Size(600, 235);
            this.dGrid_RePayment.TabIndex = 13;
            this.dGrid_RePayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_RePayment_CellClick);
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
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Id";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "Cliente_Id";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Id";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "Usuario_Id";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            this.usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaVentaBindingSource
            // 
            this.facturaVentaBindingSource.DataMember = "Factura_Venta";
            this.facturaVentaBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Go
            // 
            this.btn_Go.BackColor = System.Drawing.Color.Transparent;
            this.btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Go.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_Go.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Go.Location = new System.Drawing.Point(279, 478);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(84, 32);
            this.btn_Go.TabIndex = 14;
            this.btn_Go.Text = "Ir";
            this.btn_Go.UseVisualStyleBackColor = false;
            this.btn_Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num. Factura:";
            // 
            // factura_VentaTableAdapter
            // 
            this.factura_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.dGrid_RePayment);
            this.Controls.Add(this.lklb_Search);
            this.Controls.Add(this.txt_NumFact);
            this.Controls.Add(this.panel1);
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_RePayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.TextBox txt_NumFact;
        private System.Windows.Forms.LinkLabel lklb_Search;
        private System.Windows.Forms.DataGridView dGrid_RePayment;
        private System.Windows.Forms.Button btn_Go;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource facturaVentaBindingSource;
        private MercaFacil_2DataSetTableAdapters.Factura_VentaTableAdapter factura_VentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}