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
            this.lklb_Search = new System.Windows.Forms.LinkLabel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_NIT = new System.Windows.Forms.Label();
            this.lbl_Neighborhood = new System.Windows.Forms.Label();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.txt_NIT = new System.Windows.Forms.TextBox();
            this.txt_Neighborhood = new System.Windows.Forms.TextBox();
            this.btn_EditVendor = new System.Windows.Forms.Button();
            this.pn_Cabecera.SuspendLayout();
            this.gb_Datos.SuspendLayout();
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
            this.gb_Datos.Controls.Add(this.lklb_Search);
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
            this.lklb_Search.TabIndex = 4;
            this.lklb_Search.TabStop = true;
            this.lklb_Search.Text = "Buscar";
            this.lklb_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklb_Search_LinkClicked);
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
            this.txt_Adress.TabIndex = 8;
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
            // btn_EditVendor
            // 
            this.btn_EditVendor.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditVendor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditVendor.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_EditVendor.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EditVendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EditVendor.Location = new System.Drawing.Point(372, 359);
            this.btn_EditVendor.Name = "btn_EditVendor";
            this.btn_EditVendor.Size = new System.Drawing.Size(84, 32);
            this.btn_EditVendor.TabIndex = 9;
            this.btn_EditVendor.Text = "Editar";
            this.btn_EditVendor.UseVisualStyleBackColor = false;
            this.btn_EditVendor.Click += new System.EventHandler(this.btn_EditVendor_Click);
            // 
            // OptionsVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 412);
            this.Controls.Add(this.btn_EditVendor);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.pn_Cabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pn_Cabecera.ResumeLayout(false);
            this.pn_Cabecera.PerformLayout();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Cabecera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lklb_Search;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_NIT;
        private System.Windows.Forms.Label lbl_Neighborhood;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Button btn_EditVendor;
        public System.Windows.Forms.GroupBox gb_Datos;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_Adress;
        public System.Windows.Forms.TextBox txt_NIT;
        public System.Windows.Forms.TextBox txt_Neighborhood;
    }
}