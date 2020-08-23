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
    public partial class ChooseQuantity : Form
    {

        Ventas frm_ventas;

        public int Amount { get; set; }
        int limit;

        public ChooseQuantity(Ventas father, int lim)
        {
            InitializeComponent();

            frm_ventas = father;
            limit = lim;
            lbl_lim.Text = lbl_lim.Text + " " + lim;
            Amount = 0;
        }

        private void btn_plus_Click(object sender, EventArgs e)
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
                MessageBox.Show(error.Message);
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
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
                MessageBox.Show(error.Message);
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool number = int.TryParse(txt_Amount.Text, out int n);
                                                                                    
                if (number)
                {

                    if (txt_Amount.Text != "" && Convert.ToInt32(txt_Amount.Text) > 0)
                    {
                        if (Convert.ToInt32(txt_Amount.Text) <= limit)
                        {
                            Amount = Convert.ToInt32(txt_Amount.Text);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Superó el límite", "Cantidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Superó el límite", "Cantidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("ingrese un entero válido");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            frm_ventas.txt_barcode.ResetText();
            this.Close();
        }
    }
}
