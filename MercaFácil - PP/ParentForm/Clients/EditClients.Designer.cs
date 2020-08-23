namespace ParentForm
{
    partial class OptionsClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.lkl_Search = new System.Windows.Forms.LinkLabel();
            this.cmb_TypeIdentification = new System.Windows.Forms.ComboBox();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.lbl_Neightborhood = new System.Windows.Forms.Label();
            this.lbl_IdentificationType = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.txt_Identification = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Neightborhood = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.btn_EditClient = new System.Windows.Forms.Button();
            this.btn_Edit_Telephone = new System.Windows.Forms.Button();
            this.btn_AddTel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 18;
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
            this.label11.Size = new System.Drawing.Size(123, 44);
            this.label11.TabIndex = 1;
            this.label11.Text = "Clientes";
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Transparent;
            this.gb_Datos.Controls.Add(this.lkl_Search);
            this.gb_Datos.Controls.Add(this.cmb_TypeIdentification);
            this.gb_Datos.Controls.Add(this.lbl_Identification);
            this.gb_Datos.Controls.Add(this.lbl_Adress);
            this.gb_Datos.Controls.Add(this.lbl_Neightborhood);
            this.gb_Datos.Controls.Add(this.lbl_IdentificationType);
            this.gb_Datos.Controls.Add(this.lbl_FirstName);
            this.gb_Datos.Controls.Add(this.lbl_LastName);
            this.gb_Datos.Controls.Add(this.txt_Identification);
            this.gb_Datos.Controls.Add(this.txt_Address);
            this.gb_Datos.Controls.Add(this.txt_Neightborhood);
            this.gb_Datos.Controls.Add(this.txt_LastName);
            this.gb_Datos.Controls.Add(this.txt_FirstName);
            this.gb_Datos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.gb_Datos.Location = new System.Drawing.Point(85, 111);
            this.gb_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Size = new System.Drawing.Size(648, 357);
            this.gb_Datos.TabIndex = 19;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos";
            // 
            // lkl_Search
            // 
            this.lkl_Search.AutoSize = true;
            this.lkl_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkl_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lkl_Search.LinkColor = System.Drawing.Color.Snow;
            this.lkl_Search.Location = new System.Drawing.Point(559, 40);
            this.lkl_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkl_Search.Name = "lkl_Search";
            this.lkl_Search.Size = new System.Drawing.Size(52, 17);
            this.lkl_Search.TabIndex = 22;
            this.lkl_Search.TabStop = true;
            this.lkl_Search.Text = "Buscar";
            this.lkl_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_Search_LinkClicked);
            // 
            // cmb_TypeIdentification
            // 
            this.cmb_TypeIdentification.AutoCompleteCustomSource.AddRange(new string[] {
            "Cedula de ciudadania",
            "NIT"});
            this.cmb_TypeIdentification.FormattingEnabled = true;
            this.cmb_TypeIdentification.Items.AddRange(new object[] {
            "Cedula de ciudadania",
            "NIT"});
            this.cmb_TypeIdentification.Location = new System.Drawing.Point(196, 40);
            this.cmb_TypeIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TypeIdentification.Name = "cmb_TypeIdentification";
            this.cmb_TypeIdentification.Size = new System.Drawing.Size(219, 24);
            this.cmb_TypeIdentification.TabIndex = 21;
            this.cmb_TypeIdentification.Text = "Seleccione";
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Identification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Identification.Location = new System.Drawing.Point(63, 85);
            this.lbl_Identification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(94, 17);
            this.lbl_Identification.TabIndex = 1;
            this.lbl_Identification.Text = "Identificación:";
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
            this.lbl_Adress.Text = "Dirección:";
            // 
            // lbl_Neightborhood
            // 
            this.lbl_Neightborhood.AutoSize = true;
            this.lbl_Neightborhood.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Neightborhood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Neightborhood.Location = new System.Drawing.Point(63, 220);
            this.lbl_Neightborhood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Neightborhood.Name = "lbl_Neightborhood";
            this.lbl_Neightborhood.Size = new System.Drawing.Size(50, 17);
            this.lbl_Neightborhood.TabIndex = 2;
            this.lbl_Neightborhood.Text = "Barrio:";
            // 
            // lbl_IdentificationType
            // 
            this.lbl_IdentificationType.AutoSize = true;
            this.lbl_IdentificationType.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_IdentificationType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_IdentificationType.Location = new System.Drawing.Point(63, 40);
            this.lbl_IdentificationType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdentificationType.Name = "lbl_IdentificationType";
            this.lbl_IdentificationType.Size = new System.Drawing.Size(126, 17);
            this.lbl_IdentificationType.TabIndex = 2;
            this.lbl_IdentificationType.Text = "Tipo Identificación:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FirstName.Location = new System.Drawing.Point(63, 130);
            this.lbl_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(62, 17);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "Nombre:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_LastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LastName.Location = new System.Drawing.Point(63, 175);
            this.lbl_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(66, 17);
            this.lbl_LastName.TabIndex = 3;
            this.lbl_LastName.Text = "Apellido: ";
            // 
            // txt_Identification
            // 
            this.txt_Identification.Location = new System.Drawing.Point(196, 85);
            this.txt_Identification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Identification.Name = "txt_Identification";
            this.txt_Identification.Size = new System.Drawing.Size(336, 22);
            this.txt_Identification.TabIndex = 23;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(196, 265);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(336, 22);
            this.txt_Address.TabIndex = 27;
            this.txt_Address.Tag = "";
            // 
            // txt_Neightborhood
            // 
            this.txt_Neightborhood.Location = new System.Drawing.Point(196, 220);
            this.txt_Neightborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Neightborhood.Name = "txt_Neightborhood";
            this.txt_Neightborhood.Size = new System.Drawing.Size(336, 22);
            this.txt_Neightborhood.TabIndex = 26;
            this.txt_Neightborhood.Tag = "";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(196, 175);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(336, 22);
            this.txt_LastName.TabIndex = 25;
            this.txt_LastName.Tag = "Apellidos";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(196, 130);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(336, 22);
            this.txt_FirstName.TabIndex = 24;
            this.txt_FirstName.Tag = "Apellidos";
            // 
            // btn_EditClient
            // 
            this.btn_EditClient.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditClient.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_EditClient.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EditClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EditClient.Location = new System.Drawing.Point(368, 483);
            this.btn_EditClient.Name = "btn_EditClient";
            this.btn_EditClient.Size = new System.Drawing.Size(84, 32);
            this.btn_EditClient.TabIndex = 28;
            this.btn_EditClient.Text = "Editar";
            this.btn_EditClient.UseVisualStyleBackColor = false;
            this.btn_EditClient.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_Edit_Telephone
            // 
            this.btn_Edit_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_Edit_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Edit_Telephone.Location = new System.Drawing.Point(484, 475);
            this.btn_Edit_Telephone.Name = "btn_Edit_Telephone";
            this.btn_Edit_Telephone.Size = new System.Drawing.Size(249, 48);
            this.btn_Edit_Telephone.TabIndex = 30;
            this.btn_Edit_Telephone.Text = "Editar Teléfono";
            this.btn_Edit_Telephone.UseVisualStyleBackColor = false;
            this.btn_Edit_Telephone.Click += new System.EventHandler(this.btn_Edit_Telephone_Click);
            // 
            // btn_AddTel
            // 
            this.btn_AddTel.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddTel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddTel.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_AddTel.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddTel.Location = new System.Drawing.Point(85, 475);
            this.btn_AddTel.Name = "btn_AddTel";
            this.btn_AddTel.Size = new System.Drawing.Size(249, 48);
            this.btn_AddTel.TabIndex = 29;
            this.btn_AddTel.Text = "Agregar Teléfono";
            this.btn_AddTel.UseVisualStyleBackColor = false;
            this.btn_AddTel.Click += new System.EventHandler(this.btn_AddTel_Click);
            // 
            // OptionsClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 553);
            this.Controls.Add(this.btn_AddTel);
            this.Controls.Add(this.btn_Edit_Telephone);
            this.Controls.Add(this.btn_EditClient);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Label lbl_Neightborhood;
        private System.Windows.Forms.Label lbl_IdentificationType;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.LinkLabel lkl_Search;
        private System.Windows.Forms.Button btn_EditClient;
        public System.Windows.Forms.TextBox txt_Identification;
        public System.Windows.Forms.TextBox txt_Address;
        public System.Windows.Forms.TextBox txt_Neightborhood;
        public System.Windows.Forms.TextBox txt_FirstName;
        public System.Windows.Forms.TextBox txt_LastName;
        public System.Windows.Forms.ComboBox cmb_TypeIdentification;
        private System.Windows.Forms.Button btn_Edit_Telephone;
        private System.Windows.Forms.Button btn_AddTel;
    }
}