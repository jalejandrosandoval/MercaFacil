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
    public partial class CreateVendor : Form
    {
        MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter tapo;

        public CreateVendor()
        {
            InitializeComponent();
        }

        private void btn_CreateVendor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NIT.Text != "" && txt_Name.Text != "" && txt_Neighborhood.Text != "" && txt_Address.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Desea Agregar el Proveedor?", "Agregar Proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        string nit = txt_NIT.Text;
                        string name = txt_Name.Text;
                        string neigh = txt_Neighborhood.Text;
                        string adress = txt_Address.Text;

                        tapo = new MercaFacil_2DataSetTableAdapters.ProveedorTableAdapter();
                        tapo.Insert(nit, name, neigh, adress, 0);

                        MdiParent parent = (MdiParent)this.MdiParent;
                        parent.logTA.Insert("Proveedor registrado", "Registro Proveedor", System.DateTime.Now, parent.CurrentUser.Id);

                        txt_NIT.ResetText();
                        txt_Name.ResetText();
                        txt_Address.ResetText();
                        txt_Neighborhood.ResetText();
                    }
                }
                else
                {
                    MessageBox.Show("Llene Correctamente los Datos...", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
