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
    public partial class EdittelephoneClient : Form
    {
       
        //VARIABLES

        int id_Telephone;
        int id_Client;
        int id_user;

        public string identification;
        string telephone;

        DialogResult result;

        //FORMS

        Add_Edit_Telephone frm_Add_Edit_Telephone;
        Edit_Telephone_Client_Event frm_Edit_Telephone_Client_Event;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter tatc
            = new MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter();

        MercaFacil_2DataSet.Telefono_ClienteDataTable res;

        public EdittelephoneClient(int id, int iduser)
        {
            InitializeComponent();
            id_Client = id;
            id_user = iduser;

            btn_Edit_Telephone.Visible = false;
            btn_Delete_Telephone.Visible = false;
        }

        private void EdittelephoneClient_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaFacil_2DataSet.Telefono_Cliente' Puede moverla o quitarla según sea necesario.
            this.telefono_ClienteTableAdapter.Fill_By_Id(this.mercaFacil_2DataSet.Telefono_Cliente, id_Client); 
        }

        private void btn_Edit_Telephone_Click(object sender, EventArgs e)
        {
            frm_Edit_Telephone_Client_Event = new Edit_Telephone_Client_Event(identification ,id_Client, id_Telephone, id_user);
            frm_Edit_Telephone_Client_Event.MdiParent = this.MdiParent;
            frm_Edit_Telephone_Client_Event.Show();

            this.Close();
        }

        private void btn_Delete_Telephone_Click(object sender, EventArgs e)
        {
            try
            {
                result = MessageBox.Show("¿Desea Eliminar el Telefono de este Cliente?", "Eliminar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    tatc.DeleteQuery(id_Telephone);
                }

                telefonoClienteBindingSource.ResetBindings(false);

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_Telephones_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_Edit_Telephone.Visible = true;
                btn_Delete_Telephone.Visible = true;

                id_Telephone = Convert.ToInt32(grid_Telephones_Clients.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
