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
    public partial class AddExp : Form
    {

        string barcode = "";
        int id_user = 0;

        public AddExp(string bcode, int id__user)
        {
            InitializeComponent();
            barcode = bcode;
            id_user = id__user;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text == "")
                {
                    txt_Amount.Text = "1";
                }
                else
                {
                    int n = Convert.ToInt32(txt_Amount.Text);
                    n++;
                    txt_Amount.Text = n.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Amount.Text != "")
                {
                    if (txt_Amount.Text == "1")
                    {
                        txt_Amount.Text = "";
                    }
                    else
                    {
                        int n = Convert.ToInt32(txt_Amount.Text);
                        n--;
                        txt_Amount.Text = n.ToString();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(" " + error);
            }
        }

        private void lbl_Ventas_Click(object sender, EventArgs e)
        {
            bool number = int.TryParse(txt_Amount.Text, out int n);

            if(number)
            {
                if (txt_Amount.Text != "" && Convert.ToInt32(txt_Amount.Text) > 0)
                {
                    MercaFacil_2DataSetTableAdapters.Detalle_ProductoTableAdapter dpta
                        = new MercaFacil_2DataSetTableAdapters.Detalle_ProductoTableAdapter();

                    MercaFacil_2DataSetTableAdapters.LogTableAdapter lta
                        = new MercaFacil_2DataSetTableAdapters.LogTableAdapter();

                    dpta.Insert(barcode, Convert.ToDateTime(dateTimePicker1.Value.Date), Convert.ToInt32(txt_Amount.Text));

                    lta.Insert("Ingresó fecha vencimiento", "Se registró fecha", System.DateTime.Now, id_user);
                }
            }
        }
    }
}
