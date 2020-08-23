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
    public partial class SearchClients : Form
    {
        //VARIABLES

        public int id_Client;

        //FORMS

        OptionsClients frm_EditClients;        

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ClienteTableAdapter tac 
            = new MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();

        MercaFacil_2DataSet.ClienteDataTable res;
        
        public SearchClients(OptionsClients father)
        {
            InitializeComponent();

            frm_EditClients = father;
            btn_EditClient.Visible = false;
        }

        private void txt_Client_TextChanged(object sender, EventArgs e)
        {
            if (txt_Client.Text != "")
            {
                grid_SearchClients.DataSource = clienteBindingSource;
                this.clienteTableAdapter.FillByNameErase(this.mercaFacil_2DataSet.Cliente, txt_Client.Text);
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
                id_Client = Convert.ToInt32(grid_SearchClients.SelectedRows[0].Cells[0].Value.ToString());

                res = tac.Show_By_Id(id_Client);

                frm_EditClients.cmb_TypeIdentification.Text = res[0].Tipo_Identificacion.ToString();
                frm_EditClients.txt_Identification.Text = res[0].Numero_Identificacion.ToString();
                frm_EditClients.txt_FirstName.Text = res[0].Nombres.ToString();
                frm_EditClients.txt_LastName.Text = res[0].Apellidos.ToString();
                frm_EditClients.txt_Address.Text = res[0].Dir_Numero.ToString();
                frm_EditClients.txt_Neightborhood.Text = res[0].Dir_Barrio.ToString();

                frm_EditClients.Found = true;

                this.Close();
                frm_EditClients.Show();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
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
