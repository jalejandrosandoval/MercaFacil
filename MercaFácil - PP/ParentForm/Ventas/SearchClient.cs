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
    public partial class SearchClient : Form
    {
        Ventas frm_ventas;

        MercaFacil_2DataSetTableAdapters.ClienteTableAdapter tac
            = new MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();

        MercaFacil_2DataSet.ClienteDataTable res;

        public SearchClient(Ventas father)
        {
            InitializeComponent();

            frm_ventas = father;
            btn_EditClient.Visible = false;
        }
        private void txt_Client_TextChanged(object sender, EventArgs e)
        {
            if (txt_Client.Text != "")
            {
                grid_SearchClients.DataSource = clienteBindingSource;
                this.clienteTableAdapter.FillByName(this.mercaFacil_2DataSet.Cliente, txt_Client.Text);
            }
            else
            {
                grid_SearchClients.DataSource = "";
                return;
            }
        }

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(grid_SearchClients.SelectedRows[0].Cells[0].Value.ToString());

                res = tac.Show_By_Id(id);

                frm_ventas.Client = res[0];

                frm_ventas.lbl_Client.Text = "Cliente: " + frm_ventas.Client.Nombres;
                frm_ventas.lbl_Client.Visible = true;

                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Buscar Cliente",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_SearchClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_EditClient.Visible = true;
            }
        }
    }
}
