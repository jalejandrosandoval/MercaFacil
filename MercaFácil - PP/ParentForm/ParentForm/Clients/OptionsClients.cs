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

        SearchClients frm_searchClients;

        public OptionsClients()
        {
            InitializeComponent();
        }

        private void lklb_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchClients = new SearchClients();
            frm_searchClients.MdiParent = this.MdiParent;
            frm_searchClients.Show();
        }
    }
}
