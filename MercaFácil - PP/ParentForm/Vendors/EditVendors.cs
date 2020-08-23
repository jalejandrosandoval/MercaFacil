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
    public partial class OptionsVendors : Form
    {
        //FORMS

        SearchVendors frm_searchVendors;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter tap
            = new MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();

        public OptionsVendors()
        {
            InitializeComponent();
        }

        private void lklb_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchVendors = new SearchVendors(this);
            frm_searchVendors.Show();
            this.Hide();
        }

        private void btn_EditVendor_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está Seguro de Modificar este Producto?", "Modificar Producto",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txt_NIT.Text != "" && txt_Name.Text != "" && txt_Adress.Text != "" && txt_Neighborhood.Text != "")
                    {
                        string Nit = txt_NIT.Text;
                        string Name = txt_Name.Text;
                        string Address = txt_Adress.Text;
                        string Neighborhood = txt_Neighborhood.Text;

                        tap.UpdateQueryVendor(Nit,Name,Address,Neighborhood,0, frm_searchVendors.id_Vendor);

                        MdiParent parent = (MdiParent)this.MdiParent;
                        parent.logTA.Insert("Proveedor Editado", "Actualización Proveedor", System.DateTime.Now, parent.CurrentUser.Id);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Llene Correctamente los Datos...", "Modificar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
}
