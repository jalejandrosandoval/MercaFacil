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
    public partial class Devolucion : Form
    {
        DevolucionDetalles frm_DetailsRepayment;

        int numFact = 0;

        public Devolucion()
        {
            InitializeComponent();
            btn_Go.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numFact != 0)
            {
                MdiParent parent = (MdiParent)this.MdiParent;


                frm_DetailsRepayment = new DevolucionDetalles(numFact, parent.CurrentUser.Id);
                frm_DetailsRepayment.Show();
                btn_Go.Visible = false;
                numFact = 0;
                this.Hide();
            }
        }

        private void txt_NumFact_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_NumFact.Text != "" && Convert.ToInt32(txt_NumFact.Text) > 0)
                {
                    dGrid_RePayment.DataSource = facturaVentaBindingSource;
                    this.factura_VentaTableAdapter.FillByNumFact(this.mercaFacil_2DataSet.Factura_Venta, Convert.ToInt32(txt_NumFact.Text));
                }
                else
                {
                    dGrid_RePayment.DataSource = "";
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGrid_RePayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                numFact = Convert.ToInt32(dGrid_RePayment.SelectedRows[0].Cells[0].Value.ToString());
                btn_Go.Visible = true;
            }
        }
    }
}
