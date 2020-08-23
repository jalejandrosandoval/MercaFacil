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
    public partial class Edit_Num_User : Form
    {
        //VARIABLES

        int id_Telephone;
        int user_id;

        public string identification;
        string telephone;

        DialogResult result;

        //FORMS

        Edit_Telephone_User_Event frm_Edit_Telephone_User_Event;

        //DATASETS


        MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter tatu
            = new MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter();

        public Edit_Num_User(int iduser)
        {
            InitializeComponent();

            user_id = iduser;

            btn_Edit_Telephone.Visible = false;
            btn_Delete_Telephone.Visible = false;

            this.telefono_UsuarioTableAdapter.FillBy_By_Id(this.mercaFacil_2DataSet.Telefono_Usuario, user_id);
        }

        private void Edit_Num_User_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaFacil_2DataSet.Telefono_Usuario' Puede moverla o quitarla según sea necesario.
            this.telefono_UsuarioTableAdapter.FillBy_By_Id(this.mercaFacil_2DataSet.Telefono_Usuario, user_id);
        }

        private void grid_Telephones_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_Edit_Telephone.Visible = true;
                btn_Delete_Telephone.Visible = true;

                id_Telephone = Convert.ToInt32(grid_Telephones_Users.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btn_Edit_Telephone_Click(object sender, EventArgs e)
        {
            frm_Edit_Telephone_User_Event = new Edit_Telephone_User_Event(identification, user_id, id_Telephone);
            frm_Edit_Telephone_User_Event.MdiParent = this.MdiParent;
            frm_Edit_Telephone_User_Event.Show();
            this.Close();
        }

        private void btn_Delete_Telephone_Click(object sender, EventArgs e)
        {

            try
            {
                result = MessageBox.Show("¿Desea Eliminar el Telefono de este Usuario?", "Eliminar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    tatu.DeleteQuery(id_Telephone);

                }

                //telefonoUsuarioBindingSource.ResetBindings(false);

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
