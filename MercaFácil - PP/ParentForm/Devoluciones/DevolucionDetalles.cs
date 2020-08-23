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
    public partial class DevolucionDetalles : Form
    {
        MercaFacil_2DataSetTableAdapters.ClienteTableAdapter tac
            = new MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();

        MercaFacil_2DataSet.ClienteDataTable answerC;

        MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter tau
            = new MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();

        MercaFacil_2DataSet.UsuarioDataTable answerU;

        MercaFacil_2DataSetTableAdapters.Factura_VentaTableAdapter fvta
            = new MercaFacil_2DataSetTableAdapters.Factura_VentaTableAdapter();

        MercaFacil_2DataSet.Factura_VentaDataTable answerFv;

        MercaFacil_2DataSetTableAdapters.Devolucion_VentaTableAdapter dvta
            = new MercaFacil_2DataSetTableAdapters.Devolucion_VentaTableAdapter();

        MercaFacil_2DataSetTableAdapters.Detalle_Devolucion_VentaTableAdapter ddvta
            = new MercaFacil_2DataSetTableAdapters.Detalle_Devolucion_VentaTableAdapter();

        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter pta
            = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();

        MercaFacil_2DataSetTableAdapters.Detalle_Factura_VentaTableAdapter dfvta
            = new MercaFacil_2DataSetTableAdapters.Detalle_Factura_VentaTableAdapter();

        List<ShoppingCart> returnList;

        string barcode = "";
        int nFactura = 0;

        int limit = 0;
        int amount = 0;

        int id_user;

        ShoppingCart SC;
        Product prd;
        MercaFacil_2DataSet.ProductoDataTable producto;


        public DevolucionDetalles(int numFact, int iduser)
        {
            InitializeComponent();

            btn_Minus.Visible = false;
            btn_Plus.Visible = false;
            btn_Return.Visible = false;
            txt_Amount.Visible = false;

            nFactura = numFact;
            id_user = iduser;

            lbl_Amount.Text = "Por favor, \nseleccione un producto \na devolver.";

            answerFv = fvta.GetDataByNumFact(numFact);
            answerU = tau.GetDataById(answerFv[0].Usuario_Id);
            answerC = tac.Show_By_Id(answerFv[0].Cliente_Id);

            lbl_UsuarioName.Text = answerU[0].Nombres.ToString();
            lbl_ClientName.Text = answerC[0].Nombres.ToString();
            lbl_NumFact.Text = numFact.ToString().PadLeft(4, '0') ;

            returnList = new List<ShoppingCart>();

            dGrid_Dev.DataSource = returnList;
        }

        private void DevolucionDetalles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaFacil_2DataSet.Detalle_Factura_Venta' Puede moverla o quitarla según sea necesario.
            this.detalle_Factura_VentaTableAdapter.FillByNumFact(this.mercaFacil_2DataSet.Detalle_Factura_Venta, answerFv[0].Numero_Factura);

        }

        private void dGrid_detailReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_Minus.Visible = true;
                btn_Plus.Visible = true;
                btn_Return.Visible = true;
                txt_Amount.Visible = true;

                barcode = dGrid_detailReturn.SelectedRows[0].Cells[1].Value.ToString();
                limit = Convert.ToInt32(dGrid_detailReturn.SelectedRows[0].Cells[2].Value.ToString());

                lbl_Amount.Text = "Seleccione \ncantidad";
            }
        }

        private bool Exist()
        {
            foreach(ShoppingCart sc in returnList)
            {
                if(sc.Product.Barcode == barcode)
                {
                    return true;
                }
            }

            return false;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                bool number = int.TryParse(txt_Amount.Text, out int n);

                if (number)
                {
                    if (txt_Amount.Text != "" && Convert.ToInt32(txt_Amount.Text) > 0 && Convert.ToInt32(txt_Amount.Text) <= limit)
                    {
                        amount = Convert.ToInt32(txt_Amount.Text);
                        SC = new ShoppingCart();
                        prd = new Product();

                        producto = pta.GetDataByCodBarras(barcode);

                        if (!Exist())
                        {
                            prd.Barcode = barcode;
                            prd.Borrado = producto[0].Borrado;
                            prd.Description = producto[0].Descripcion;
                            prd.Iva = producto[0].Porcentaje_Iva;
                            prd.Name = producto[0].Nombre;
                            prd.Price = producto[0].Precio_Venta;
                            prd.Stock = producto[0].Stock;

                            SC.Product = prd;
                            SC.Quantity = amount;
                            SC.Iva = ((SC.Product.Iva * SC.Product.Price) / 100) * SC.Quantity;
                            SC.TotalPrice = SC.Product.Price * SC.Quantity;

                            returnList.Add(SC);
                        }
                        else
                        {
                            foreach (ShoppingCart prod in returnList)
                            {
                                if (prod.Product.Barcode == barcode)
                                {
                                    if ((limit - prod.Quantity) >= amount)
                                    {
                                        prod.Quantity += amount;
                                        SC.Iva += ((SC.Product.Iva * SC.Product.Price) / 100) * SC.Quantity;
                                        SC.TotalPrice += SC.Product.Price * SC.Quantity;
                                    }
                                }
                            }
                        }


                        limit = 0;
                        amount = 0;
                        barcode = "";
                        dGrid_Dev.DataSource = null;
                        dGrid_Dev.DataSource = returnList;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Valor válido", "Devolución",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese un entero válido");
                }

                
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Plus_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text == "")
                {
                    txt_Amount.Text = "1";
                }
                else
                {
                    int n = Convert.ToInt32(txt_Amount.Text);
                    n++;
                    txt_Amount.Text = n.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }
        }

        private void btn_Minus_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text != "")
                {
                    if (txt_Amount.Text == "1")
                    {
                        txt_Amount.Text = "";
                    }
                    else
                    {
                        int n = Convert.ToInt32(txt_Amount.Text);
                        n--;
                        txt_Amount.Text = n.ToString();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(" " + error);
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            try
            {
                if (returnList.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Confimar Devolución", "Devolución", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {

                        MercaFacil_2DataSetTableAdapters.LogTableAdapter logta
                        = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                        dvta.Insert(nFactura, txt_Description.Text, System.DateTime.Now);

                        logta.Insert("Devolución", "Se creó una devolución", System.DateTime.Now, id_user);

                        result = MessageBox.Show("¿Desea Regresar los productos a la tienda?", "Devolución", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            foreach (ShoppingCart prd in returnList)
                            {
                                pta.IncreStock(prd.Quantity, prd.Product.Barcode);
                                logta.Insert("Se Aumentó Stock", "Debido a una devolución", System.DateTime.Now, id_user);
                            }
                        }

                        int id_return = (int)dvta.MaxId();

                        foreach (ShoppingCart prd in returnList)
                        {
                            ddvta.Insert(prd.Product.Barcode, id_return, prd.Quantity);
                            logta.Insert("Se registró una devolución", "Devolución", System.DateTime.Now, id_user);
                            dfvta.DevolverProducto(nFactura, prd.Product.Barcode);
                            logta.Insert("Se Devolvió un producto", "Devolución", System.DateTime.Now, id_user);
                        }

                        MercaFacil_2DataSet.Detalle_Factura_VentaDataTable detalleFact;

                        detalleFact = dfvta.GetDataByNumFact(nFactura);

                        bool dev = false;

                        foreach (MercaFacil_2DataSet.Detalle_Factura_VentaRow dfvr in detalleFact)
                        {
                            if (dfvr.Devuelto == 1)
                            {
                                dev = true;
                                break;
                            }
                        }

                        if (dev)
                        {
                            fvta.AnotarFactura(nFactura);
                            logta.Insert("Se anotó una factura", "Debido a devolución", System.DateTime.Now, id_user);
                        }

                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese al Menos un Producto", "Devolución", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }


            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
