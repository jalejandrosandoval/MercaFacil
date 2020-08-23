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
    public partial class SearchVendors : Form
    {

        //FORMS

        OptionsVendors frm_EditVendor;

        //VARIABLES

        public int id_Vendor;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter tap = new MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();
        MercaFacil_2DataSet.ProveedorDataTable res;

        public SearchVendors(OptionsVendors father)
        {
            InitializeComponent();
            frm_EditVendor = father;
            btn_EditProvider.Visible = false;
        }

        private void txt_Provider_TextChanged(object sender, EventArgs e)
        {
            if (txt_Provider.Text != "")
            {
                grid_SearchVendors.DataSource = proveedorBindingSource;
                this.proveedorTableAdapter.FillByNameErase(this.mercaFacil_2DataSet.Proveedor, txt_Provider.Text);
            }
            else
            {
                grid_SearchVendors.DataSource = "";
                return;
            }
        }

        private void btn_EditProvider_Click(object sender, EventArgs e)
        {
            try
            {
                id_Vendor = Convert.ToInt32(grid_SearchVendors.SelectedRows[0].Cells[0].Value.ToString());

                res = tap.GetDataById(id_Vendor);

                frm_EditVendor.txt_NIT.Text = res[0].Nit.ToString();
                frm_EditVendor.txt_Name.Text = res[0].Nombre.ToString();
                frm_EditVendor.txt_Adress.Text = res[0].Dir_Numero.ToString();
                frm_EditVendor.txt_Neighborhood.Text = res[0].Dir_Barrio.ToString();

                this.Close();
                frm_EditVendor.Show();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_SearchVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_EditProvider.Visible = true;
            }
        }

    }
}
