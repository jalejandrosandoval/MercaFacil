namespace ParentForm
{
    partial class p_ParamFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(p_ParamFact));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_ShowFactu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetMultiplesTablas = new ParentForm.DataSetMultiplesTablas();
            this.facturaMultipleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_MultipleTableAdapter = new ParentForm.DataSetMultiplesTablasTableAdapters.Factura_MultipleTableAdapter();
            this.numeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMultiplesTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaMultipleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 57);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(367, 9);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(119, 44);
            this.lbl_Ventas.TabIndex = 4;
            this.lbl_Ventas.Text = "Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(177, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(193, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(420, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btn_ShowFactu
            // 
            this.btn_ShowFactu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowFactu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowFactu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShowFactu.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_ShowFactu.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_ShowFactu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ShowFactu.Location = new System.Drawing.Point(401, 732);
            this.btn_ShowFactu.Name = "btn_ShowFactu";
            this.btn_ShowFactu.Size = new System.Drawing.Size(94, 32);
            this.btn_ShowFactu.TabIndex = 8;
            this.btn_ShowFactu.Text = "Mostrar";
            this.btn_ShowFactu.UseVisualStyleBackColor = false;
            this.btn_ShowFactu.Click += new System.EventHandler(this.btn_ShowFactu_Click);
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
            this.anotacionDataGridViewTextBoxColumn,
            this.usuarioNombresDataGridViewTextBoxColumn,
            this.usuarioApellidosDataGridViewTextBoxColumn,
            this.clienteNombresDataGridViewTextBoxColumn,
            this.clienteApellidosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturaMultipleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 412);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_search.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_search.Location = new System.Drawing.Point(420, 218);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 32);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Mostrar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // p_ParamFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 788);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ShowFactu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "p_ParamFact";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMultiplesTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaMultipleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_ShowFactu;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btn_search;
    }
}