using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;

namespace ParentForm
{
    public partial class MdiParent : Form
    {
        //Users
        OptionsUsers frm_OptionUsers;
        CreateUser frm_CreateUser;
        DeleteUsers frm_DeleteUser;

        //Products
        OptionsProducts frm_OptionProducts;
        CreateProduct frm_CreateProduct;
        DeleteProducts frm_DeleteProducts;

        //Clients
        OptionsClients frm_OptionClients;
        AddClient frm_AddClient;
        DeleteClients frm_DeleteClient;

        //Vendors
        OptionsVendors frm_OptionVendors;
        CreateVendor frm_CreateVendor;
        SearchVendors_Delete frm_SearchVendors_Delete;

        //Shops
        Compras frm_Shops;

        //Sales
        Ventas frm_Sales;

        //Repayment
        Devolucion frm_Repayment;

        //Login
        Login frm_Login;

        //Parent Attributes
        public MercaFacil_2DataSet.UsuarioRow CurrentUser { get; set; }

        public MercaFacil_2DataSetTableAdapters.LogTableAdapter logTA 
            = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

        public MdiParent()
        {
            InitializeComponent();
            location();
            //HideButtons();
           
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            time_Hour.Enabled = true;

            frm_Login = new Login();
            frm_Login.MdiParent = this;
            frm_Login.Show();

            panel3.Visible = false;

        }

        public string Encrypt(string cadena)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider(); //OBJETO DE TIPO MD5
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cadena)); //ENCRIPTAR LA CADENA EN ASCII

            byte[] resEncriptacion = md5.Hash; //HASH => ALGORITMO CRIPTOGRAFICO

            StringBuilder str = new StringBuilder(); //STRINGS LARGOS 

            for (int i = 0; i < resEncriptacion.Length; i++)
            {
                str.Append(resEncriptacion[i].ToString("x"));
                //AGREGA TEXTO AL FINAL 
            }

            return str.ToString();
        }

        public void hide()
        {
            btn_Clients.Visible = false;
            btn_Users.Visible = false;
            btn_Shops.Visible = false;
            btn_Sales.Visible = false;
            btn_Vendors.Visible = false;
            btn_Products.Visible = false;
            btn_Reports.Visible = false;

            lbl_Clients.Visible = false;
            lbl_Users.Visible = false;
            lbl_Shops.Visible = false;
            lbl_Sales.Visible = false;
            lbl_Vendor.Visible = false;
            lbl_Products.Visible = false;
            lbl_Reports.Visible = false;
        }
        public void location()
        {
            //Buttons
            btn_Vendors.Location = new Point(990, 12);
            btn_Products.Location = new Point(500, 12);
            btn_Users.Location = new Point(70, 12);
            btn_Shops.Location = new Point(265, 12);
            btn_Sales.Location = new Point(1185, 12);
            btn_Close.Location = new Point(1477, -2);
            btn_Login.Location = new Point(1423, -2);
            btn_Logout.Location = new Point(1423, -2);
            btn_Clients.Location = new Point(770, 12);
            btn_Reports.Location = new Point(1423, 12);

            //Labels
            lbl_Users.Location = new Point(72, 83);
            lbl_Shops.Location = new Point(278, 83);
            lbl_Products.Location = new Point(504, 83);
            lbl_Vendor.Location = new Point(985, 83);
            lbl_Sales.Location = new Point(1200, 83);
            lbl_Time.Location = new Point(10, 4);
            lbl_Date.Location = new Point(1050, 4);
            lbl_Clients.Location = new Point(778, 83);
            lbl_NameUser.Location = new Point(650, 4);
            lbl_Reports.Location = new Point(1428, 85);
        }

        public bool formExist(string name)
        {        
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == name)
                {
                    return true;
                   
                }
            }

            return false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {
            toolMenusVisible();
            ts_Clients.Visible = true;
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            toolMenusVisible();
            ts_Users.Visible = true;
        }

        private void btn_Shops_Click(object sender, EventArgs e)
        {
            if (!formExist("Compras"))
            {
                toolMenusVisible();
                frm_Shops = new Compras();
                frm_Shops.MdiParent = this;
                frm_Shops.Show();
            }
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            toolMenusVisible();
            ts_Products.Visible = true;
        }

        private void btn_Vendors_Click(object sender, EventArgs e)
        {
            toolMenusVisible();
            ts_Vendor.Visible = true;
        }

        private void ts_CloseUsers_Click(object sender, EventArgs e)
        {
            ts_Users.Visible = false;
        }

        private void ts_CloseClient_Click(object sender, EventArgs e)
        {
            ts_Clients.Visible = false;
        }

        private void ts_CloseVendors_Click(object sender, EventArgs e)
        {
            ts_Vendor.Visible = false;
        }

        private void ts_CloseProducts_Click(object sender, EventArgs e)
        {
            ts_Products.Visible = false;
        }

        private void ts_closeSale_Click(object sender, EventArgs e)
        {
            ts_Sale.Visible = false;
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            toolMenusVisible();

            if (!formExist("Ventas"))
            {
                ts_Sale.Visible = true;
                frm_Sales = new Ventas();
                frm_Sales.MdiParent = this;
                frm_Sales.Show();
            }
        }

        private void ts_AddUser_Click(object sender, EventArgs e)
        {           

            if (!formExist("CreateUser"))
            {
                frm_CreateUser = new CreateUser();
                frm_CreateUser.Show();
                frm_CreateUser.MdiParent = this;
            }
        }

        private void ts_EditUser_Click(object sender, EventArgs e)
        {
            if (!formExist("OptionsUsers"))
            {
                frm_OptionUsers = new OptionsUsers();
                frm_OptionUsers.MdiParent = this;
                frm_OptionUsers.Show();
            }
        }

        private void ts_DeleteUser_Click(object sender, EventArgs e)
        {
            if (!formExist("DeleteUsers"))
            {
                frm_DeleteUser = new DeleteUsers();
                frm_DeleteUser.MdiParent = this;
                frm_DeleteUser.Show();
            }
        }

        private void ts_AddClient_Click(object sender, EventArgs e)
        {
            if (!formExist("AddClient"))
            {
                frm_AddClient = new AddClient();
                frm_AddClient.MdiParent = this;
                frm_AddClient.Show();
            }
        }

        private void ts_EditClient_Click(object sender, EventArgs e)
        {
            if (!formExist("OptionsClients"))
            {
                frm_OptionClients = new OptionsClients();
                frm_OptionClients.MdiParent = this;
                frm_OptionClients.Show();
            }
        }

        private void ts_DeleteClient_Click(object sender, EventArgs e)
        {
            if (!formExist("DeleteClients"))
            {
                frm_DeleteClient = new DeleteClients();
                frm_DeleteClient.MdiParent = this;
                frm_DeleteClient.Show();
            }
        }

        private void ts_AddProduct_Click(object sender, EventArgs e)
        {
            if (!formExist("CreateProduct"))
            {
                frm_CreateProduct = new CreateProduct();
                frm_CreateProduct.MdiParent = this;
                frm_CreateProduct.Show();
            }
        }

        private void ts_EditProduct_Click(object sender, EventArgs e)
        {
            if (!formExist("OptionsProducts"))
            {
                frm_OptionProducts = new OptionsProducts();
                frm_OptionProducts.MdiParent = this;
                frm_OptionProducts.Show();
            }
        }

        private void ts_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (!formExist("DeleteProducts"))
            {
                frm_DeleteProducts = new DeleteProducts();
                frm_DeleteProducts.MdiParent = this;
                frm_DeleteProducts.Show();
            }
        }

        private void ts_AddVendor_Click(object sender, EventArgs e)
        {
            if (!formExist("CreateVendor"))
            {
                frm_CreateVendor = new CreateVendor();
                frm_CreateVendor.MdiParent = this;
                frm_CreateVendor.Show();
            }
        }

        private void ts_EditVendor_Click(object sender, EventArgs e)
        {
            if (!formExist("OptionsVendors"))
            {
                frm_OptionVendors = new OptionsVendors();
                frm_OptionVendors.MdiParent = this;
                frm_OptionVendors.Show();
            }
        }

        private void ts_DeleteVendor_Click(object sender, EventArgs e)
        {
            if (!formExist("SearchVendors_Delete"))
            {
                frm_SearchVendors_Delete = new SearchVendors_Delete();
                frm_SearchVendors_Delete.MdiParent = this;
                frm_SearchVendors_Delete.Show();
            }
        }

        private void ts_Repayment_Click(object sender, EventArgs e)
        {
            if (!formExist("Devolucion"))
            {
                frm_Repayment = new Devolucion();
                frm_Repayment.MdiParent = this;
                frm_Repayment.Show();

                frm_Sales.Close();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!formExist("Login"))
            {
                frm_Login = new Login();
                frm_Login.MdiParent = this;
                frm_Login.Show();
            }
        }

        private void toolMenusVisible()
        {
            ts_Users.Visible = false;
            ts_Clients.Visible = false;
            ts_Vendor.Visible = false;
            ts_Products.Visible = false;
            ts_Sale.Visible = false;
            ts_Reports.Visible = false;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            btn_Login.Visible = true;
            lbl_NameUser.Visible = false;

            toolMenusVisible();

            int cant = (Application.OpenForms.Count) - 1;

            FormCollection list = Application.OpenForms;

            while (cant > 0)
            {
                list[cant].Close();
                cant--;
            }
                
            panel3.Visible = false;

            if (!formExist("Login"))
            {
                frm_Login = new Login();
                frm_Login.MdiParent = this;
                frm_Login.Show();
            }

        }

        private void time_Hour_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void ts_ListVendors_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportProviderForm"))
            {
                ReportProviderForm rProviderF = new ReportProviderForm();
                rProviderF.Show();
            }
        }

        private void ts_ListClient_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportClientForm"))
            {
                ReportClientForm rClientF = new ReportClientForm();
                rClientF.Show();
            }

        }

        private void ts_ListUsers_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportUserForm"))
            {
                ReportUserForm rUser = new ReportUserForm();
                rUser.Show();
            }
        }

        private void ts_ListProduct_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportProductForm"))
            {
                ReportProductForm rProductF = new ReportProductForm();
                rProductF.Show();
            }
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            toolMenusVisible();
            ts_Reports.Visible = true;
        }

        public void showUser(int type)
        {
            panel3.Visible = true;

            if(type == 1)
            {
                btn_Products.Visible = true;
                btn_Vendors.Visible = true;
                btn_Users.Visible = true;

                lbl_Products.Visible = true;
                lbl_Vendor.Visible = true;
                lbl_Users.Visible = true;   

                location();
            }
            else
            {
                btn_Products.Visible = false;
                btn_Vendors.Visible = false;
                btn_Users.Visible = false;

                lbl_Products.Visible = false;
                lbl_Vendor.Visible = false;
                lbl_Users.Visible = false;

                /*btn_Sales.Location = new Point(70, 12);
                btn_Clients.Location = new Point(265, 12);
                btn_Shops.Location = new Point(500, 12);
                btn_Reports.Location = new Point(713, 12);

                lbl_Sales.Location = new Point(72, 83);
                lbl_Clients.Location = new Point(278, 83);
                lbl_Shops.Location = new Point(504, 83);
                lbl_Reports.Location = new Point(715, 83);*/

                btn_Sales.Location = new Point(360, 12);
                btn_Clients.Location = new Point(555, 12);
                btn_Shops.Location = new Point(790, 12);
                btn_Reports.Location = new Point(1003, 12);

                lbl_Sales.Location = new Point(366, 83);
                lbl_Clients.Location = new Point(561, 83);
                lbl_Shops.Location = new Point(796, 83);
                lbl_Reports.Location = new Point(1009, 85);
            }

            
        }

        public void HideButtons()
        {
            
            btn_Vendors.Visible = false;
            btn_Products.Visible = false;
            btn_Users.Visible = false;
            btn_Shops.Visible = false;
            btn_Sales.Visible = false;
            btn_Login.Visible = false;
            btn_Clients.Visible = false;
            btn_Reports.Visible = false;

            //Labels
            lbl_Users.Visible = false;
            lbl_Shops.Visible = false;
            lbl_Products.Visible = false;
            lbl_Vendor.Visible = false;
            lbl_Sales.Visible = false;
            lbl_Time.Visible = false;
            lbl_Clients.Visible = false;
            lbl_Reports.Visible = false;
        }

        private void ts_ReportProductMostSell_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportMostSoldProduct"))
            {
                ReportMostSoldProduct rmsp = new ReportMostSoldProduct();
                rmsp.Show();
                rmsp.crv_ReportProductMostSell.RefreshReport();
            }
            
        }

        private void ts_MostClientBuy_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportMoreClientBuy"))
            {
                ReportMoreClientBuy rmcb = new ReportMoreClientBuy();
                rmcb.Show();
                rmcb.crv_ReportProduct.RefreshReport();
            }
        }

        private void ts_MoreVendorSell_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportMoreVendorSell"))
            {
                ReportMoreVendorSell rmvs = new ReportMoreVendorSell();
                rmvs.Show();
                rmvs.crv_ReportVendorSell.RefreshReport();
            }
        }

        private void ts_ReportFact_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportFact"))
            {
                ReportFact rf = new ReportFact();
                rf.Show();
            }
        }

        private void btn_CloseReports_Click(object sender, EventArgs e)
        {
            ts_Reports.Visible = false;

        }

        private void ts_ReportLog_Click(object sender, EventArgs e)
        {
            if (!formExist("ReportFact"))
            {
                ReportLogForm rlf = new ReportLogForm();
                rlf.Show();
            }
        }

        private void ts_ReportFactPara_Click(object sender, EventArgs e)
        {
            p_ParamFact frm_paFact = new p_ParamFact();
            frm_paFact.Show();
        }

        private void MdiParent_Load(object sender, EventArgs e)
        {

        }
    }
}
