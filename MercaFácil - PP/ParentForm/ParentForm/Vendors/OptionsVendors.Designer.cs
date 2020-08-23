namespace ParentForm
{
    partial class OptionsVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsVendors));
            this.pn_Cabecera = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_NIT = new System.Windows.Forms.Label();
            this.lbl_Neighborhood = new System.Windows.Forms.Label();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.txt_NIT = new System.Windows.Forms.TextBox();
            this.txt_Neighborhood = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.pn_Cabecera.SuspendLayout();
            this.gb_Datos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Cabecera
            // 
            this.pn_Cabecera.BackColor = System.Drawing.Color.Transparent;
            this.pn_Cabecera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_Cabecera.BackgroundImage")));
            this.pn_Cabecera.Controls.Add(this.label11);
            this.pn_Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Cabecera.Location = new System.Drawing.Point(0, 0);
            this.pn_Cabecera.Name = "pn_Cabecera";
            this.pn_Cabecera.Size = new System.Drawing.Size(819, 67);
            this.pn_Cabecera.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(315, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 44);
            this.label11.TabIndex = 0;
            this.label11.Text = "Proveedores";
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Transparent;
            this.gb_Datos.Controls.Add(this.linkLabel2);
            this.gb_Datos.Controls.Add(this.lbl_Name);
            this.gb_Datos.Controls.Add(this.lbl_NIT);
            this.gb_Datos.Controls.Add(this.lbl_Neighborhood);
            this.gb_Datos.Controls.Add(this.lbl_Adress);
            this.gb_Datos.Controls.Add(this.txt_Name);
            this.gb_Datos.Controls.Add(this.txt_Adress);
            this.gb_Datos.Controls.Add(this.txt_NIT);
            this.gb_Datos.Controls.Add(this.txt_Neighborhood);
            this.gb_Datos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.gb_Datos.Location = new System.Drawing.Point(87, 92);
            this.gb_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Size = new System.Drawing.Size(648, 233);
            this.gb_Datos.TabIndex = 16;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.Snow;
            this.linkLabel2.Location = new System.Drawing.Point(555, 43);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(52, 17);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Buscar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(63, 85);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 17);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Nombre:";
            // 
            // lbl_NIT
            // 
            this.lbl_NIT.AutoSize = true;
            this.lbl_NIT.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_NIT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_NIT.Location = new System.Drawing.Point(63, 40);
            this.lbl_NIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NIT.Name = "lbl_NIT";
            this.lbl_NIT.Size = new System.Drawing.Size(34, 17);
            this.lbl_NIT.TabIndex = 2;
            this.lbl_NIT.Text = "NIT:";
            // 
            // lbl_Neighborhood
            // 
            this.lbl_Neighborhood.AutoSize = true;
            this.lbl_Neighborhood.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Neighborhood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Neighborhood.Location = new System.Drawing.Point(63, 130);
            this.lbl_Neighborhood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Neighborhood.Name = "lbl_Neighborhood";
            this.lbl_Neighborhood.Size = new System.Drawing.Size(50, 17);
            this.lbl_Neighborhood.TabIndex = 2;
            this.lbl_Neighborhood.Text = "Barrio:";
            // 
            // lbl_Adress
            // 
            this.lbl_Adress.AutoSize = true;
            this.lbl_Adress.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Adress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Adress.Location = new System.Drawing.Point(63, 175);
            this.lbl_Adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adress.Name = "lbl_Adress";
            this.lbl_Adress.Size = new System.Drawing.Size(71, 17);
            this.lbl_Adress.TabIndex = 3;
            this.lbl_Adress.Text = "Dirección:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(196, 85);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(336, 22);
            this.txt_Name.TabIndex = 6;
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(196, 175);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(336, 22);
            this.txt_Adress.TabIndex = 9;
            this.txt_Adress.Tag = "Apellidos";
            // 
            // txt_NIT
            // 
            this.txt_NIT.Location = new System.Drawing.Point(196, 40);
            this.txt_NIT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NIT.Name = "txt_NIT";
            this.txt_NIT.Size = new System.Drawing.Size(336, 22);
            this.txt_NIT.TabIndex = 5;
            this.txt_NIT.Tag = "Apellidos";
            // 
            // txt_Neighborhood
            // 
            this.txt_Neighborhood.Location = new System.Drawing.Point(196, 130);
            this.txt_Neighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Neighborhood.Name = "txt_Neighborhood";
            this.txt_Neighborhood.Size = new System.Drawing.Size(336, 22);
            this.txt_Neighborhood.TabIndex = 7;
            this.txt_Neighborhood.Tag = "Apellidos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_Registrar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Eliminar);
            this.groupBox2.Controls.Add(this.btn_Modificar);
            this.groupBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Location = new System.Drawing.Point(37, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 89);
            this.groupBox2.TabIndex = 19;
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
            // OptionsVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.pn_Cabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsVendors";
            this.pn_Cabecera.ResumeLayout(false);
            this.pn_Cabecera.PerformLayout();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Cabecera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_NIT;
        private System.Windows.Forms.Label lbl_Neighborhood;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.TextBox txt_NIT;
        private System.Windows.Forms.TextBox txt_Neighborhood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
    }
}