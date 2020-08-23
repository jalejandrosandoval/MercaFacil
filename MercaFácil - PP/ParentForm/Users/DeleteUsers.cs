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
    public partial class DeleteUsers : Form
    {
        //VARIABLES

        int id_Users;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter tau 
            = new MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();

        public DeleteUsers()
        {
            InitializeComponent();
            btn_DeleteUser.Visible = false;
        }

        private void txt_Users_TextChanged(object sender, EventArgs e)
        {
            if (txt_Users.Text != "")
            {
                grid_DeleteUsers.DataSource = usuarioBindingSource;
                this.usuarioTableAdapter.FillByName(this.mercaFacil_2DataSet.Usuario, txt_Users.Text);
            }
            else
            {
                grid_DeleteUsers.DataSource = "";
                return;
            }
        }

        private void grid_DeleteUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_DeleteUser.Visible = true;
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                id_Users = Convert.ToInt32(grid_DeleteUsers.SelectedRows[0].Cells[0].Value.ToString());

                tau.LogicDelete(id_Users);

                MdiParent parent = (MdiParent)this.MdiParent;
                parent.logTA.Insert("Eliminación de usuario", "Se ha Eliminado un usuario", System.DateTime.Now, parent.CurrentUser.Id);

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
