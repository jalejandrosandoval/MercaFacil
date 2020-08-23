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
    public partial class Add_Edit_Telephone : Form
    {
        //VARIABLES

        int id_Client;
        int id_User;
        string identificationClient;
        string telephone;        

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter tatc
            = new MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter();

        public Add_Edit_Telephone(string identiClient, int id, int iduser)
        {
            InitializeComponent();

            id_User = iduser; 
            id_Client = id;
            identificationClient = identiClient;
            lbl_NumId.Text = identificationClient;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult result;

            try
            {
                if (txt_NumTel.Text != "")
                {
                    telephone = txt_NumTel.Text;

                    result = MessageBox.Show("¿Desea Agregar el telefono a este Cliente?", "Agregar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        tatc.Insert(id_Client, telephone);
                        MercaFacil_2DataSetTableAdapters.LogTableAdapter logta
                            = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                        logta.Insert("Teléfono agregado", "Se le agregó un teéfono al cliente", System.DateTime.Now, id_User);
                    }                   

                    result = MessageBox.Show("¿Desea Agregar otro telefono a este Cliente?", "Agregar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        txt_NumTel.Clear();
                    }
                    else
                    {
                        this.Close();
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
