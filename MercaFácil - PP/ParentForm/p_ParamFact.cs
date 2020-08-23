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
    public partial class p_ParamFact : Form
    {
        int numFact = 0;

        public p_ParamFact()
        {
            InitializeComponent();
            btn_ShowFactu.Visible = false;
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            this.factura_MultipleTableAdapter.FillBy1(this.dataSetMultiplesTablas.Factura_Multiple, Convert.ToDateTime(dateTimePicker2.Value.Date), Convert.ToDateTime(dateTimePicker1.Value.Date));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_ShowFactu.Visible = true;
                numFact = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btn_ShowFactu_Click(object sender, EventArgs e)
        {
            ReportFactForm rfact = new ReportFactForm(numFact);
            rfact.Show();
        }
    }
}
