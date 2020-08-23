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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchClients));
            this.grid_SearchClients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.txt_Client = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();
            this.btn_EditClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_SearchClients
            // 
            this.grid_SearchClients.AllowUserToAddRows = false;
            this.grid_SearchClients.AllowUserToDeleteRows = false;
            this.grid_SearchClients.AutoGenerateColumns = false;
            this.grid_SearchClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_SearchClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_SearchClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SearchClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroIdentificacionDataGridViewTextBoxColumn,
            this.tipoIdentificacionDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.dirBarrioDataGridViewTextBoxColumn,
            this.dirNumeroDataGridViewTextBoxColumn});
            this.grid_SearchClients.DataSource = this.clienteBindingSource;
            this.grid_SearchClients.Location = new System.Drawing.Point(70, 158);
            this.grid_SearchClients.Name = "grid_SearchClients";
            this.grid_SearchClients.ReadOnly = true;
            this.grid_SearchClients.RowTemplate.Height = 24;
            this.grid_SearchClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SearchClients.Size = new System.Drawing.Size(747, 229);
            this.grid_SearchClients.TabIndex = 5;
            this.grid_SearchClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SearchClients_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroIdentificacionDataGridViewTextBoxColumn
            // 
            this.numeroIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Numero_Identificacion";
            this.numeroIdentificacionDataGridViewTextBoxColumn.HeaderText = "Numero_Identificacion";
            this.numeroIdentificacionDataGridViewTextBoxColumn.Name = "numeroIdentificacionDataGridViewTextBoxColumn";
            this.numeroIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoIdentificacionDataGridViewTextBoxColumn
            // 
            this.tipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Identificacion";
            this.tipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo_Identificacion";
            this.tipoIdentificacionDataGridViewTextBoxColumn.Name = "tipoIdentificacionDataGridViewTextBoxColumn";
            this.tipoIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
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
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Client
            // 
            this.txt_Client.Location = new System.Drawing.Point(149, 114);
            this.txt_Client.Name = "txt_Client";
            this.txt_Client.Size = new System.Drawing.Size(500, 22);
            this.txt_Client.TabIndex = 3;
            this.txt_Client.TextChanged += new System.EventHandler(this.txt_Client_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(670, 117);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(52, 17);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Buscar";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btn_EditClient
            // 
            this.btn_EditClient.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditClient.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_EditClient.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EditClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EditClient.Location = new System.Drawing.Point(398, 411);
            this.btn_EditClient.Name = "btn_EditClient";
            this.btn_EditClient.Size = new System.Drawing.Size(84, 32);
            this.btn_EditClient.TabIndex = 6;
            this.btn_EditClient.Text = "Editar";
            this.btn_EditClient.UseVisualStyleBackColor = false;
            this.btn_EditClient.Click += new System.EventHandler(this.btn_EditClient_Click);
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
            this.label11.Location = new System.Drawing.Point(374, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 44);
            this.label11.TabIndex = 1;
            this.label11.Text = "Buscar";
            // 
            // SearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EditClient);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Client);
            this.Controls.Add(this.grid_SearchClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grid_SearchClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_SearchClients;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private MercaFacil_2DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Client;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_EditClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}