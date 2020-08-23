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
    public partial class DeleteClients : Form
    {
        //VARIABLES

        int id_Client;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ClienteTableAdapter tac 
            = new MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();

        public DeleteClients()
        {
            InitializeComponent();
            btn_DeleteClient.Visible = false;
        }

        private void txt_Client1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Client1.Text != "")
            {
                grid_SearchClients.DataSource = clienteBindingSource;
                this.clienteTableAdapter.FillByName(this.mercaFacil_2DataSet.Cliente, txt_Client1.Text);
            }
            else
            {
                grid_SearchClients.DataSource = "";
                return;
            }
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                id_Client = Convert.ToInt32(grid_SearchClients.SelectedRows[0].Cells[0].Value.ToString());

                tac.LogicDelete(id_Client);
                MdiParent parent = (MdiParent)this.MdiParent;
                parent.logTA.Insert("Eliminación de cliente", "Se eliminó un cliente", System.DateTime.Now, parent.CurrentUser.Id);

                this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grid_SearchClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_DeleteClient.Visible = true;
            }
        }
    }
}
