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
    public partial class SearchProductscs : Form
    {

        //Variables
        public string Barcode;

        //Forms
        OptionsProducts frm_EditProducts;

        //DATASETS
        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter tap = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();
        MercaFacil_2DataSet.ProductoDataTable answer; 

        public SearchProductscs(OptionsProducts father)
        {
            InitializeComponent();

            frm_EditProducts = father;

            btn_EditProducts.Visible = false;
        }

        private void txt_Products_TextChanged(object sender, EventArgs e)
        {
            if (txt_Products.Text != "")
            {
                grid_SearchProducts.DataSource = productoBindingSource;

                this.productoTableAdapter.FillByNombre(this.mercaFacil_2DataSet.Producto, txt_Products.Text);
            }
            else
            {
                grid_SearchProducts.DataSource = "";
                return;
            }
        }

        private void btn_EditProducts_Click(object sender, EventArgs e)
        {
            

            try
            {
                Barcode = grid_SearchProducts.SelectedRows[0].Cells[0].Value.ToString();

                answer = tap.GetDataByCodBarras(Barcode);

                frm_EditProducts.txt_Code.Text = answer[0].Codigo_Barras.ToString();
                frm_EditProducts.cmb_TypeProduct.Text = answer[0].Tipo_Producto.ToString();
                frm_EditProducts.txt_Name.Text = answer[0].Nombre.ToString();
                frm_EditProducts.txt_Description.Text = answer[0].Descripcion.ToString();
                frm_EditProducts.txt_Amount.Text = answer[0].Stock.ToString();
                frm_EditProducts.txt_Price.Text = answer[0].Precio_Venta.ToString();
                frm_EditProducts.txt_vIva.Text = answer[0].Porcentaje_Iva.ToString();

                this.Close();
                frm_EditProducts.Show();
                frm_EditProducts.found = true;

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Modificar! Seleccione un producto que sea Valido... Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grid_SearchProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_EditProducts.Visible = true;
            }
        }
    }
}
