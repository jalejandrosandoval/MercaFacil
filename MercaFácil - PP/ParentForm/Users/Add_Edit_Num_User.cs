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
    public partial class Add_Edit_Num_User : Form
    {

        //VARIABLES

        int id_User;
        int currentUser;
        string identificationUser;
        string telephone;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter tatu
            = new MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter();


        public Add_Edit_Num_User(string identiUser, int id, int userid)
        {
            InitializeComponent();

            currentUser = userid;
            id_User = id;            
            identificationUser = identiUser;
            lbl_NumId.Text = identificationUser;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult result;

            try
            {               

                if (txt_NumTel.Text != "")
                {
                    telephone = txt_NumTel.Text;

                    result = MessageBox.Show("¿Desea Agregar el Teléfono a este Usuario?", "Agregar Teléfono Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        tatu.Insert(id_User, telephone);
                        MercaFacil_2DataSetTableAdapters.LogTableAdapter logTa 
                            = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                        logTa.Insert("Teléfono Agregado", "Se Agregó un Teléfono", System.DateTime.Now, currentUser);
                    }

                    result = MessageBox.Show("¿Desea Agregar otro Teléfono a este Usuario?", "Agregar Teléfono Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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