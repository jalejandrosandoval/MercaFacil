namespace ParentForm
{
    partial class OptionsProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsProducts));
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.lklb_Search = new System.Windows.Forms.LinkLabel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_vIva = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cmb_TypeProduct = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaFacil_2DataSet = new ParentForm.MercaFacil_2DataSet();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_vIva = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_EditProducts = new System.Windows.Forms.Button();
            this.tipo_ProductoTableAdapter = new ParentForm.MercaFacil_2DataSetTableAdapters.Tipo_ProductoTableAdapter();
            this.btn_agregarVenc = new System.Windows.Forms.Button();
            this.gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Transparent;
            this.gb_Datos.Controls.Add(this.lklb_Search);
            this.gb_Datos.Controls.Add(this.lbl_Name);
            this.gb_Datos.Controls.Add(this.txt_Price);
            this.gb_Datos.Controls.Add(this.lbl_Amount);
            this.gb_Datos.Controls.Add(this.lbl_vIva);
            this.gb_Datos.Controls.Add(this.lbl_Code);
            this.gb_Datos.Controls.Add(this.lbl_Description);
            this.gb_Datos.Controls.Add(this.lbl_Type);
            this.gb_Datos.Controls.Add(this.cmb_TypeProduct);
            this.gb_Datos.Controls.Add(this.lbl_Price);
            this.gb_Datos.Controls.Add(this.txt_Name);
            this.gb_Datos.Controls.Add(this.txt_Amount);
            this.gb_Datos.Controls.Add(this.txt_vIva);
            this.gb_Datos.Controls.Add(this.txt_Code);
            this.gb_Datos.Controls.Add(this.txt_Description);
            this.gb_Datos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.gb_Datos.Location = new System.Drawing.Point(91, 93);
            this.gb_Datos.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Datos.Size = new System.Drawing.Size(648, 357);
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
            this.lklb_Search.TabIndex = 5;
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
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(196, 310);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(336, 22);
            this.txt_Price.TabIndex = 12;
            this.txt_Price.Tag = "";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Amount.Location = new System.Drawing.Point(63, 265);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(68, 17);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Cantidad:";
            // 
            // lbl_vIva
            // 
            this.lbl_vIva.AutoSize = true;
            this.lbl_vIva.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_vIva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_vIva.Location = new System.Drawing.Point(63, 220);
            this.lbl_vIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vIva.Name = "lbl_vIva";
            this.lbl_vIva.Size = new System.Drawing.Size(30, 17);
            this.lbl_vIva.TabIndex = 2;
            this.lbl_vIva.Text = "Iva:";
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Code.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Code.Location = new System.Drawing.Point(63, 40);
            this.lbl_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(56, 17);
            this.lbl_Code.TabIndex = 2;
            this.lbl_Code.Text = "Codigo:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Description.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Description.Location = new System.Drawing.Point(63, 130);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(86, 17);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Descripcion:";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Type.Location = new System.Drawing.Point(63, 175);
            this.lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(44, 17);
            this.lbl_Type.TabIndex = 3;
            this.lbl_Type.Text = "Tipo: ";
            // 
            // cmb_TypeProduct
            // 
            this.cmb_TypeProduct.DataSource = this.tipoProductoBindingSource;
            this.cmb_TypeProduct.DisplayMember = "Tipo_Producto";
            this.cmb_TypeProduct.FormattingEnabled = true;
            this.cmb_TypeProduct.Location = new System.Drawing.Point(196, 175);
            this.cmb_TypeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TypeProduct.Name = "cmb_TypeProduct";
            this.cmb_TypeProduct.Size = new System.Drawing.Size(336, 24);
            this.cmb_TypeProduct.TabIndex = 9;
            this.cmb_TypeProduct.ValueMember = "Id";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "Tipo_Producto";
            this.tipoProductoBindingSource.DataSource = this.mercaFacil_2DataSet;
            // 
            // mercaFacil_2DataSet
            // 
            this.mercaFacil_2DataSet.DataSetName = "MercaFacil_2DataSet";
            this.mercaFacil_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Price.Location = new System.Drawing.Point(63, 310);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(93, 17);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "Precio Venta:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(196, 85);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(336, 22);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(196, 265);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(336, 22);
            this.txt_Amount.TabIndex = 11;
            this.txt_Amount.Tag = "";
            // 
            // txt_vIva
            // 
            this.txt_vIva.Location = new System.Drawing.Point(196, 220);
            this.txt_vIva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vIva.Name = "txt_vIva";
            this.txt_vIva.Size = new System.Drawing.Size(336, 22);
            this.txt_vIva.TabIndex = 10;
            this.txt_vIva.Tag = "";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(196, 40);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(336, 22);
            this.txt_Code.TabIndex = 6;
            this.txt_Code.Tag = "Apellidos";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(196, 130);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(336, 22);
            this.txt_Description.TabIndex = 8;
            this.txt_Description.Tag = "Apellidos";
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
            this.panel1.TabIndex = 17;
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
            this.label11.Size = new System.Drawing.Size(147, 44);
            this.label11.TabIndex = 1;
            this.label11.Text = "Productos";
            // 
            // btn_EditProducts
            // 
            this.btn_EditProducts.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditProducts.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_EditProducts.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EditProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EditProducts.Location = new System.Drawing.Point(324, 485);
            this.btn_EditProducts.Name = "btn_EditProducts";
            this.btn_EditProducts.Size = new System.Drawing.Size(84, 32);
            this.btn_EditProducts.TabIndex = 13;
            this.btn_EditProducts.Text = "Editar";
            this.btn_EditProducts.UseVisualStyleBackColor = false;
            this.btn_EditProducts.Click += new System.EventHandler(this.btn_EditProducts_Click);
            // 
            // tipo_ProductoTableAdapter
            // 
            this.tipo_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_agregarVenc
            // 
            this.btn_agregarVenc.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarVenc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregarVenc.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_agregarVenc.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_agregarVenc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_agregarVenc.Location = new System.Drawing.Point(432, 482);
            this.btn_agregarVenc.Name = "btn_agregarVenc";
            this.btn_agregarVenc.Size = new System.Drawing.Size(275, 38);
            this.btn_agregarVenc.TabIndex = 18;
            this.btn_agregarVenc.Text = "Agregar Fecha Vencimiento";
            this.btn_agregarVenc.UseVisualStyleBackColor = false;
            this.btn_agregarVenc.Click += new System.EventHandler(this.btn_agregarVenc_Click);
            // 
            // OptionsProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 553);
            this.Controls.Add(this.btn_agregarVenc);
            this.Controls.Add(this.btn_EditProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OptionsProducts_Load);
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercaFacil_2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.LinkLabel lklb_Search;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_vIva;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_EditProducts;
        public System.Windows.Forms.TextBox txt_Price;
        public System.Windows.Forms.ComboBox cmb_TypeProduct;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_Amount;
        public System.Windows.Forms.TextBox txt_vIva;
        public System.Windows.Forms.TextBox txt_Code;
        public System.Windows.Forms.TextBox txt_Description;
        private MercaFacil_2DataSet mercaFacil_2DataSet;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private MercaFacil_2DataSetTableAdapters.Tipo_ProductoTableAdapter tipo_ProductoTableAdapter;
        private System.Windows.Forms.Button btn_agregarVenc;
    }
}