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
    public partial class OptionsVendors : Form
    {
        SearchVendors frm_searchVendors;
        

        public OptionsVendors()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchVendors = new SearchVendors();
            frm_searchVendors.MdiParent = this.MdiParent;
            frm_searchVendors.Show();
        }
    }
}
