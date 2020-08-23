namespace ParentForm
{
    partial class DeleteUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUsers));
            this.grid_DeleteUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.lbl_Search1 = new System.Windows.Forms.Label();
            this.txt_Users = new System.Windows.Forms.TextBox();
            this.usuarioTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DeleteUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_DeleteUsers
            // 
            this.grid_DeleteUsers.AllowUserToAddRows = false;
            this.grid_DeleteUsers.AllowUserToDeleteRows = false;
            this.grid_DeleteUsers.AutoGenerateColumns = false;
            this.grid_DeleteUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_DeleteUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DeleteUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.numeroIdentificacionDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.tipoUsuarioDataGridViewTextBoxColumn,
            this.dirBarrioDataGridViewTextBoxColumn,
            this.dirNumeroDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.borradoDataGridViewTextBoxColumn});
            this.grid_DeleteUsers.DataSource = this.usuarioBindingSource;
            this.grid_DeleteUsers.Location = new System.Drawing.Point(61, 161);
            this.grid_DeleteUsers.Name = "grid_DeleteUsers";
            this.grid_DeleteUsers.ReadOnly = true;
            this.grid_DeleteUsers.RowTemplate.Height = 24;
            this.grid_DeleteUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DeleteUsers.Size = new System.Drawing.Size(747, 229);
            this.grid_DeleteUsers.TabIndex = 28;
            this.grid_DeleteUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DeleteUsers_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // numeroIdentificacionDataGridViewTextBoxColumn
            // 
            this.numeroIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Numero_Identificacion";
            this.numeroIdentificacionDataGridViewTextBoxColumn.HeaderText = "Numero_Identificacion";
            this.numeroIdentificacionDataGridViewTextBoxColumn.Name = "numeroIdentificacionDataGridViewTextBoxColumn";
            this.numeroIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            this.contrasenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoUsuarioDataGridViewTextBoxColumn
            // 
            this.tipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Usuario";
            this.tipoUsuarioDataGridViewTextBoxColumn.HeaderText = "Tipo_Usuario";
            this.tipoUsuarioDataGridViewTextBoxColumn.Name = "tipoUsuarioDataGridViewTextBoxColumn";
            this.tipoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha_Creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borradoDataGridViewTextBoxColumn
            // 
            this.borradoDataGridViewTextBoxColumn.DataPropertyName = "Borrado";
            this.borradoDataGridViewTextBoxColumn.HeaderText = "Borrado";
            this.borradoDataGridViewTextBoxColumn.Name = "borradoDataGridViewTextBoxColumn";
            this.borradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_DeleteUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DeleteUser.Location = new System.Drawing.Point(383, 411);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(100, 32);
            this.btn_DeleteUser.TabIndex = 29;
            this.btn_DeleteUser.Text = "Eliminar";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // lbl_Search1
            // 
            this.lbl_Search1.AutoSize = true;
            this.lbl_Search1.Location = new System.Drawing.Point(660, 120);
            this.lbl_Search1.Name = "lbl_Search1";
            this.lbl_Search1.Size = new System.Drawing.Size(52, 17);
            this.lbl_Search1.TabIndex = 28;
            this.lbl_Search1.Text = "Buscar";
            // 
            // txt_Users
            // 
            this.txt_Users.Location = new System.Drawing.Point(139, 117);
            this.txt_Users.Name = "txt_Users";
            this.txt_Users.Size = new System.Drawing.Size(500, 22);
            this.txt_Users.TabIndex = 27;
            this.txt_Users.TextChanged += new System.EventHandler(this.txt_Users_TextChanged);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            this.panel1.TabIndex = 31;
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
            // DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_DeleteUsers);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.lbl_Search1);
            this.Controls.Add(this.txt_Users);
            this.Name = "DeleteUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grid_DeleteUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_DeleteUsers;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Label lbl_Search1;
        private System.Windows.Forms.TextBox txt_Users;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}