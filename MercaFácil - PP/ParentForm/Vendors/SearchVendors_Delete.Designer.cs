namespace ParentForm
{
    partial class SearchVendors_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVendors_Delete));
            this.btn_EditProvider1 = new System.Windows.Forms.Button();
            this.lbl_Search1 = new System.Windows.Forms.Label();
            this.txt_Provider1 = new System.Windows.Forms.TextBox();
            this.grid_SearchVendors1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.proveedorTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchVendors1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_EditProvider1
            // 
            this.btn_EditProvider1.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditProvider1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditProvider1.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_EditProvider1.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EditProvider1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EditProvider1.Location = new System.Drawing.Point(390, 410);
            this.btn_EditProvider1.Name = "btn_EditProvider1";
            this.btn_EditProvider1.Size = new System.Drawing.Size(84, 32);
            this.btn_EditProvider1.TabIndex = 26;
            this.btn_EditProvider1.Text = "Borrar";
            this.btn_EditProvider1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditProvider1.UseVisualStyleBackColor = false;
            this.btn_EditProvider1.Click += new System.EventHandler(this.btn_EditProvider1_Click);
            // 
            // lbl_Search1
            // 
            this.lbl_Search1.AutoSize = true;
            this.lbl_Search1.Location = new System.Drawing.Point(662, 128);
            this.lbl_Search1.Name = "lbl_Search1";
            this.lbl_Search1.Size = new System.Drawing.Size(52, 17);
            this.lbl_Search1.TabIndex = 25;
            this.lbl_Search1.Text = "Buscar";
            // 
            // txt_Provider1
            // 
            this.txt_Provider1.Location = new System.Drawing.Point(141, 125);
            this.txt_Provider1.Name = "txt_Provider1";
            this.txt_Provider1.Size = new System.Drawing.Size(500, 22);
            this.txt_Provider1.TabIndex = 24;
            this.txt_Provider1.TextChanged += new System.EventHandler(this.txt_Provider1_TextChanged);
            // 
            // grid_SearchVendors1
            // 
            this.grid_SearchVendors1.AllowUserToAddRows = false;
            this.grid_SearchVendors1.AllowUserToDeleteRows = false;
            this.grid_SearchVendors1.AutoGenerateColumns = false;
            this.grid_SearchVendors1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_SearchVendors1.BackgroundColor = System.Drawing.Color.White;
            this.grid_SearchVendors1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SearchVendors1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dirBarrioDataGridViewTextBoxColumn,
            this.dirNumeroDataGridViewTextBoxColumn,
            this.borradoDataGridViewTextBoxColumn});
            this.grid_SearchVendors1.DataSource = this.proveedorBindingSource;
            this.grid_SearchVendors1.Location = new System.Drawing.Point(79, 166);
            this.grid_SearchVendors1.Name = "grid_SearchVendors1";
            this.grid_SearchVendors1.ReadOnly = true;
            this.grid_SearchVendors1.RowTemplate.Height = 24;
            this.grid_SearchVendors1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SearchVendors1.Size = new System.Drawing.Size(696, 229);
            this.grid_SearchVendors1.TabIndex = 23;
            this.grid_SearchVendors1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SearchVendors1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirBarrioDataGridViewTextBoxColumn
            // 
            this.dirBarrioDataGridViewTextBoxColumn.DataPropertyName = "Dir_Barrio";
            this.dirBarrioDataGridViewTextBoxColumn.HeaderText = "Dir_Barrio";
            this.dirBarrioDataGridViewTextBoxColumn.Name = "dirBarrioDataGridViewTextBoxColumn";
            this.dirBarrioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirNumeroDataGridViewTextBoxColumn
            // 
            this.dirNumeroDataGridViewTextBoxColumn.DataPropertyName = "Dir_Numero";
            this.dirNumeroDataGridViewTextBoxColumn.HeaderText = "Dir_Numero";
            this.dirNumeroDataGridViewTextBoxColumn.Name = "dirNumeroDataGridViewTextBoxColumn";
            this.dirNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borradoDataGridViewTextBoxColumn
            // 
            this.borradoDataGridViewTextBoxColumn.DataPropertyName = "Borrado";
            this.borradoDataGridViewTextBoxColumn.HeaderText = "Borrado";
            this.borradoDataGridViewTextBoxColumn.Name = "borradoDataGridViewTextBoxColumn";
            this.borradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
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
            this.label11.Size = new System.Drawing.Size(105, 44);
            this.label11.TabIndex = 1;
            this.label11.Text = "Borrar";
            // 
            // SearchVendors_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EditProvider1);
            this.Controls.Add(this.lbl_Search1);
            this.Controls.Add(this.txt_Provider1);
            this.Controls.Add(this.grid_SearchVendors1);
            this.Name = "SearchVendors_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchVendors1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditProvider1;
        private System.Windows.Forms.Label lbl_Search1;
        private System.Windows.Forms.TextBox txt_Provider1;
        private System.Windows.Forms.DataGridView grid_SearchVendors1;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}