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
    public partial class p_paramFact : Form
    {
        int numFact = 0;

        public p_paramFact()
        {
            InitializeComponent();
            btn_show.Visible = false;
        }

        private void dGrid_ShoppingCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_show.Visible = true;
                numFact = Convert.ToInt32(dGrid_ShoppingCart.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.factura_MultipleTableAdapter.FillBy1(this.dataSetMultiplesTablas.Factura_Multiple, Convert.ToDateTime(dtp_begin.Value.Date), Convert.ToDateTime(dtp_end.Value.Date));
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ReportFactForm rfact = new ReportFactForm(numFact);
            rfact.Show();
        }
    }
}
