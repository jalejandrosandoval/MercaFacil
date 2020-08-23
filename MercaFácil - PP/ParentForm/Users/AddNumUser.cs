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
    public partial class AddNumUser : Form
    {
        //VARIABLES

        int id_User;
        string telephone;

        DialogResult result;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter tatu 
            = new MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter();

        public AddNumUser(int id)
        {
            InitializeComponent();

            id_User = id;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NumTel.Text != "")
                {

                    telephone = txt_NumTel.Text;

                    result = MessageBox.Show("¿Desea Agregar el Teléfono a este Cliente?", "Agregar Teléfono Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        tatu.Insert(id_User, telephone);
                    }

                }

                txt_NumTel.Clear();

                result = MessageBox.Show("¿Desea Agregar Otro Teléfono a este Cliente?", "Agregar Teléfono Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (result == DialogResult.OK)
                {
                    tatu.Insert(id_User, telephone);
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
