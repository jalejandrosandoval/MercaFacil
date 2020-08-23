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
    public partial class Ventas : Form
    {
        //Forms

        MdiParent parent;

        ChooseQuantity cQuantity;

        //Dataset 

        MercaFacil_2DataSet.ProductoRow ProductSelected;

        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter pta;
        MercaFacil_2DataSet.ProductoDataTable answer;

        MercaFacil_2DataSetTableAdapters.Detalle_Factura_VentaTableAdapter dFVenta;
        MercaFacil_2DataSetTableAdapters.Factura_VentaTableAdapter fVenta;

        MercaFacil_2DataSetTableAdapters.Detalle_ProductoTableAdapter detallePTA;
        MercaFacil_2DataSet.Detalle_ProductoDataTable detalles;
          

        public MercaFacil_2DataSet.ClienteRow Client { get; set; }

        //Variables

        string barcodeQuit = "";

        Product Product;
        ShoppingCart SCP;

        List<ShoppingCart> CartList;

        public Ventas()
        {
            InitializeComponent();
            Product = new Product();
            SCP = new ShoppingCart();
            CartList = new List<ShoppingCart>();
            lbl_Remove.Visible = false;
            btn_Cancel.Visible = false;
            lbl_Client.Visible = false;
            lbl_currentPrice.Visible = false;
            lbl_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            pta = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();
            parent = (MdiParent)this.MdiParent;
            lbl_empleado.Text = "Le Atiende: " + parent.CurrentUser.Nombres;
        }

        private bool ProductExist()
        {
            foreach (ShoppingCart SC in CartList)
            {
                if (SC.Product.Barcode == txt_barcode.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void ActCurrentPrice()
        {
            int sum = 0;

            foreach (ShoppingCart sc in CartList)
            {
                sum += sc.TotalPrice;
            }

            if (sum != 0)
            {
                lbl_currentPrice.Text = "Precio: $" + sum;
                lbl_currentPrice.Visible = true;
            }
            else
            {
                lbl_currentPrice.Visible = false;
                lbl_currentPrice.Text = "";
                dGrid_ShoppingCart.DataSource = null;
            }
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {               
                    answer = pta.GetDataByCodBarras(txt_barcode.Text);

                    if(answer.Count > 0)
                    {
                        if (checkBox_DeleteProductSP.Checked == true)
                        {
                            if (ProductExist())
                            {
                                ShoppingCart prod = null;

                                foreach (ShoppingCart prd in CartList)
                                {
                                    if (prd.Product.Barcode == txt_barcode.Text)
                                    {
                                        if (prd.Quantity == 1)
                                        {
                                            prod = prd;
                                        }
                                        else
                                        {
                                            prd.Quantity--;
                                            prd.TotalPrice -= prd.Product.Price;
                                            prd.Iva -= (prd.Product.Price * prd.Product.Iva) / 100;
                                        }

                                        break;
                                    }
                                }

                                if (prod != null)
                                {
                                    CartList.Remove(prod);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Producto Inexistente en Carrito", "Ventas",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if(checkBox_DeleteQuantity.Checked == true)
                            {
                                if (ProductExist())
                                {
                                    foreach (ShoppingCart prd in CartList)
                                    {
                                        if (prd.Product.Barcode == txt_barcode.Text)
                                        {
                                            cQuantity = new ChooseQuantity(this, prd.Quantity);
                                            cQuantity.Show();

                                            cQuantity.FormClosed += new FormClosedEventHandler(DeleteQuantity);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    txt_barcode.ResetText();

                                    MessageBox.Show("Producto Inexistente en Carrito", "Ventas",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                
                            }
                            else
                            {
                                Product = new Product();
                                SCP = new ShoppingCart();

                                ProductSelected = answer[0];

                                Product.Barcode = ProductSelected.Codigo_Barras;
                                Product.Name = ProductSelected.Nombre;
                                Product.Description = ProductSelected.Descripcion;
                                Product.Price = ProductSelected.Precio_Venta;
                                Product.Iva = ProductSelected.Porcentaje_Iva;
                                Product.Stock = ProductSelected.Stock;
                                Product.TypeProduct = ProductSelected.Tipo_Producto;
                                Product.Borrado = ProductSelected.Borrado;

                                if (checkBox_AddQuantity.Checked == true)
                                {
                                    bool status = false;

                                    foreach (ShoppingCart sc in CartList)
                                    {
                                        if (sc.Product.Barcode == txt_barcode.Text)
                                        {
                                            cQuantity = new ChooseQuantity(this, (Product.Stock - sc.Quantity));
                                            status = true;
                                            break;
                                        }

                                    }

                                    if (status == false)
                                    {
                                        cQuantity = new ChooseQuantity(this, Product.Stock);
                                    }

                                    cQuantity.Show();
                                    cQuantity.FormClosed += new FormClosedEventHandler(AddQuantity);                                   
                                   
                                }
                                else
                                {
                                    
                                    if (!ProductExist())
                                    {
                                        if (Product.Stock > 0)
                                        {
                                            SCP.Product = Product;
                                            SCP.Quantity = 1;
                                            SCP.TotalPrice = SCP.Product.Price * SCP.Quantity;
                                            SCP.Iva = (SCP.Product.Price * SCP.Product.Iva) / 100;

                                            CartList.Add(SCP);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cantidades Insuficientes", "Ventas",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        
                                    }
                                    else
                                    {
                                        foreach (ShoppingCart prd in CartList)
                                        {
                                            if (prd.Product.Barcode == txt_barcode.Text)
                                            {
                                                if (prd.Quantity + 1 <= Product.Stock)
                                                {
                                                    prd.Quantity++;
                                                    prd.TotalPrice += prd.Product.Price;
                                                    prd.Iva += (prd.Product.Price * prd.Product.Iva) / 100;
                                                    break;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Cantidades Insuficientes", "Ventas",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }

                        ActCurrentPrice();
                    }
                    else
                    {
                        MessageBox.Show("Producto Inexistente", "Ventas",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch(Exception err)
                {
                    MessageBox.Show("" + err);
                }

                dGrid_ShoppingCart.DataSource = null;
                dGrid_ShoppingCart.DataSource = CartList;

                if (checkBox_AddQuantity.Checked == false && checkBox_DeleteQuantity.Checked == false)
                {
                    txt_barcode.Clear();
                }
            }
        }

        public void AddQuantity(object sender, EventArgs e)
        {
            if (cQuantity.Amount != 0)
            {
                if (!ProductExist())
                {
                    SCP.Product = Product;
                    SCP.Quantity = cQuantity.Amount;
                    SCP.TotalPrice = SCP.Product.Price * SCP.Quantity;
                    SCP.Iva = ((SCP.Product.Price * SCP.Product.Iva) / 100) * SCP.Quantity;

                    CartList.Add(SCP);                    
                }
                else
                {
                    foreach (ShoppingCart prd in CartList)
                    {
                        if (prd.Product.Barcode == txt_barcode.Text)
                        {                            
                            prd.Quantity += cQuantity.Amount;
                            prd.TotalPrice += prd.Product.Price * prd.Quantity;
                            prd.Iva += ((prd.Product.Price * prd.Product.Iva) / 100) * prd.Quantity;              
                            
                        }
                    }
                }

                dGrid_ShoppingCart.DataSource = null;
                dGrid_ShoppingCart.DataSource = CartList;

                txt_barcode.Clear();
                ActCurrentPrice();
            }
        }

        public void DeleteQuantity(object sender, EventArgs e)
        {
            if (cQuantity.Amount != 0)
            {
                ShoppingCart sc = null;

                foreach (ShoppingCart prd in CartList)
                {
                    if (prd.Product.Barcode == txt_barcode.Text)
                    {
                        if (prd.Quantity == cQuantity.Amount)
                        {
                            sc = prd;
                        }
                        else
                        {
                            prd.Quantity -= cQuantity.Amount;
                            prd.TotalPrice -= prd.Product.Price * cQuantity.Amount;
                            prd.Iva -= ((prd.Product.Price * prd.Product.Iva) / 100) * cQuantity.Amount;
                        }

                        break;
                    }
                }

                if (sc != null)
                {
                    CartList.Remove(sc);
                }

                dGrid_ShoppingCart.DataSource = null;
                dGrid_ShoppingCart.DataSource = CartList;

                txt_barcode.ResetText();
                ActCurrentPrice();
            }
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            if (Client != null)
            {
                if (CartList.Count > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Confimar", "Venta", 
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    /*
                    if (result == DialogResult.OK)
                    {

                        MercaFacil_2DataSetTableAdapters.Parametros_facturaTableAdapter pfta
                        = new MercaFacil_2DataSetTableAdapters.Parametros_facturaTableAdapter();

                        MercaFacil_2DataSet.Parametros_facturaDataTable parametros;

                        fVenta = new MercaFacil_2DataSetTableAdapters.Factura_VentaTableAdapter();

                        parametros = pfta.GetDataById((int)pfta.MaxId());

                        int date;
                        
                        date = DateTime.Compare(System.DateTime.Now, parametros[0].Vigencia);

                        if (date < 0 && fVenta.MaxIdFact() + 1 <= parametros[0].Valor_final)
                        {
                            MdiParent parent = (MdiParent)this.MdiParent;
                            dFVenta = new MercaFacil_2DataSetTableAdapters.Detalle_Factura_VentaTableAdapter();

                            fVenta.Insert(System.DateTime.Now, Client.Id, parent.CurrentUser.Id, 0, parametros[0].Id);

                            parent.logTA.Insert("Se generó una factura", "Venta", System.DateTime.Now, parent.CurrentUser.Id);


                            int NumFact = (int)fVenta.MaxIdFact();

                            foreach (ShoppingCart sc in CartList)
                            {
                                dFVenta.Insert(NumFact, sc.Product.Barcode, sc.Quantity, (sc.TotalPrice + sc.Iva), 0);
                                parent.logTA.Insert("Se Registró agregó un producto a la venta", "Venta", System.DateTime.Now, parent.CurrentUser.Id);
                                UpdateDetail(sc.Product.Barcode, sc.Quantity);
                            }

                            ReportFactForm rfact = new ReportFactForm(NumFact);
                            rfact.Show();

                            dGrid_ShoppingCart.DataSource = null;
                            Client = null;
                            lbl_currentPrice.Visible = false;
                            lbl_Client.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Imposible facturar, por favor, actualice la resolución", "Ventas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }*/

                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un producto", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Asigne un Cliente", "Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SearchClient_Click(object sender, EventArgs e)
        {
            SearchClient sClient = new SearchClient(this);
            sClient.Show();
        }

        private void btn_addClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void dGrid_ShoppingCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!e.RowIndex.Equals(-1))
            {
                lbl_Remove.Visible = true;
                btn_Cancel.Visible = true;

                ShoppingCart sc = CartList[e.RowIndex];

                barcodeQuit = sc.Product.Barcode;

                
            }
        }

        private void lbl_Remove_Click(object sender, EventArgs e)
        {
            if(barcodeQuit != "")
            {
                ShoppingCart prd = null;

                foreach(ShoppingCart sc in CartList)
                {
                    if(sc.Product.Barcode == barcodeQuit)
                    {
                        prd = sc;
                    }
                }

                if(prd != null)
                {
                    CartList.Remove(prd);
                }

                barcodeQuit = "";
                dGrid_ShoppingCart.DataSource = null;

                if (dGrid_ShoppingCart.RowCount > 0)
                {
                    dGrid_ShoppingCart.DataSource = CartList;
                }

                ActCurrentPrice();


                lbl_Remove.Visible = false;
                btn_Cancel.Visible = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            lbl_Remove_Click(sender, e);
        }        

        private void checkBox_AddQuantity_Click(object sender, EventArgs e)
        {
            checkBox_DeleteProductSP.Checked = false;
            checkBox_DeleteQuantity.Checked = false;

            if (checkBox_AddQuantity.Checked == true)
            {
                txt_barcode.BackColor = Color.Blue;
                lbl_Unity.Text = "Agregar Cantidad";

            } else
            {
                txt_barcode.BackColor = Color.White;
                lbl_Unity.Text = "Agregar Unidad";
            }

            txt_barcode.Focus();
        }

        private void checkBox_DeleteQuantity_Click(object sender, EventArgs e)
        {
            checkBox_DeleteProductSP.Checked = false;
            checkBox_AddQuantity.Checked = false;

            if (checkBox_DeleteQuantity.Checked == true)
            {
                txt_barcode.BackColor = Color.Red;
                lbl_Unity.Text = "Eliminar Cantidad";
            }
            else
            {
                txt_barcode.BackColor = Color.White;
                lbl_Unity.Text = "Agregar Unidad";
            }

            txt_barcode.TabIndex = 0;
            txt_barcode.Focus();
        }

        private void checkBox_DeleteProductSP_Click(object sender, EventArgs e)
        {
            checkBox_DeleteQuantity.Checked = false;
            checkBox_AddQuantity.Checked = false;

            if (checkBox_DeleteProductSP.Checked == true)
            {
                txt_barcode.BackColor = Color.IndianRed;
                lbl_Unity.Text = "Eliminar Unidad";
            }
            else
            {
                txt_barcode.BackColor = Color.White;
                lbl_Unity.Text = "Agregar Unidad";
            }

            txt_barcode.TabIndex = 0;
            txt_barcode.Focus();

        }

        private void UpdateDetail(string barcode, int cant)
        {
            detallePTA = new MercaFacil_2DataSetTableAdapters.Detalle_ProductoTableAdapter();

            detalles = detallePTA.GetDataByCod(barcode);

            if(detalles.Count > 0)
            {
                detallePTA.ActDetails((int)cant, barcode);                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            btn_Shop_Click(sender, e);
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
