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
    public partial class Edit_Telephone_Client_Event : Form
    {
        //VARIABLES

        int id_Client;
        int id_telephone;
        int id_user;
        string identificationClient;
        string telephone;

        DialogResult result;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter tatc
            = new MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter();

        MercaFacil_2DataSet.Telefono_ClienteDataTable res;

        public Edit_Telephone_Client_Event(string idenCli,int idClient, int idTelephone, int iduser)
        {
            InitializeComponent();

            id_Client = idClient;
            id_telephone = idTelephone;
            id_user = iduser;
            identificationClient = idenCli;
        }

        private void Edit_Telephone_Client_Event_Load(object sender, EventArgs e)
        {

            res = tatc.Show_By_Id(id_telephone);

            txt_NumTel.Text = res[0].Telefono.ToString();
            lbl_NumId.Text = identificationClient;
        }
        
        private void btn_Edit_Click(object sender, EventArgs e)
        {            
            try
            {
                if (txt_NumTel.Text != "")
                {
                    telephone = txt_NumTel.Text;

                    result = MessageBox.Show("¿Desea Editar el Teléfono de este Cliente?", "Modificar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        tatc.UpdateQuery(telephone, id_telephone);

                        MercaFacil_2DataSetTableAdapters.LogTableAdapter logta
                            = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                        logta.Insert("modificación de teléfono", "Se modificó el Teléfono", System.DateTime.Now, id_user);

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, Revice los datos", "Modificar Teléfono Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                txt_NumTel.Clear();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
