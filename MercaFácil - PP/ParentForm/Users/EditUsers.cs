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
    public partial class OptionsUsers : Form
    {
        //VARIABLES

        string Identification = "";
        int UserId = 0;

        public bool Found { get; set; }

        //FORMS

        SearchUser frm_searchUser;
        Add_Edit_Num_User frm_Add_Edit_Num_User;
        Edit_Num_User frm_Edit_Num_User;

        MdiParent parent;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter tau 
            = new MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();

        public OptionsUsers()
        {
            InitializeComponent();

            btn_Edit_Telephone.Visible = false;
            btn_AddTel.Visible = false;

            Found = false;           

        }

        private void lklb_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchUser = new SearchUser(this);
            frm_searchUser.Show();
            frm_searchUser.FormClosing += new FormClosingEventHandler(showButtons);
            this.Hide();

            parent = (MdiParent)this.MdiParent;
        }

        private void showButtons(object sender, EventArgs e)
        {
            if (Found)
            {
                btn_AddTel.Visible = true;
                btn_Edit_Telephone.Visible = true;

                Identification = txt_Identification.Text;
                UserId = Convert.ToInt32(tau.Id_By_Identification(Identification));

            }
            else
            {
                btn_AddTel.Visible = false;
                btn_Edit_Telephone.Visible = true;
            }

        }
        private void btn_EditUser_Click(object sender, EventArgs e)
        {                          

            if (MessageBox.Show("¿Está Seguro de modificar este Usuario?", "Modificar Usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txt_Identification.Text != "" && txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Neighborhood.Text != "" && txt_Adress.Text != "" && txt_User.Text != "" && txt_Password.Text != "")
                    {
                        Identification = txt_Identification.Text;
                        string fName = txt_FirstName.Text;
                        string lName = txt_LastName.Text;
                        DateTime birthdate = Convert.ToDateTime(dtp_Birthdate.Value.Date);
                        string neigh = txt_Neighborhood.Text;
                        string address = txt_Adress.Text;
                        int type = Convert.ToInt32(cmb_UserType.Text);
                        string user = txt_User.Text;
                        string pass = txt_Password.Text;                        

                        pass = parent.Encrypt(pass);

                        tau.UpdateQueryUser(fName, lName, Identification, user, pass, type, neigh, address, birthdate.ToString(), 0, frm_searchUser.id_User);

                        //parent.logTA.Insert("Actualización de usuario", "Se actualizó el usuario", System.DateTime.Now, parent.CurrentUser.Id);

                    }
                    else
                    {
                        MessageBox.Show("Por favor, Revice los Datos", "Modificar Usuario",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btn_AddTel_Click(object sender, EventArgs e)
        {
            if (Identification != "")
            {
                if (Found)
                {
                    frm_Add_Edit_Num_User = new Add_Edit_Num_User(Identification, UserId, parent.CurrentUser.Id);
                    frm_Add_Edit_Num_User.Show();
                }
            }

        }

        private void btn_Edit_Telephone_Click(object sender, EventArgs e)
        {
            MercaFacil_2DataSet.Telefono_UsuarioDataTable ans;

            MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter tatu
                = new MercaFacil_2DataSetTableAdapters.Telefono_UsuarioTableAdapter();

            ans = tatu.GetData_By_Id(UserId);

            if (ans.Count > 0)
            {
                frm_Edit_Num_User = new Edit_Num_User(UserId);
                frm_Edit_Num_User.identification = Identification;
                frm_Edit_Num_User.Show();
            }
            else
            {
                MessageBox.Show("Teléfonos Inexistentes... Este Cliente no Tiene Ningun Teléfono Registrado", "Modificar Teléfono Cliente",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
