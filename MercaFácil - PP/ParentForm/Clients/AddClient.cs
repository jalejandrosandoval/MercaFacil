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
    public partial class AddClient : Form
    {
        //FORMS 

        AddNumClient frm_AddNumClient;

        //DATASETS
        MercaFacil_2DataSetTableAdapters.ClienteTableAdapter cta 
            = new MercaFacil_2DataSetTableAdapters.ClienteTableAdapter();

        MdiParent parent;

        string identification = "";

        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            btn_Add_Telephone.Visible = false;
            parent = (MdiParent)this.MdiParent; 
        }

        public void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (cmb_TypeIden.Text != "" && txt_Identification.Text != "" && txt_FirstName.Text != "" && 
                    txt_LastName.Text != "" && txt_Neightborhood.Text != "" && txt_Address.Text != "")
                {
                    if (cmb_TypeIden.Text == "C.C" || cmb_TypeIden.Text == "C.E" || cmb_TypeIden.Text == "NIT")
                    {
                        identification = txt_Identification.Text;
                        string type_Ide = cmb_TypeIden.Text;
                        string fName = txt_FirstName.Text;
                        string lName = txt_LastName.Text;
                        string adNeigh = txt_Neightborhood.Text;
                        string adNum = txt_Address.Text;


                        DialogResult result = MessageBox.Show("¿Desea Agregar el Cliente?", "Agregar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                        if (result == DialogResult.OK)
                        {
                            cta.Insert(identification, type_Ide, fName, lName, adNeigh, adNum, 0);
                           
                            parent.logTA.Insert("Registro de cliente", "Registrado por " + parent.CurrentUser.Nombres, System.DateTime.Now, parent.CurrentUser.Id);
                            
                            btn_Add_Telephone.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Llene Correctamente los Datos...", "Agregar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Telephone_Click(object sender, EventArgs e)
        {
            parent = (MdiParent)this.MdiParent;

            if (!parent.formExist("AddNumClient"))
            {
                frm_AddNumClient = new AddNumClient(Convert.ToInt32(cta.Id_By_Identification(identification)), parent.CurrentUser.Id);
                frm_AddNumClient.lbl_NumId.Text = identification;
                frm_AddNumClient.MdiParent = this.MdiParent;
                frm_AddNumClient.Show();
            }
        }

    }
}
