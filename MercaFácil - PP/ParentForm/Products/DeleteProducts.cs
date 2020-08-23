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
    public partial class DeleteProducts : Form
    {

        //VARIABLES

        string id_Product;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter tap = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();
        public DeleteProducts()
        {
            InitializeComponent();
            btn_DeleteProduct.Visible = false;
        }

        private void txt_Product_TextChanged(object sender, EventArgs e)
        {
            if (txt_Product.Text != "")
            {
                grid_SearchProducts.DataSource = productoBindingSource;
                this.productoTableAdapter.FillByNombre(this.mercaFacil_2DataSet.Producto, txt_Product.Text);

            }
            else
            {
                grid_SearchProducts.DataSource = "";
                return;
            }
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                id_Product = grid_SearchProducts.SelectedRows[0].Cells[0].Value.ToString();

                tap.LogicDelete(id_Product);
                MdiParent parent = (MdiParent)this.MdiParent;
                parent.logTA.Insert("Producto Eliminado", "Eliminación Producto", System.DateTime.Now, parent.CurrentUser.Id);

                this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_SearchProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_DeleteProduct.Visible = true;
            }
        }
    }
}
