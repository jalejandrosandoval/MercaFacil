using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentForm
{
    public partial class Compras : Form
    {

        //DATASETS
        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter tap 
            = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();

        MercaFacil_2DataSet.ProductoDataTable answer;
        public MercaFacil_2DataSet.ProveedorRow Provider { get; set; }

        MercaFacil_2DataSet.ProductoRow SelectedProduct;

        //Variables

        ShoppingCart SCP;
        Product Product;
        List<ShoppingCart> BuyList;
        string barcodeQuit = "";


        MdiParent parent; 

        //FORMS
        ChooseQuantityBuy frm_ChooseQuantityBuy;

        public Compras()
        {
            InitializeComponent();
            BuyList = new List<ShoppingCart>();
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            lbl_Vendor.Visible = false;
        }

        private void btn_SearchVendor_Click(object sender, EventArgs e)
        {
             parent = (MdiParent)this.MdiParent;

            if (!parent.formExist("SearchVendorBuy"))
            {
                SearchVendorBuy frm_SearchForms = new SearchVendorBuy(this);
                frm_SearchForms.Show();
                lbl_Vendor.Visible = true;
            }
        }

        private void btn_addVendor_Click(object sender, EventArgs e)
        {
            parent = (MdiParent)this.MdiParent;

            if (!parent.formExist("CreateVendor"))
            {
                CreateVendor frm_CreateVendor = new CreateVendor();
                frm_CreateVendor.Show();
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            parent = (MdiParent)this.MdiParent;

            if (!parent.formExist("CreateProduct"))
            {
                CreateProduct frm_CreateProduct = new CreateProduct();
                frm_CreateProduct.Show();
            }
        }

        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    answer = tap.GetDataByCodBarras(txt_Barcode.Text);

                    if (answer.Count > 0)
                    {
                        Product = new Product();
                        SCP = new ShoppingCart();

                        SelectedProduct = answer[0];

                        Product.Barcode = SelectedProduct.Codigo_Barras;
                        Product.Name = SelectedProduct.Nombre;
                        Product.Price = SelectedProduct.Precio_Venta;
                        Product.Iva = SelectedProduct.Porcentaje_Iva;
                        Product.Description = SelectedProduct.Descripcion;
                        Product.Stock = SelectedProduct.Stock;
                        Product.TypeProduct = SelectedProduct.Tipo_Producto;
                        Product.Borrado = SelectedProduct.Borrado;


                        frm_ChooseQuantityBuy = new ChooseQuantityBuy(this);
                        frm_ChooseQuantityBuy.Show();

                        frm_ChooseQuantityBuy.FormClosed += new FormClosedEventHandler(ChooseAmount);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        public void ChooseAmount(object sender, EventArgs e)
        {
            if (frm_ChooseQuantityBuy.Amount > 0)
            {
                if (!ProductExist())
                {
                    SCP.Product = Product;
                    SCP.Quantity = frm_ChooseQuantityBuy.Amount;
                    SCP.Iva = ((Product.Price * Product.Iva) / 100) * SCP.Quantity;
                    SCP.TotalPrice = Product.Price * SCP.Quantity;

                    BuyList.Add(SCP);
                }
                else
                {
                    foreach (ShoppingCart sc in BuyList)
                    {
                        sc.Quantity += frm_ChooseQuantityBuy.Amount;
                        sc.Iva += ((Product.Price * Product.Iva) / 100) * SCP.Quantity;
                        sc.TotalPrice += Product.Price * SCP.Quantity;
                    }
                }

                dGrid_Cart.DataSource = null;
                dGrid_Cart.DataSource = BuyList;
                txt_Barcode.ResetText();
            }
            else
            {
                MessageBox.Show("Ingrese una Cantidad Válida", "¡Atencion!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ProductExist()
        {
            foreach (ShoppingCart SC in BuyList)
            {
                if (SC.Product.Barcode == txt_Barcode.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void dGrid_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                lbl_Remove.Visible = true;
                btn_Remove.Visible = true;

                ShoppingCart sc = BuyList[e.RowIndex];
                barcodeQuit = sc.Product.Barcode;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            lbl_Remove_Click(sender, e);
        }

        private void lbl_Remove_Click(object sender, EventArgs e)
        {
            if (barcodeQuit != "")
            {
                ShoppingCart prd = null;

                foreach (ShoppingCart sc in BuyList)
                {
                    if (sc.Product.Barcode == barcodeQuit)
                    {
                        prd = sc;
                    }
                }

                if (prd != null)
                {
                    BuyList.Remove(prd);
                }

                barcodeQuit = "";
                dGrid_Cart.DataSource = null;

                if (dGrid_Cart.RowCount > 0)
                {
                    dGrid_Cart.DataSource = BuyList;
                }

                lbl_Remove.Visible = false;
                btn_Remove.Visible = false;
            }
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NumFactura.Text != "")
                {
                    if (Provider != null)
                    {
                        if (BuyList.Count > 0)
                        {
                            DialogResult result = MessageBox.Show("Confimar", "Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {

                                MercaFacil_2DataSetTableAdapters.Factura_CompraTableAdapter taf
                                        = new MercaFacil_2DataSetTableAdapters.Factura_CompraTableAdapter();

                                taf.Insert(txt_NumFactura.Text, System.DateTime.Now, Provider.Id);

                                MercaFacil_2DataSetTableAdapters.Detalle_Factura_CompraTableAdapter tadf
                                        = new MercaFacil_2DataSetTableAdapters.Detalle_Factura_CompraTableAdapter();
                                    
                                foreach (ShoppingCart sc in BuyList)
                                {
                                    tadf.Insert(txt_NumFactura.Text, sc.Product.Barcode, sc.Quantity, (sc.TotalPrice + sc.Iva));
                                    tap.IncreStock(sc.Quantity, sc.Product.Barcode);
                                }

                                MdiParent parent = (MdiParent)this.MdiParent;

                                parent.logTA.Insert("Se registró una compra", "compra", System.DateTime.Now, parent.CurrentUser.Id);

                                BuyList.Clear();
                                dGrid_Cart.DataSource = null;
                                lbl_Vendor.Visible = false;
                                Provider = null;
                                txt_NumFactura.Text = "F0000 - 0000";
                                txt_Barcode.ResetText();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un Proveedor", "¡Atencion!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, Digite un Número Válido", "¡Atencion!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btn_Shop_Click(sender, e);
        }
    }
}
