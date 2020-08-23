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
    public partial class OptionsProducts : Form
    {

        SearchProductscs frm_searchProducts;

        public OptionsProducts()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchProducts = new SearchProductscs();
            frm_searchProducts.MdiParent = this.MdiParent;
            frm_searchProducts.Show();

        }
    }
}
