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
    public partial class MdiParent : Form
    {
        //Users
        OptionsUsers frm_OptionUsers;

        //Products
        OptionsProducts frm_OptionProducts;

        //Clients
        OptionsClients frm_OptionClients;

        //Vendors
        OptionsVendors frm_OptionVendors;

        public MdiParent()
        {
            InitializeComponent();
            location();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void location()
        {

            //Buttons
            btn_Vendors.Location = new Point(1100, 12);
            btn_Products.Location = new Point(590, 12);
            btn_Users.Location = new Point(70, 12);
            btn_Shops.Location = new Point(305, 12);
            btn_Sales.Location = new Point(1365, 12);
            btn_Close.Location = new Point(1477, -2);
            btn_Minimize.Location = new Point(1423, -2);
            btn_Clients.Location = new Point(850, 12);

            //Labels
            lbl_Users.Location = new Point(89, 115);
            lbl_Shops.Location = new Point(331, 115);
            lbl_Products.Location = new Point(605, 115);
            lbl_Vendor.Location = new Point(1115, 115);
            lbl_Sales.Location = new Point(1400, 115);
            lbl_Time.Location = new Point(10, 4);
            lbl_Date.Location = new Point(1067, 4);
            lbl_Clients.Location = new Point(872, 115);
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_OptionClients = new OptionsClients();
            frm_OptionClients.MdiParent = this.MdiParent;
            frm_OptionClients.Show();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            frm_OptionUsers = new OptionsUsers();
            frm_OptionUsers.MdiParent = this.MdiParent;
            frm_OptionUsers.Show();
        }

        private void btn_Shops_Click(object sender, EventArgs e)
        {

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            frm_OptionProducts = new OptionsProducts();
            frm_OptionProducts.MdiParent = this.MdiParent;
            frm_OptionProducts.Show();
        }

        private void btn_Vendors_Click(object sender, EventArgs e)
        {
            frm_OptionVendors = new OptionsVendors();
            frm_OptionVendors.MdiParent = this.MdiParent;
            frm_OptionVendors.Show();
        }
    }
}
