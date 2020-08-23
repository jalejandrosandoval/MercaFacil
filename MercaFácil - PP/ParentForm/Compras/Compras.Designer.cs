namespace ParentForm
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.btn_addVendor = new System.Windows.Forms.PictureBox();
            this.btn_SearchVendor = new System.Windows.Forms.PictureBox();
            this.lbl_AddProduct = new System.Windows.Forms.Label();
            this.dGrid_Cart = new System.Windows.Forms.DataGridView();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_CodeBar = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.PictureBox();
            this.lbl_Remove = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_Shop = new System.Windows.Forms.PictureBox();
            this.btn_AddProduct = new System.Windows.Forms.PictureBox();
            this.lbl_AddVendor = new System.Windows.Forms.Label();
            this.lbl_SelectVendor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_NumFactura = new System.Windows.Forms.Label();
            this.txt_NumFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SearchVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 57);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(419, 9);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(119, 44);
            this.lbl_Ventas.TabIndex = 4;
            this.lbl_Ventas.Text = "Compra";
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.AutoSize = true;
            this.lbl_Vendor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vendor.Font = new System.Drawing.Font("Tw Cen MT Condensed", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_Vendor.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Vendor.Location = new System.Drawing.Point(179, 132);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(117, 34);
            this.lbl_Vendor.TabIndex = 4;
            this.lbl_Vendor.Text = "Proveedor";
            // 
            // btn_addVendor
            // 
            this.btn_addVendor.BackColor = System.Drawing.Color.Transparent;
            this.btn_addVendor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addVendor.BackgroundImage")));
            this.btn_addVendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addVendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addVendor.Location = new System.Drawing.Point(792, 123);
            this.btn_addVendor.Name = "btn_addVendor";
            this.btn_addVendor.Size = new System.Drawing.Size(35, 35);
            this.btn_addVendor.TabIndex = 9;
            this.btn_addVendor.TabStop = false;
            this.btn_addVendor.Click += new System.EventHandler(this.btn_addVendor_Click);
            // 
            // btn_SearchVendor
            // 
            this.btn_SearchVendor.BackColor = System.Drawing.Color.Transparent;
            this.btn_SearchVendor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SearchVendor.BackgroundImage")));
            this.btn_SearchVendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SearchVendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchVendor.Location = new System.Drawing.Point(80, 134);
            this.btn_SearchVendor.Name = "btn_SearchVendor";
            this.btn_SearchVendor.Size = new System.Drawing.Size(35, 35);
            this.btn_SearchVendor.TabIndex = 8;
            this.btn_SearchVendor.TabStop = false;
            this.btn_SearchVendor.Click += new System.EventHandler(this.btn_SearchVendor_Click);
            // 
            // lbl_AddProduct
            // 
            this.lbl_AddProduct.AutoSize = true;
            this.lbl_AddProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddProduct.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_AddProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_AddProduct.Location = new System.Drawing.Point(858, 160);
            this.lbl_AddProduct.Name = "lbl_AddProduct";
            this.lbl_AddProduct.Size = new System.Drawing.Size(64, 32);
            this.lbl_AddProduct.TabIndex = 6;
            this.lbl_AddProduct.Text = "Registrar \r\nProducto";
            // 
            // dGrid_Cart
            // 
            this.dGrid_Cart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_Cart.GridColor = System.Drawing.SystemColors.Control;
            this.dGrid_Cart.Location = new System.Drawing.Point(57, 275);
            this.dGrid_Cart.Name = "dGrid_Cart";
            this.dGrid_Cart.RowTemplate.Height = 24;
            this.dGrid_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid_Cart.Size = new System.Drawing.Size(866, 213);
            this.dGrid_Cart.TabIndex = 10;
            this.dGrid_Cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_Cart_CellClick);
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(185, 213);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(237, 22);
            this.txt_Barcode.TabIndex = 14;
            this.txt_Barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Barcode_KeyDown);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Price.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Price.Location = new System.Drawing.Point(444, 204);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(201, 35);
            this.lbl_Price.TabIndex = 12;
            this.lbl_Price.Text = "Ingresar producto";
            // 
            // lbl_CodeBar
            // 
            this.lbl_CodeBar.AutoSize = true;
            this.lbl_CodeBar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CodeBar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_CodeBar.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CodeBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_CodeBar.Location = new System.Drawing.Point(53, 210);
            this.lbl_CodeBar.Name = "lbl_CodeBar";
            this.lbl_CodeBar.Size = new System.Drawing.Size(126, 29);
            this.lbl_CodeBar.TabIndex = 13;
            this.lbl_CodeBar.Text = "Cod. Barras: ";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.Location = new System.Drawing.Point(880, 206);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(43, 35);
            this.btn_Remove.TabIndex = 17;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Visible = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lbl_Remove
            // 
            this.lbl_Remove.AutoSize = true;
            this.lbl_Remove.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Remove.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Remove.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Remove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Remove.Location = new System.Drawing.Point(706, 209);
            this.lbl_Remove.Name = "lbl_Remove";
            this.lbl_Remove.Size = new System.Drawing.Size(171, 29);
            this.lbl_Remove.TabIndex = 16;
            this.lbl_Remove.Text = "Remover Producto";
            this.lbl_Remove.Visible = false;
            this.lbl_Remove.Click += new System.EventHandler(this.lbl_Remove_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Date.Location = new System.Drawing.Point(52, 505);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(50, 23);
            this.lbl_Date.TabIndex = 18;
            this.lbl_Date.Text = "Fecha";
            // 
            // btn_Shop
            // 
            this.btn_Shop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Shop.BackgroundImage")));
            this.btn_Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shop.Location = new System.Drawing.Point(865, 498);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(45, 45);
            this.btn_Shop.TabIndex = 19;
            this.btn_Shop.TabStop = false;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddProduct.BackgroundImage")));
            this.btn_AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddProduct.Location = new System.Drawing.Point(865, 128);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(35, 35);
            this.btn_AddProduct.TabIndex = 9;
            this.btn_AddProduct.TabStop = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // lbl_AddVendor
            // 
            this.lbl_AddVendor.AutoSize = true;
            this.lbl_AddVendor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddVendor.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddVendor.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_AddVendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_AddVendor.Location = new System.Drawing.Point(780, 161);
            this.lbl_AddVendor.Name = "lbl_AddVendor";
            this.lbl_AddVendor.Size = new System.Drawing.Size(67, 32);
            this.lbl_AddVendor.TabIndex = 5;
            this.lbl_AddVendor.Text = "Registrar\r\nProveedor";
            // 
            // lbl_SelectVendor
            // 
            this.lbl_SelectVendor.AutoSize = true;
            this.lbl_SelectVendor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SelectVendor.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectVendor.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_SelectVendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_SelectVendor.Location = new System.Drawing.Point(64, 177);
            this.lbl_SelectVendor.Name = "lbl_SelectVendor";
            this.lbl_SelectVendor.Size = new System.Drawing.Size(71, 32);
            this.lbl_SelectVendor.TabIndex = 4;
            this.lbl_SelectVendor.Text = "Seleccionar\r\nProveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1092, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // lbl_NumFactura
            // 
            this.lbl_NumFactura.AutoSize = true;
            this.lbl_NumFactura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumFactura.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_NumFactura.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_NumFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_NumFactura.Location = new System.Drawing.Point(62, 85);
            this.lbl_NumFactura.Name = "lbl_NumFactura";
            this.lbl_NumFactura.Size = new System.Drawing.Size(142, 29);
            this.lbl_NumFactura.TabIndex = 4;
            this.lbl_NumFactura.Text = "Num. Factura: ";
            // 
            // txt_NumFactura
            // 
            this.txt_NumFactura.Location = new System.Drawing.Point(210, 92);
            this.txt_NumFactura.Name = "txt_NumFactura";
            this.txt_NumFactura.Size = new System.Drawing.Size(225, 22);
            this.txt_NumFactura.TabIndex = 20;
            this.txt_NumFactura.Text = "F0000 - 0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(747, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "REGISTRAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NumFactura);
            this.Controls.Add(this.lbl_NumFactura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Shop);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.lbl_Remove);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_CodeBar);
            this.Controls.Add(this.dGrid_Cart);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.btn_addVendor);
            this.Controls.Add(this.btn_SearchVendor);
            this.Controls.Add(this.lbl_SelectVendor);
            this.Controls.Add(this.lbl_AddVendor);
            this.Controls.Add(this.lbl_AddProduct);
            this.Controls.Add(this.lbl_Vendor);
            this.Controls.Add(this.panel1);
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SearchVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.PictureBox btn_addVendor;
        private System.Windows.Forms.PictureBox btn_SearchVendor;
        private System.Windows.Forms.Label lbl_AddProduct;
        private System.Windows.Forms.DataGridView dGrid_Cart;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_CodeBar;
        private System.Windows.Forms.PictureBox btn_Remove;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.PictureBox btn_Shop;
        private System.Windows.Forms.PictureBox btn_AddProduct;
        private System.Windows.Forms.Label lbl_AddVendor;
        private System.Windows.Forms.Label lbl_SelectVendor;
        public System.Windows.Forms.Label lbl_Vendor;
        private System.Windows.Forms.Label lbl_Remove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_NumFactura;
        private System.Windows.Forms.TextBox txt_NumFactura;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Barcode;
    }
}