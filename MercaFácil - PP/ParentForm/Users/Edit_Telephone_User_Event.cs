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
    public partial class Edit_Telephone_User_Event : Form
    {
        //VARIABLES

        int id_User;
        int id_Telephone;
        string IdentificationUser;
        string Telephone;

        DialogResult result;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter tatu
            = new MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter();

        MercaFacil_2DataSet.Telefono_UsuarioDataTable res;

        public Edit_Telephone_User_Event(string idenUser, int idUser, int idTelephone)
        {
            InitializeComponent();

            id_User = idUser;
            id_Telephone = idTelephone;
            IdentificationUser = idenUser;
            lbl_NumId.Text = idenUser;
        }

        private void Edit_Telephone_User_Event_Load(object sender, EventArgs e)
        {
            res = tatu.Show_By_Id(id_Telephone);

            txt_NumTel.Text = res[0].Telefono.ToString();
            lbl_NumId.Text = IdentificationUser;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NumTel.Text != "")
                {
                    Telephone = txt_NumTel.Text;

                    result = MessageBox.Show("¿Desea Editar el Teléfono de este Usuario?", "Modificar Teléfono Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        tatu.UpdateQuery(Telephone, id_Telephone);

                        MercaFacil_2DataSetTableAdapters.LogTableAdapter logta
                            = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                        logta.Insert("Modificación de Teléfono", "Se Modificó el Teléfono", System.DateTime.Now, id_User);
                    }
                }
                else
                {
                    MessageBox.Show("Llene Correctamente los Datos...", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                txt_NumTel.Clear();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
