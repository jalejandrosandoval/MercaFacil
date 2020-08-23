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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            txt_Password.PasswordChar = '*';
            /*txt_User.Text = "admin";
            txt_Password.Text = "321";*/
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter uta;
            uta = new MercaFacil_2DataSetTableAdapters.UsuarioTableAdapter();

            MercaFacil_2DataSet.UsuarioDataTable answer;

            try
            {
                string user = txt_User.Text;
                string password = txt_Password.Text;

                MdiParent parent = (MdiParent)this.MdiParent;

                password = parent.Encrypt(password);

                answer = uta.Login(user, password);

                if (answer.Count > 0)
                {
                    parent.CurrentUser = answer[0];

                    parent.lbl_NameUser.Text = "BIENVENIDO: " + parent.CurrentUser.Nombres.ToString();
                    parent.lbl_NameUser.Visible = true;
                    parent.showUser(parent.CurrentUser.Tipo_Usuario);
                    parent.logTA.Insert("Inicio de sesión", "usuario: " + answer[0].Nombres, System.DateTime.Now, answer[0].Id);

                    this.Close();
                }
                else
                {

                    MessageBox.Show("Acceso Denegado! Usuario no Encontrado... Intentelo de nuevo", "¡Atención!", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                    txt_User.Clear();
                    txt_Password.Clear();

                }
                
                parent.btn_Login.Visible = false;
                parent.btn_Logout.Visible = true;

            }catch(Exception error)
            {
                MessageBox.Show(" " + error);
            }
        
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Enter_Click(sender, e);
            }
        }
    }
}
