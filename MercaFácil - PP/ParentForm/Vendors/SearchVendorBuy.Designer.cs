namespace ParentForm
{
    partial class SearchVendorBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVendorBuy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_SelectProvider = new System.Windows.Forms.Button();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_Provider = new System.Windows.Forms.TextBox();
            this.grid_SearchVendors = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.proveedorTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 29;
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
            // btn_SelectProvider
            // 
            this.btn_SelectProvider.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectProvider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SelectProvider.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_SelectProvider.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_SelectProvider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SelectProvider.Location = new System.Drawing.Point(366, 404);
            this.btn_SelectProvider.Name = "btn_SelectProvider";
            this.btn_SelectProvider.Size = new System.Drawing.Size(135, 32);
            this.btn_SelectProvider.TabIndex = 33;
            this.btn_SelectProvider.Text = "Seleccionar";
            this.btn_SelectProvider.UseVisualStyleBackColor = false;
            this.btn_SelectProvider.Click += new System.EventHandler(this.btn_SelectProvider_Click);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(675, 112);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(52, 17);
            this.lbl_Search.TabIndex = 32;
            this.lbl_Search.Text = "Buscar";
            // 
            // txt_Provider
            // 
            this.txt_Provider.Location = new System.Drawing.Point(154, 109);
            this.txt_Provider.Name = "txt_Provider";
            this.txt_Provider.Size = new System.Drawing.Size(500, 22);
            this.txt_Provider.TabIndex = 31;
            this.txt_Provider.TextChanged += new System.EventHandler(this.txt_Provider_TextChanged);
            // 
            // grid_SearchVendors
            // 
            this.grid_SearchVendors.AllowUserToAddRows = false;
            this.grid_SearchVendors.AllowUserToDeleteRows = false;
            this.grid_SearchVendors.AutoGenerateColumns = false;
            this.grid_SearchVendors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_SearchVendors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_SearchVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SearchVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dirBarrioDataGridViewTextBoxColumn,
            this.dirNumeroDataGridViewTextBoxColumn});
            this.grid_SearchVendors.DataSource = this.proveedorBindingSource;
            this.grid_SearchVendors.Location = new System.Drawing.Point(114, 153);
            this.grid_SearchVendors.Name = "grid_SearchVendors";
            this.grid_SearchVendors.ReadOnly = true;
            this.grid_SearchVendors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grid_SearchVendors.RowTemplate.Height = 24;
            this.grid_SearchVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SearchVendors.Size = new System.Drawing.Size(649, 229);
            this.grid_SearchVendors.TabIndex = 32;
            this.grid_SearchVendors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SearchVendors_CellClick);
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
            // SearchVendorBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 461);
            this.Controls.Add(this.btn_SelectProvider);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Provider);
            this.Controls.Add(this.grid_SearchVendors);
            this.Controls.Add(this.panel1);
            this.Name = "SearchVendorBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchVendorBuy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_SelectProvider;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Provider;
        private System.Windows.Forms.DataGridView grid_SearchVendors;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirNumeroDataGridViewTextBoxColumn;
    }
}