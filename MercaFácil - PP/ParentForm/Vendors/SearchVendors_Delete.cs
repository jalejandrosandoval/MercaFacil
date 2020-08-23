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
    public partial class SearchVendors_Delete : Form
    {

        //VARIABLES

        int id_Vendor;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter tap 
            = new MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();
        
        public SearchVendors_Delete()
        {
            InitializeComponent();
            btn_EditProvider1.Visible = false;
        }

        private void txt_Provider1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Provider1.Text != "")
            {
                grid_SearchVendors1.DataSource = proveedorBindingSource;
                this.proveedorTableAdapter.FillByName(this.mercaFacil_2DataSet.Proveedor, txt_Provider1.Text);
            }
            else
            {
                grid_SearchVendors1.DataSource = "";
                return;
            }
        }

        private void btn_EditProvider1_Click(object sender, EventArgs e)
        {
            try
            {
                id_Vendor = Convert.ToInt32(grid_SearchVendors1.SelectedRows[0].Cells[0].Value.ToString());

                tap.LogicDelete(id_Vendor);

                MdiParent parent = (MdiParent)this.MdiParent;
                parent.logTA.Insert("Proveedor Eliminado", "Eliminación Proveedor", System.DateTime.Now, parent.CurrentUser.Id);

                this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_SearchVendors1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_EditProvider1.Visible = true;
            }
        }
    }
}
