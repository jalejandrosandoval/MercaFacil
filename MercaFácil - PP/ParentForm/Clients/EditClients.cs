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
    public partial class OptionsClients : Form
    {
        //VARIABLES

        string Identification = "";
        int ClientId = 0;

        public bool Found { get; set; }

        //FORMS

        SearchClients frm_searchClients;
        EdittelephoneClient frm_Edit_Telephone_Client;
        Add_Edit_Telephone frm_Add_Edit_Telephone;

        MdiParent parent;

        //DATASETS

        MercaFacil_2DataSetTableAdapters.ClienteTableAdapter tac
            = new MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();

        public OptionsClients()
        {
            InitializeComponent();

            btn_Edit_Telephone.Visible = false;
            btn_AddTel.Visible = false;

            Found = false;

           
        }

        private void lkl_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchClients = new SearchClients(this);
            frm_searchClients.Show();
            frm_searchClients.FormClosing += new FormClosingEventHandler(showButtons);
            this.Hide();
        }

        private void showButtons(object sender, EventArgs e)
        {
            if (Found)
            {
                btn_AddTel.Visible = true;
                btn_Edit_Telephone.Visible = true;

                Identification = txt_Identification.Text;
                ClientId = Convert.ToInt32(tac.Id_By_Identification(Identification));
                parent = (MdiParent)this.MdiParent;
            }
            else
            {
                btn_AddTel.Visible = false;
                btn_Edit_Telephone.Visible = true;
            }

            
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro de modificar este Cliente?", "Modificar Cliente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (cmb_TypeIdentification.Text != "" && txt_Identification.Text != "" && txt_FirstName.Text != ""
                        && txt_LastName.Text != "" && txt_Address.Text != "" && txt_Neightborhood.Text != "")
                    {
                        string Type_Identification = cmb_TypeIdentification.Text;
                        string FirstName = txt_FirstName.Text;
                        string LastName = txt_LastName.Text;
                        string Adress = txt_Address.Text;
                        string Neightborhood = txt_Neightborhood.Text;

                        tac.UpdateQuery(Identification, Type_Identification, FirstName, LastName, Adress, Neightborhood, 0, frm_searchClients.id_Client);

                    }
                    else
                    {
                        MessageBox.Show("Por favor, Revice los datos", "Modificar Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }                          
        }

        private void btn_AddTel_Click(object sender, EventArgs e)
        {
            parent = (MdiParent)this.MdiParent;

            if (!parent.formExist("Add_Edit_Telephone"))
            {
                if (Identification != "")
                {
                    if (Found)
                    {
                        frm_Add_Edit_Telephone = new Add_Edit_Telephone(Identification, ClientId, parent.CurrentUser.Id);
                        frm_Add_Edit_Telephone.Show();

                    }
                }
            }                    
        }

        private void btn_Edit_Telephone_Click(object sender, EventArgs e)
        {
            MercaFacil_2DataSet.Telefono_ClienteDataTable ans;

            MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter tcta
                = new MercaFacil_2DataSetTableAdapters.Telefono_ClienteTableAdapter();            

            ans = tcta.GetDataById(ClientId);

            if (ans.Count > 0)
            {
                parent = (MdiParent)this.MdiParent;

                if (!parent.formExist("EdittelephoneClient"))
                {
                    frm_Edit_Telephone_Client = new EdittelephoneClient(ClientId, parent.CurrentUser.Id);
                    frm_Edit_Telephone_Client.identification = Identification;
                    frm_Edit_Telephone_Client.Show();
                }
            }
            else
            {
                MessageBox.Show("Teléfonos Inexistentes... Este Cliente no Tiene Ningun Teléfono Registrado", "Modificar Teléfono Cliente",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
