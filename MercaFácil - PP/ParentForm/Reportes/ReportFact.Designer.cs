namespace ParentForm
{
    partial class ReportFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFact));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.btn_ShowFactu = new System.Windows.Forms.Button();
            this.dataSetMultiplesTablas = new ParentForm.DataSetMultiplesTablas();
            this.facturaMultipleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_MultipleTableAdapter = new ParentForm.DataSetMultiplesTablasTableAdapters.Factura_MultipleTableAdapter();
            this.numeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMultiplesTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaMultipleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.usuarioNombresDataGridViewTextBoxColumn,
            this.usuarioApellidosDataGridViewTextBoxColumn,
            this.clienteNombresDataGridViewTextBoxColumn,
            this.clienteApellidosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturaMultipleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 57);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(419, 9);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(130, 44);
            this.lbl_Ventas.TabIndex = 4;
            this.lbl_Ventas.Text = "Facturas";
            // 
            // btn_ShowFactu
            // 
            this.btn_ShowFactu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowFactu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowFactu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShowFactu.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_ShowFactu.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_ShowFactu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ShowFactu.Location = new System.Drawing.Point(455, 521);
            this.btn_ShowFactu.Name = "btn_ShowFactu";
            this.btn_ShowFactu.Size = new System.Drawing.Size(94, 32);
            this.btn_ShowFactu.TabIndex = 7;
            this.btn_ShowFactu.Text = "Mostrar";
            this.btn_ShowFactu.UseVisualStyleBackColor = false;
            this.btn_ShowFactu.Click += new System.EventHandler(this.btn_ShowFactu_Click);
            // 
            // dataSetMultiplesTablas
            // 
            this.dataSetMultiplesTablas.DataSetName = "DataSetMultiplesTablas";
            this.dataSetMultiplesTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaMultipleBindingSource
            // 
            this.facturaMultipleBindingSource.DataMember = "Factura_Multiple";
            this.facturaMultipleBindingSource.DataSource = this.dataSetMultiplesTablas;
            // 
            // factura_MultipleTableAdapter
            // 
            this.factura_MultipleTableAdapter.ClearBeforeFill = true;
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
            // usuarioNombresDataGridViewTextBoxColumn
            // 
            this.usuarioNombresDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Nombres";
            this.usuarioNombresDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.usuarioNombresDataGridViewTextBoxColumn.Name = "usuarioNombresDataGridViewTextBoxColumn";
            this.usuarioNombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioApellidosDataGridViewTextBoxColumn
            // 
            this.usuarioApellidosDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Apellidos";
            this.usuarioApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.usuarioApellidosDataGridViewTextBoxColumn.Name = "usuarioApellidosDataGridViewTextBoxColumn";
            this.usuarioApellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteNombresDataGridViewTextBoxColumn
            // 
            this.clienteNombresDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Nombres";
            this.clienteNombresDataGridViewTextBoxColumn.HeaderText = "Nombres Cliente";
            this.clienteNombresDataGridViewTextBoxColumn.Name = "clienteNombresDataGridViewTextBoxColumn";
            this.clienteNombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteApellidosDataGridViewTextBoxColumn
            // 
            this.clienteApellidosDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Apellidos";
            this.clienteApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos Cliente";
            this.clienteApellidosDataGridViewTextBoxColumn.Name = "clienteApellidosDataGridViewTextBoxColumn";
            this.clienteApellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 578);
            this.Controls.Add(this.btn_ShowFactu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportFact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFact";
            this.Load += new System.EventHandler(this.ReportFact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMultiplesTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaMultipleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Button btn_ShowFactu;
        private DataSetMultiplesTablas dataSetMultiplesTablas;
        private System.Windows.Forms.BindingSource facturaMultipleBindingSource;
        private DataSetMultiplesTablasTableAdapters.Factura_MultipleTableAdapter factura_MultipleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteApellidosDataGridViewTextBoxColumn;
    }
}