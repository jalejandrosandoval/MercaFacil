namespace ParentForm
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.btn_SearchClient = new System.Windows.Forms.PictureBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.btn_addClient = new System.Windows.Forms.PictureBox();
            this.dGrid_ShoppingCart = new System.Windows.Forms.DataGridView();
            this.lbl_Unity = new System.Windows.Forms.Label();
            this.btn_Shop = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.PictureBox();
            this.lbl_CodeBar = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.lbl_Remove = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.checkBox_DeleteProductSP = new System.Windows.Forms.CheckBox();
            this.lbl_SelectClient = new System.Windows.Forms.Label();
            this.lbl_AddClient = new System.Windows.Forms.Label();
            this.lbl_currentPrice = new System.Windows.Forms.Label();
            this.checkBox_DeleteQuantity = new System.Windows.Forms.CheckBox();
            this.checkBox_AddQuantity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SearchClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_ShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 55);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(311, 6);
            this.lbl_Ventas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(77, 35);
            this.lbl_Ventas.TabIndex = 3;
            this.lbl_Ventas.Text = "Venta";
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Client.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Client.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Client.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Client.Location = new System.Drawing.Point(35, 96);
            this.lbl_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(85, 28);
            this.lbl_Client.TabIndex = 4;
            this.lbl_Client.Text = "Cliente: ";
            // 
            // btn_SearchClient
            // 
            this.btn_SearchClient.BackColor = System.Drawing.Color.Transparent;
            this.btn_SearchClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SearchClient.BackgroundImage")));
            this.btn_SearchClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SearchClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchClient.Location = new System.Drawing.Point(49, 137);
            this.btn_SearchClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SearchClient.Name = "btn_SearchClient";
            this.btn_SearchClient.Size = new System.Drawing.Size(26, 28);
            this.btn_SearchClient.TabIndex = 5;
            this.btn_SearchClient.TabStop = false;
            this.btn_SearchClient.Click += new System.EventHandler(this.btn_SearchClient_Click);
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empleado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_empleado.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_empleado.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_empleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_empleado.Location = new System.Drawing.Point(489, 96);
            this.lbl_empleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(94, 28);
            this.lbl_empleado.TabIndex = 6;
            this.lbl_empleado.Text = "Empleado";
            // 
            // btn_addClient
            // 
            this.btn_addClient.BackColor = System.Drawing.Color.Transparent;
            this.btn_addClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addClient.BackgroundImage")));
            this.btn_addClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addClient.Location = new System.Drawing.Point(114, 137);
            this.btn_addClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Size = new System.Drawing.Size(26, 28);
            this.btn_addClient.TabIndex = 7;
            this.btn_addClient.TabStop = false;
            this.btn_addClient.Click += new System.EventHandler(this.btn_addClient_Click);
            // 
            // dGrid_ShoppingCart
            // 
            this.dGrid_ShoppingCart.AllowUserToAddRows = false;
            this.dGrid_ShoppingCart.AllowUserToDeleteRows = false;
            this.dGrid_ShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid_ShoppingCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_ShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_ShoppingCart.Location = new System.Drawing.Point(25, 318);
            this.dGrid_ShoppingCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGrid_ShoppingCart.Name = "dGrid_ShoppingCart";
            this.dGrid_ShoppingCart.ReadOnly = true;
            this.dGrid_ShoppingCart.RowTemplate.Height = 24;
            this.dGrid_ShoppingCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid_ShoppingCart.Size = new System.Drawing.Size(665, 213);
            this.dGrid_ShoppingCart.TabIndex = 1;
            this.dGrid_ShoppingCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_ShoppingCart_CellClick);
            // 
            // lbl_Unity
            // 
            this.lbl_Unity.AutoSize = true;
            this.lbl_Unity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Unity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Unity.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Unity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Unity.Location = new System.Drawing.Point(327, 254);
            this.lbl_Unity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Unity.Name = "lbl_Unity";
            this.lbl_Unity.Size = new System.Drawing.Size(83, 28);
            this.lbl_Unity.TabIndex = 6;
            this.lbl_Unity.Text = "Unitario";
            // 
            // btn_Shop
            // 
            this.btn_Shop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Shop.BackgroundImage")));
            this.btn_Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shop.Location = new System.Drawing.Point(656, 566);
            this.btn_Shop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(34, 37);
            this.btn_Shop.TabIndex = 9;
            this.btn_Shop.TabStop = false;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Location = new System.Drawing.Point(656, 254);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(32, 28);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_CodeBar
            // 
            this.lbl_CodeBar.AutoSize = true;
            this.lbl_CodeBar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CodeBar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_CodeBar.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CodeBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_CodeBar.Location = new System.Drawing.Point(28, 254);
            this.lbl_CodeBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CodeBar.Name = "lbl_CodeBar";
            this.lbl_CodeBar.Size = new System.Drawing.Size(101, 23);
            this.lbl_CodeBar.TabIndex = 6;
            this.lbl_CodeBar.Text = "Cod. Barras: ";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(128, 260);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(179, 20);
            this.txt_barcode.TabIndex = 0;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            // 
            // lbl_Remove
            // 
            this.lbl_Remove.AutoSize = true;
            this.lbl_Remove.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Remove.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Remove.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Remove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Remove.Location = new System.Drawing.Point(526, 257);
            this.lbl_Remove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Remove.Name = "lbl_Remove";
            this.lbl_Remove.Size = new System.Drawing.Size(135, 23);
            this.lbl_Remove.TabIndex = 6;
            this.lbl_Remove.Text = "Remover Producto";
            this.lbl_Remove.Click += new System.EventHandler(this.lbl_Remove_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Date.Location = new System.Drawing.Point(20, 566);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(59, 28);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Fecha";
            // 
            // checkBox_DeleteProductSP
            // 
            this.checkBox_DeleteProductSP.AutoSize = true;
            this.checkBox_DeleteProductSP.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DeleteProductSP.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox_DeleteProductSP.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_DeleteProductSP.Location = new System.Drawing.Point(282, 187);
            this.checkBox_DeleteProductSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_DeleteProductSP.Name = "checkBox_DeleteProductSP";
            this.checkBox_DeleteProductSP.Size = new System.Drawing.Size(119, 23);
            this.checkBox_DeleteProductSP.TabIndex = 11;
            this.checkBox_DeleteProductSP.Text = "Eliminar unidad";
            this.checkBox_DeleteProductSP.UseVisualStyleBackColor = false;
            this.checkBox_DeleteProductSP.Click += new System.EventHandler(this.checkBox_DeleteProductSP_Click);
            // 
            // lbl_SelectClient
            // 
            this.lbl_SelectClient.AutoSize = true;
            this.lbl_SelectClient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SelectClient.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectClient.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_SelectClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_SelectClient.Location = new System.Drawing.Point(37, 173);
            this.lbl_SelectClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SelectClient.Name = "lbl_SelectClient";
            this.lbl_SelectClient.Size = new System.Drawing.Size(58, 28);
            this.lbl_SelectClient.TabIndex = 12;
            this.lbl_SelectClient.Text = "Seleccionar\r\n   Cliente";
            // 
            // lbl_AddClient
            // 
            this.lbl_AddClient.AutoSize = true;
            this.lbl_AddClient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddClient.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddClient.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_AddClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_AddClient.Location = new System.Drawing.Point(106, 173);
            this.lbl_AddClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AddClient.Name = "lbl_AddClient";
            this.lbl_AddClient.Size = new System.Drawing.Size(48, 28);
            this.lbl_AddClient.TabIndex = 13;
            this.lbl_AddClient.Text = "Registrar\r\n Cliente";
            // 
            // lbl_currentPrice
            // 
            this.lbl_currentPrice.AutoSize = true;
            this.lbl_currentPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentPrice.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_currentPrice.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_currentPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_currentPrice.Location = new System.Drawing.Point(418, 566);
            this.lbl_currentPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_currentPrice.Name = "lbl_currentPrice";
            this.lbl_currentPrice.Size = new System.Drawing.Size(75, 28);
            this.lbl_currentPrice.TabIndex = 14;
            this.lbl_currentPrice.Text = "$Precio";
            // 
            // checkBox_DeleteQuantity
            // 
            this.checkBox_DeleteQuantity.AutoSize = true;
            this.checkBox_DeleteQuantity.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DeleteQuantity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox_DeleteQuantity.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_DeleteQuantity.Location = new System.Drawing.Point(282, 214);
            this.checkBox_DeleteQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_DeleteQuantity.Name = "checkBox_DeleteQuantity";
            this.checkBox_DeleteQuantity.Size = new System.Drawing.Size(131, 23);
            this.checkBox_DeleteQuantity.TabIndex = 15;
            this.checkBox_DeleteQuantity.Text = "Eliminar Cantidad";
            this.checkBox_DeleteQuantity.UseVisualStyleBackColor = false;
            this.checkBox_DeleteQuantity.Click += new System.EventHandler(this.checkBox_DeleteQuantity_Click);
            // 
            // checkBox_AddQuantity
            // 
            this.checkBox_AddQuantity.AutoSize = true;
            this.checkBox_AddQuantity.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AddQuantity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox_AddQuantity.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_AddQuantity.Location = new System.Drawing.Point(32, 214);
            this.checkBox_AddQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_AddQuantity.Name = "checkBox_AddQuantity";
            this.checkBox_AddQuantity.Size = new System.Drawing.Size(129, 23);
            this.checkBox_AddQuantity.TabIndex = 16;
            this.checkBox_AddQuantity.Text = "Agregar Cantidad";
            this.checkBox_AddQuantity.UseVisualStyleBackColor = false;
            this.checkBox_AddQuantity.Click += new System.EventHandler(this.checkBox_AddQuantity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(570, 574);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "REGISTRAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_AddQuantity);
            this.Controls.Add(this.checkBox_DeleteQuantity);
            this.Controls.Add(this.lbl_currentPrice);
            this.Controls.Add(this.lbl_SelectClient);
            this.Controls.Add(this.lbl_AddClient);
            this.Controls.Add(this.checkBox_DeleteProductSP);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.btn_Shop);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.dGrid_ShoppingCart);
            this.Controls.Add(this.btn_addClient);
            this.Controls.Add(this.lbl_Unity);
            this.Controls.Add(this.lbl_CodeBar);
            this.Controls.Add(this.lbl_Remove);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.btn_SearchClient);
            this.Controls.Add(this.lbl_Client);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SearchClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_ShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.PictureBox btn_SearchClient;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.PictureBox btn_addClient;
        private System.Windows.Forms.DataGridView dGrid_ShoppingCart;
        private System.Windows.Forms.Label lbl_Unity;
        private System.Windows.Forms.PictureBox btn_Shop;
        private System.Windows.Forms.PictureBox btn_Cancel;
        private System.Windows.Forms.Label lbl_CodeBar;
        private System.Windows.Forms.Label lbl_Remove;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.CheckBox checkBox_DeleteProductSP;
        private System.Windows.Forms.Label lbl_SelectClient;
        private System.Windows.Forms.Label lbl_AddClient;
        private System.Windows.Forms.Label lbl_currentPrice;
        public System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.CheckBox checkBox_DeleteQuantity;
        private System.Windows.Forms.CheckBox checkBox_AddQuantity;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_barcode;
    }
}