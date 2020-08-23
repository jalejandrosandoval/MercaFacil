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
    public partial class AddNumClient : Form
    {
        //VARIABLES

        int id_Client = 0;
        int id_User;
        string telephone;

        DialogResult result;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter tatc
            = new MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter();

        public AddNumClient(int id, int idUser)
        {
            InitializeComponent();

            id_Client = id;
            id_User = idUser;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                MercaFacil_2DataSetTableAdapters.LogTableAdapter logta
                    = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                if (txt_NumTel.Text != "")
                {                    
                    telephone = txt_NumTel.Text;

                    result = MessageBox.Show("¿Desea Agregar el telefono a este Cliente?", "Agregar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        tatc.Insert(id_Client, telephone);
                        logta.Insert("Se registró un teléfono", "Agregado por el usuario n. " + id_User, System.DateTime.Now, id_User);
                    }
                }

                txt_NumTel.Clear();

                result = MessageBox.Show("¿Desea Agregar otro telefono a este Cliente?", "Agregar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    txt_NumTel.ResetText();
                }
                else
                {
                    this.Close();
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

