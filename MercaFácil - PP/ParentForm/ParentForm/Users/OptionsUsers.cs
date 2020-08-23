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
        SearchUser frm_searchUser;
        public OptionsUsers()
        {
            InitializeComponent();
        }

        private void pn_Cabecera_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchUser = new SearchUser();
            frm_searchUser.MdiParent = this.MdiParent;
            frm_searchUser.Show();
            
        }
    }
}
