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

        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter tap 
            = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();

        public bool found = false;
        string barcode = "";

        MdiParent parent; 
        public OptionsProducts()
        {
            InitializeComponent();
            btn_agregarVenc.Visible = false;
        }

        private void lklb_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_searchProducts = new SearchProductscs(this);
            frm_searchProducts.Show();
            frm_searchProducts.FormClosing += new FormClosingEventHandler(rect);
            this.Hide();
        }

        private void rect(object sender, EventArgs e)
        {
            if(found)
            {
                btn_agregarVenc.Visible = true;
                barcode = txt_Code.Text;   
            }
        }

        private void btn_EditProducts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro de modificar este Producto?", "Modificar Producto",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txt_Code.Text != "" && txt_Name.Text != "" && txt_Description.Text != "" && cmb_TypeProduct.Text != "" && txt_vIva.Text != "" && txt_Amount.Text != "" && txt_Price.Text != "")
                    {
                        string barCode = txt_Code.Text;
                        string name = txt_Name.Text;
                        string description = txt_Description.Text;

                        int n;
                        bool number = int.TryParse(txt_Amount.Text, out n);
                        bool number2 = int.TryParse(txt_Price.Text, out n);
                        bool number3 = int.TryParse(txt_vIva.Text, out n);
                        bool number4 = int.TryParse(cmb_TypeProduct.SelectedValue.ToString(), out n);

                        if (number && number2 && number3 && number4)
                        {
                            int Type = Convert.ToInt32(cmb_TypeProduct.SelectedValue);
                            int vIva = Convert.ToInt32(txt_vIva.Text);
                            int stock = Convert.ToInt32(txt_Amount.Text);
                            int salePrice = Convert.ToInt32(txt_Price.Text);

                            tap.UpdateQuery(name, description, Type, salePrice, vIva, stock, 0, barCode);

                            parent = (MdiParent)this.MdiParent;
                            parent.logTA.Insert("Producto Editado", "Actualización Producto", System.DateTime.Now, parent.CurrentUser.Id);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un entero válido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene Correctamente los Datos...", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void OptionsProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaFacil_2DataSet.Tipo_Producto' Puede moverla o quitarla según sea necesario.
            this.tipo_ProductoTableAdapter.Fill(this.mercaFacil_2DataSet.Tipo_Producto);

        }

        private void btn_agregarVenc_Click(object sender, EventArgs e)
        {
            parent = (MdiParent)this.MdiParent;

            AddExp frm_add = new AddExp(barcode, parent.CurrentUser.Id);
        }
    }
}
