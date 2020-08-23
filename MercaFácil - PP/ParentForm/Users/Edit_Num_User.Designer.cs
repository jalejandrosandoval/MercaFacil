namespace ParentForm
{
    partial class Edit_Num_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Num_User));
            this.btn_Delete_Telephone = new System.Windows.Forms.Button();
            this.grid_Telephones_Users = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.btn_Edit_Telephone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono_UsuarioTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Telephones_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Delete_Telephone
            // 
            this.btn_Delete_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Delete_Telephone.Location = new System.Drawing.Point(316, 444);
            this.btn_Delete_Telephone.Name = "btn_Delete_Telephone";
            this.btn_Delete_Telephone.Size = new System.Drawing.Size(90, 29);
            this.btn_Delete_Telephone.TabIndex = 20;
            this.btn_Delete_Telephone.Text = "Eliminar";
            this.btn_Delete_Telephone.UseVisualStyleBackColor = false;
            this.btn_Delete_Telephone.Click += new System.EventHandler(this.btn_Delete_Telephone_Click);
            // 
            // grid_Telephones_Users
            // 
            this.grid_Telephones_Users.AllowUserToAddRows = false;
            this.grid_Telephones_Users.AllowUserToDeleteRows = false;
            this.grid_Telephones_Users.AutoGenerateColumns = false;
            this.grid_Telephones_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Telephones_Users.BackgroundColor = System.Drawing.Color.White;
            this.grid_Telephones_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Telephones_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.grid_Telephones_Users.DataSource = this.telefonoUsuarioBindingSource;
            this.grid_Telephones_Users.Location = new System.Drawing.Point(107, 167);
            this.grid_Telephones_Users.Name = "grid_Telephones_Users";
            this.grid_Telephones_Users.ReadOnly = true;
            this.grid_Telephones_Users.RowTemplate.Height = 24;
            this.grid_Telephones_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Telephones_Users.Size = new System.Drawing.Size(331, 216);
            this.grid_Telephones_Users.TabIndex = 18;
            this.grid_Telephones_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Telephones_Users_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoUsuarioBindingSource
            // 
            this.telefonoUsuarioBindingSource.DataMember = "Telefono_Usuario";
            this.telefonoUsuarioBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Edit_Telephone
            // 
            this.btn_Edit_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Edit_Telephone.Location = new System.Drawing.Point(144, 444);
            this.btn_Edit_Telephone.Name = "btn_Edit_Telephone";
            this.btn_Edit_Telephone.Size = new System.Drawing.Size(90, 29);
            this.btn_Edit_Telephone.TabIndex = 19;
            this.btn_Edit_Telephone.Text = "Editar";
            this.btn_Edit_Telephone.UseVisualStyleBackColor = false;
            this.btn_Edit_Telephone.Click += new System.EventHandler(this.btn_Edit_Telephone_Click);
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
            this.panel1.TabIndex = 20;
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
            this.label1.Text = "Teléfonos";
            // 
            // telefono_UsuarioTableAdapter
            // 
            this.telefono_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Edit_Num_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Delete_Telephone);
            this.Controls.Add(this.grid_Telephones_Users);
            this.Controls.Add(this.btn_Edit_Telephone);
            this.Name = "Edit_Num_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Edit_Num_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Telephones_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete_Telephone;
        private System.Windows.Forms.DataGridView grid_Telephones_Users;
        private System.Windows.Forms.Button btn_Edit_Telephone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource telefonoUsuarioBindingSource;
        private MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter telefono_UsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
    }
}