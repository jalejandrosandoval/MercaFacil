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
    public partial class SearchUser : Form
    {

        //Variable 
        public int id_User;

        //Forms
        OptionsUsers frm_EditUsers;

        //DATASETS
        MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter tau = new MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();
        MercaFacil_2DataSet.UsuarioDataTable answer;

        public SearchUser(OptionsUsers father)
        {
            InitializeComponent();
            frm_EditUsers = father;
            btn_EditUser.Visible = false;
        }

        private void txt_Users_TextChanged(object sender, EventArgs e)
        {
            if (txt_Users.Text != "")
            {
                grid_SearchUsers.DataSource = usuarioBindingSource;

                this.usuarioTableAdapter.FillByNameErase(this.mercaFacil_2DataSet.Usuario, txt_Users.Text);
            }
            else
            {
                grid_SearchUsers.DataSource = "";
                return;
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            try
            {
                id_User = Convert.ToInt32(grid_SearchUsers.SelectedRows[0].Cells[0].Value.ToString());

                answer = tau.GetDataById(id_User);

                frm_EditUsers.txt_Identification.Text = answer[0].Numero_Identificacion.ToString();
                frm_EditUsers.txt_FirstName.Text = answer[0].Nombres.ToString();
                frm_EditUsers.txt_LastName.Text = answer[0].Apellidos.ToString();
                frm_EditUsers.dtp_Birthdate.Text = answer[0].Fecha_Nacimiento.ToString();
                frm_EditUsers.txt_Neighborhood.Text = answer[0].Dir_Barrio.ToString();
                frm_EditUsers.txt_Adress.Text = answer[0].Dir_Numero.ToString();
                frm_EditUsers.cmb_UserType.Text = answer[0].Tipo_Usuario.ToString();
                frm_EditUsers.txt_User.Text = answer[0].Usuario.ToString();
                frm_EditUsers.txt_Password.Text = answer[0].Contrasena.ToString();

                frm_EditUsers.Found = true;

                this.Close();
                frm_EditUsers.Show();


            }
            catch (Exception err)
            {
                MessageBox.Show("Error al Modificar! Seleccione un usuario que sea valido" + err.Message, "Modificar Usuario",
                  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void grid_SearchUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_EditUser.Visible = true;
            }
        }
    }
}
