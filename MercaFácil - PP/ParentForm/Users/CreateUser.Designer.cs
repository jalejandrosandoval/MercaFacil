namespace ParentForm
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.btn_create = new System.Windows.Forms.Button();
            this.tipo_UsuarioTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.Tipo_UsuarioTableAdapter();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.lbl_Neighborhood = new System.Windows.Forms.Label();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.cmb_UserType = new System.Windows.Forms.ComboBox();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.txt_Neighborhood = new System.Windows.Forms.TextBox();
            this.txt_Identification = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.btn_Add_Telephone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.gb_Datos.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(819, 68);
            this.panel1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(336, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 44);
            this.label11.TabIndex = 0;
            this.label11.Text = "Usuario";
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipoUsuarioBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_create.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_create.Location = new System.Drawing.Point(357, 586);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(84, 32);
            this.btn_create.TabIndex = 29;
            this.btn_create.Text = "Crear";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tipo_UsuarioTableAdapter
            // 
            this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Transparent;
            this.gb_Datos.Controls.Add(this.lbl_FirstName);
            this.gb_Datos.Controls.Add(this.lbl_User);
            this.gb_Datos.Controls.Add(this.lbl_Adress);
            this.gb_Datos.Controls.Add(this.lbl_Neighborhood);
            this.gb_Datos.Controls.Add(this.lbl_Identification);
            this.gb_Datos.Controls.Add(this.lbl_LastName);
            this.gb_Datos.Controls.Add(this.lbl_Birthdate);
            this.gb_Datos.Controls.Add(this.lbl_Password);
            this.gb_Datos.Controls.Add(this.cmb_UserType);
            this.gb_Datos.Controls.Add(this.lbl_UserType);
            this.gb_Datos.Controls.Add(this.txt_Password);
            this.gb_Datos.Controls.Add(this.txt_User);
            this.gb_Datos.Controls.Add(this.txt_FirstName);
            this.gb_Datos.Controls.Add(this.txt_Adress);
            this.gb_Datos.Controls.Add(this.txt_Neighborhood);
            this.gb_Datos.Controls.Add(this.txt_Identification);
            this.gb_Datos.Controls.Add(this.txt_LastName);
            this.gb_Datos.Controls.Add(this.dtp_Birthdate);
            this.gb_Datos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.gb_Datos.Location = new System.Drawing.Point(80, 102);
            this.gb_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Size = new System.Drawing.Size(648, 463);
            this.gb_Datos.TabIndex = 20;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FirstName.Location = new System.Drawing.Point(63, 85);
            this.lbl_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(69, 17);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "Nombres:";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_User.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_User.Location = new System.Drawing.Point(63, 356);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(61, 17);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "Usuario:";
            // 
            // lbl_Adress
            // 
            this.lbl_Adress.AutoSize = true;
            this.lbl_Adress.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Adress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Adress.Location = new System.Drawing.Point(63, 265);
            this.lbl_Adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adress.Name = "lbl_Adress";
            this.lbl_Adress.Size = new System.Drawing.Size(71, 17);
            this.lbl_Adress.TabIndex = 2;
            this.lbl_Adress.Text = "Direccion:";
            // 
            // lbl_Neighborhood
            // 
            this.lbl_Neighborhood.AutoSize = true;
            this.lbl_Neighborhood.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Neighborhood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Neighborhood.Location = new System.Drawing.Point(63, 220);
            this.lbl_Neighborhood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Neighborhood.Name = "lbl_Neighborhood";
            this.lbl_Neighborhood.Size = new System.Drawing.Size(50, 17);
            this.lbl_Neighborhood.TabIndex = 2;
            this.lbl_Neighborhood.Text = "Barrio:";
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Identification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Identification.Location = new System.Drawing.Point(63, 40);
            this.lbl_Identification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(94, 17);
            this.lbl_Identification.TabIndex = 2;
            this.lbl_Identification.Text = "Identificación:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_LastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LastName.Location = new System.Drawing.Point(63, 130);
            this.lbl_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(69, 17);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Apellidos:";
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Birthdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Birthdate.Location = new System.Drawing.Point(63, 175);
            this.lbl_Birthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(80, 17);
            this.lbl_Birthdate.TabIndex = 3;
            this.lbl_Birthdate.Text = "Fecha Nac:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Password.Location = new System.Drawing.Point(63, 401);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(85, 17);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Contraseña:";
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.DataSource = this.tipoUsuarioBindingSource;
            this.cmb_UserType.DisplayMember = "Tipo_Usuario";
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Location = new System.Drawing.Point(196, 310);
            this.cmb_UserType.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(248, 24);
            this.cmb_UserType.TabIndex = 26;
            this.cmb_UserType.ValueMember = "Id";
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_UserType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_UserType.Location = new System.Drawing.Point(63, 310);
            this.lbl_UserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(93, 17);
            this.lbl_UserType.TabIndex = 2;
            this.lbl_UserType.Text = "Tipo Usuario:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(196, 401);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(336, 22);
            this.txt_Password.TabIndex = 28;
            this.txt_Password.Tag = "Apellidos";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(196, 356);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(336, 22);
            this.txt_User.TabIndex = 27;
            this.txt_User.Tag = "Apellidos";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(196, 85);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(336, 22);
            this.txt_FirstName.TabIndex = 21;
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(196, 265);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(336, 22);
            this.txt_Adress.TabIndex = 25;
            this.txt_Adress.Tag = "Apellidos";
            // 
            // txt_Neighborhood
            // 
            this.txt_Neighborhood.Location = new System.Drawing.Point(196, 220);
            this.txt_Neighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Neighborhood.Name = "txt_Neighborhood";
            this.txt_Neighborhood.Size = new System.Drawing.Size(336, 22);
            this.txt_Neighborhood.TabIndex = 24;
            this.txt_Neighborhood.Tag = "Apellidos";
            // 
            // txt_Identification
            // 
            this.txt_Identification.Location = new System.Drawing.Point(196, 40);
            this.txt_Identification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Identification.Name = "txt_Identification";
            this.txt_Identification.Size = new System.Drawing.Size(336, 22);
            this.txt_Identification.TabIndex = 5;
            this.txt_Identification.Tag = "Apellidos";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(196, 130);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(336, 22);
            this.txt_LastName.TabIndex = 22;
            this.txt_LastName.Tag = "Apellidos";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Birthdate.Location = new System.Drawing.Point(196, 175);
            this.dtp_Birthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(253, 22);
            this.dtp_Birthdate.TabIndex = 23;
            // 
            // btn_Add_Telephone
            // 
            this.btn_Add_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_Add_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Add_Telephone.Location = new System.Drawing.Point(479, 586);
            this.btn_Add_Telephone.Name = "btn_Add_Telephone";
            this.btn_Add_Telephone.Size = new System.Drawing.Size(249, 32);
            this.btn_Add_Telephone.TabIndex = 30;
            this.btn_Add_Telephone.Text = "Agregar Teléfono";
            this.btn_Add_Telephone.UseVisualStyleBackColor = false;
            this.btn_Add_Telephone.Click += new System.EventHandler(this.btn_Add_Telephone_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 639);
            this.Controls.Add(this.btn_Add_Telephone);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_create;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private MercaFacil_2DataSetTableAdapters.Tipo_UsuarioTableAdapter tipo_UsuarioTableAdapter;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Label lbl_Neighborhood;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.TextBox txt_Neighborhood;
        private System.Windows.Forms.TextBox txt_Identification;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_Add_Telephone;
    }
}