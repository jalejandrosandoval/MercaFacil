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
    public partial class CreateUser : Form
    {
        //VARIABLES

        string identification;
        
        //FORMS

        AddNumUser frm_AddNumUser;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter uta;

        public CreateUser()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                MdiParent parent = (MdiParent)this.MdiParent;


                if (txt_Identification.Text != "" && txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Neighborhood.Text != "" &&
                     txt_Adress.Text != "" && cmb_UserType.Text != "" && txt_User.Text != "" && txt_Password.Text != "")
                {
                    identification = txt_Identification.Text;
                    string fName = txt_FirstName.Text;
                    string lName = txt_LastName.Text;
                    DateTime date = Convert.ToDateTime(dtp_Birthdate.Value.Date);
                    string adNeigh = txt_Neighborhood.Text;
                    string adNum = txt_Adress.Text;
                    int typeUser = Convert.ToInt32(cmb_UserType.SelectedValue.ToString());
                    string user = txt_User.Text;
                    string password = txt_Password.Text;

                    password = parent.Encrypt(password);

                    DialogResult result = MessageBox.Show("¿Desea Agregar el Cliente?", "Agregar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        uta = new MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();

                        uta.Insert(fName, lName, identification, user, password, typeUser, adNeigh, adNum, date, System.DateTime.Now, 0);

                        parent.logTA.Insert("Creación de usuario", "Se ha creado un usuario", System.DateTime.Now, parent.CurrentUser.Id);


                       btn_Add_Telephone.Visible = true;

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

        private void CreateUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaFacil_2DataSet.Tipo_Usuario' Puede moverla o quitarla según sea necesario.
            this.tipo_UsuarioTableAdapter.Fill(this.mercaFacil_2DataSet.Tipo_Usuario);

            btn_Add_Telephone.Visible = false;

        }

        private void btn_Add_Telephone_Click(object sender, EventArgs e)
        {
            MdiParent parent = (MdiParent)this.MdiParent;

            if (!parent.formExist("AddNumUser"))
            {
                frm_AddNumUser = new AddNumUser(Convert.ToInt32(uta.Id_By_Identification(identification)));
                frm_AddNumUser.lbl_NumId.Text = identification;
                frm_AddNumUser.MdiParent = this.MdiParent;
                frm_AddNumUser.Show();
            }
        }
    }
}
