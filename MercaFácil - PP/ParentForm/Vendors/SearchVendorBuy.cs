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
    public partial class SearchVendorBuy : Form
    {
        //FORMS
        Compras frm_Buys;

        //Variables
        public int id_VendorBuy;

        //DATASET
        MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter tap 
            = new MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();

        MercaFacil_2DataSet.ProveedorDataTable answer;

        public SearchVendorBuy(Compras Buys)
        {
            InitializeComponent();
            frm_Buys = Buys;
            
            btn_SelectProvider.Visible = false;

        }

        private void txt_Provider_TextChanged(object sender, EventArgs e)
        {
            if (txt_Provider.Text != "")
            {
                grid_SearchVendors.DataSource = proveedorBindingSource;
                this.proveedorTableAdapter.FillByName(this.mercaFacil_2DataSet.Proveedor, txt_Provider.Text);
            }
            else
            {                
                grid_SearchVendors.DataSource = "";             
            }
        }

        private void grid_SearchVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                btn_SelectProvider.Visible = true;
            }
        }

        private void btn_SelectProvider_Click(object sender, EventArgs e)
        {
            try
            {
                id_VendorBuy = Convert.ToInt32(grid_SearchVendors.SelectedRows[0].Cells[0].Value.ToString());

                answer = tap.GetDataById(id_VendorBuy);
                frm_Buys.Provider = answer[0];
                frm_Buys.lbl_Vendor.Text = "Provedor: \n"+frm_Buys.Provider.Nombre;
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
