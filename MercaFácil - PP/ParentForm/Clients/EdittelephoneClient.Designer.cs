namespace ParentForm
{
    partial class EdittelephoneClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdittelephoneClient));
            this.btn_Edit_Telephone = new System.Windows.Forms.Button();
            this.grid_Telephones_Clients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.telefono_ClienteTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter();
            this.btn_Delete_Telephone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Telephones_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Edit_Telephone
            // 
            this.btn_Edit_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Edit_Telephone.Location = new System.Drawing.Point(147, 433);
            this.btn_Edit_Telephone.Name = "btn_Edit_Telephone";
            this.btn_Edit_Telephone.Size = new System.Drawing.Size(90, 29);
            this.btn_Edit_Telephone.TabIndex = 11;
            this.btn_Edit_Telephone.Text = "Editar";
            this.btn_Edit_Telephone.UseVisualStyleBackColor = false;
            this.btn_Edit_Telephone.Click += new System.EventHandler(this.btn_Edit_Telephone_Click);
            // 
            // grid_Telephones_Clients
            // 
            this.grid_Telephones_Clients.AllowUserToAddRows = false;
            this.grid_Telephones_Clients.AllowUserToDeleteRows = false;
            this.grid_Telephones_Clients.AutoGenerateColumns = false;
            this.grid_Telephones_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Telephones_Clients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_Telephones_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Telephones_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.grid_Telephones_Clients.DataSource = this.telefonoClienteBindingSource;
            this.grid_Telephones_Clients.Location = new System.Drawing.Point(54, 109);
            this.grid_Telephones_Clients.Name = "grid_Telephones_Clients";
            this.grid_Telephones_Clients.ReadOnly = true;
            this.grid_Telephones_Clients.RowTemplate.Height = 24;
            this.grid_Telephones_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Telephones_Clients.Size = new System.Drawing.Size(445, 288);
            this.grid_Telephones_Clients.TabIndex = 10;
            this.grid_Telephones_Clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Telephones_Clients_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoClienteBindingSource
            // 
            this.telefonoClienteBindingSource.DataMember = "Telefono_Cliente";
            this.telefonoClienteBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefono_ClienteTableAdapter
            // 
            this.telefono_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Delete_Telephone
            // 
            this.btn_Delete_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Delete_Telephone.Location = new System.Drawing.Point(319, 433);
            this.btn_Delete_Telephone.Name = "btn_Delete_Telephone";
            this.btn_Delete_Telephone.Size = new System.Drawing.Size(90, 29);
            this.btn_Delete_Telephone.TabIndex = 12;
            this.btn_Delete_Telephone.Text = "Eliminar";
            this.btn_Delete_Telephone.UseVisualStyleBackColor = false;
            this.btn_Delete_Telephone.Click += new System.EventHandler(this.btn_Delete_Telephone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 72);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Telefonos";
            // 
            // EdittelephoneClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Delete_Telephone);
            this.Controls.Add(this.grid_Telephones_Clients);
            this.Controls.Add(this.btn_Edit_Telephone);
            this.Name = "EdittelephoneClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ue ";
            this.Load += new System.EventHandler(this.EdittelephoneClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Telephones_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit_Telephone;
        private System.Windows.Forms.DataGridView grid_Telephones_Clients;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter telefono_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Delete_Telephone;
        public System.Windows.Forms.BindingSource telefonoClienteBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}