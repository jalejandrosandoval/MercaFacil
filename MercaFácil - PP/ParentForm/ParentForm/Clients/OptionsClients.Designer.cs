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
            this.cmb_TypeProduct = new System.Windows.Forms.ComboBox();
            this.lklb_Search = new System.Windows.Forms.LinkLabel();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.txt_Debt = new System.Windows.Forms.TextBox();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.lbl_Neightborhood = new System.Windows.Forms.Label();
            this.lbl_IdentificationType = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Debt = new System.Windows.Forms.Label();
            this.txt_Identification = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.txt_Neightborhood = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb_Datos.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gb_Datos.Controls.Add(this.cmb_TypeProduct);
            this.gb_Datos.Controls.Add(this.lklb_Search);
            this.gb_Datos.Controls.Add(this.lbl_Identification);
            this.gb_Datos.Controls.Add(this.txt_Debt);
            this.gb_Datos.Controls.Add(this.lbl_Adress);
            this.gb_Datos.Controls.Add(this.lbl_Neightborhood);
            this.gb_Datos.Controls.Add(this.lbl_IdentificationType);
            this.gb_Datos.Controls.Add(this.lbl_FirstName);
            this.gb_Datos.Controls.Add(this.lbl_LastName);
            this.gb_Datos.Controls.Add(this.lbl_Debt);
            this.gb_Datos.Controls.Add(this.txt_Identification);
            this.gb_Datos.Controls.Add(this.txt_Adress);
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
            // cmb_TypeProduct
            // 
            this.cmb_TypeProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "Cedula de ciudadania",
            "NIT"});
            this.cmb_TypeProduct.FormattingEnabled = true;
            this.cmb_TypeProduct.Items.AddRange(new object[] {
            "Cedula de ciudadania",
            "NIT"});
            this.cmb_TypeProduct.Location = new System.Drawing.Point(196, 40);
            this.cmb_TypeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TypeProduct.Name = "cmb_TypeProduct";
            this.cmb_TypeProduct.Size = new System.Drawing.Size(219, 24);
            this.cmb_TypeProduct.TabIndex = 21;
            this.cmb_TypeProduct.Text = "Seleccione";
            // 
            // lklb_Search
            // 
            this.lklb_Search.AutoSize = true;
            this.lklb_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklb_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lklb_Search.LinkColor = System.Drawing.Color.Snow;
            this.lklb_Search.Location = new System.Drawing.Point(555, 43);
            this.lklb_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklb_Search.Name = "lklb_Search";
            this.lklb_Search.Size = new System.Drawing.Size(52, 17);
            this.lklb_Search.TabIndex = 12;
            this.lklb_Search.TabStop = true;
            this.lklb_Search.Text = "Buscar";
            this.lklb_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklb_Search_LinkClicked);
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
            // txt_Debt
            // 
            this.txt_Debt.Location = new System.Drawing.Point(196, 310);
            this.txt_Debt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Debt.Name = "txt_Debt";
            this.txt_Debt.Size = new System.Drawing.Size(336, 22);
            this.txt_Debt.TabIndex = 11;
            this.txt_Debt.Tag = "";
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
            // lbl_Debt
            // 
            this.lbl_Debt.AutoSize = true;
            this.lbl_Debt.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Debt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Debt.Location = new System.Drawing.Point(63, 310);
            this.lbl_Debt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Debt.Name = "lbl_Debt";
            this.lbl_Debt.Size = new System.Drawing.Size(97, 17);
            this.lbl_Debt.TabIndex = 4;
            this.lbl_Debt.Text = "Deuda Actual:";
            // 
            // txt_Identification
            // 
            this.txt_Identification.Location = new System.Drawing.Point(196, 85);
            this.txt_Identification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Identification.Name = "txt_Identification";
            this.txt_Identification.Size = new System.Drawing.Size(336, 22);
            this.txt_Identification.TabIndex = 6;
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(196, 265);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(336, 22);
            this.txt_Adress.TabIndex = 10;
            this.txt_Adress.Tag = "";
            // 
            // txt_Neightborhood
            // 
            this.txt_Neightborhood.Location = new System.Drawing.Point(196, 220);
            this.txt_Neightborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Neightborhood.Name = "txt_Neightborhood";
            this.txt_Neightborhood.Size = new System.Drawing.Size(336, 22);
            this.txt_Neightborhood.TabIndex = 9;
            this.txt_Neightborhood.Tag = "";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(196, 175);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(336, 22);
            this.txt_LastName.TabIndex = 7;
            this.txt_LastName.Tag = "Apellidos";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(196, 130);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(336, 22);
            this.txt_FirstName.TabIndex = 7;
            this.txt_FirstName.Tag = "Apellidos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_Registrar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Eliminar);
            this.groupBox2.Controls.Add(this.btn_Modificar);
            this.groupBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Location = new System.Drawing.Point(46, 477);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 89);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.BackgroundImage")));
            this.btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registrar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Registrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Registrar.Location = new System.Drawing.Point(33, 21);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(127, 55);
            this.btn_Registrar.TabIndex = 13;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(575, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Eliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Eliminar.Location = new System.Drawing.Point(394, 21);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(127, 55);
            this.btn_Eliminar.TabIndex = 15;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Modificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Modificar.Location = new System.Drawing.Point(217, 21);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(127, 55);
            this.btn_Modificar.TabIndex = 14;
            this.btn_Modificar.Tag = "Modificar";
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // OptionsClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsClients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.LinkLabel lklb_Search;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.TextBox txt_Debt;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Label lbl_Neightborhood;
        private System.Windows.Forms.Label lbl_IdentificationType;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Debt;
        private System.Windows.Forms.TextBox txt_Identification;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.TextBox txt_Neightborhood;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.ComboBox cmb_TypeProduct;
    }
}