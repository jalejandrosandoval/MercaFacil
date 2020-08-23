namespace ParentForm
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.cmb_TypeIden = new System.Windows.Forms.ComboBox();
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Add_Telephone = new System.Windows.Forms.Button();
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
            this.label11.Size = new System.Drawing.Size(123, 44);
            this.label11.TabIndex = 1;
            this.label11.Text = "Clientes";
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Transparent;
            this.gb_Datos.Controls.Add(this.cmb_TypeIden);
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
            this.gb_Datos.Location = new System.Drawing.Point(79, 85);
            this.gb_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Size = new System.Drawing.Size(641, 319);
            this.gb_Datos.TabIndex = 20;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos";
            // 
            // cmb_TypeIden
            // 
            this.cmb_TypeIden.AutoCompleteCustomSource.AddRange(new string[] {
            "Cedula de ciudadania",
            "NIT"});
            this.cmb_TypeIden.FormattingEnabled = true;
            this.cmb_TypeIden.Items.AddRange(new object[] {
            "C.C",
            "C.E",
            "NIT"});
            this.cmb_TypeIden.Location = new System.Drawing.Point(196, 40);
            this.cmb_TypeIden.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TypeIden.Name = "cmb_TypeIden";
            this.cmb_TypeIden.Size = new System.Drawing.Size(336, 24);
            this.cmb_TypeIden.TabIndex = 21;
            this.cmb_TypeIden.Text = "Seleccione";
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
            this.txt_Identification.TabIndex = 22;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(196, 265);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(336, 22);
            this.txt_Address.TabIndex = 26;
            this.txt_Address.Tag = "";
            // 
            // txt_Neightborhood
            // 
            this.txt_Neightborhood.Location = new System.Drawing.Point(196, 220);
            this.txt_Neightborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Neightborhood.Name = "txt_Neightborhood";
            this.txt_Neightborhood.Size = new System.Drawing.Size(336, 22);
            this.txt_Neightborhood.TabIndex = 25;
            this.txt_Neightborhood.Tag = "";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(196, 175);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(336, 22);
            this.txt_LastName.TabIndex = 24;
            this.txt_LastName.Tag = "Apellidos";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(196, 130);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(336, 22);
            this.txt_FirstName.TabIndex = 23;
            this.txt_FirstName.Tag = "Apellidos";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_Create.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Create.Location = new System.Drawing.Point(346, 429);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(84, 32);
            this.btn_Create.TabIndex = 27;
            this.btn_Create.Text = "Crear";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Add_Telephone
            // 
            this.btn_Add_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_Telephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Telephone.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_Add_Telephone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Add_Telephone.Location = new System.Drawing.Point(527, 429);
            this.btn_Add_Telephone.Name = "btn_Add_Telephone";
            this.btn_Add_Telephone.Size = new System.Drawing.Size(249, 32);
            this.btn_Add_Telephone.TabIndex = 28;
            this.btn_Add_Telephone.Text = "Agregar Teléfono";
            this.btn_Add_Telephone.UseVisualStyleBackColor = false;
            this.btn_Add_Telephone.Click += new System.EventHandler(this.btn_Add_Telephone_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 493);
            this.Controls.Add(this.btn_Add_Telephone);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.panel1);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
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
        private System.Windows.Forms.ComboBox cmb_TypeIden;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Label lbl_Neightborhood;
        private System.Windows.Forms.Label lbl_IdentificationType;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txt_Identification;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Neightborhood;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Add_Telephone;
    }
}