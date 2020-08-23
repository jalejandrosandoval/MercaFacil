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
    public partial class ReportFact : Form
    {

        int NumFact = 0;
        public ReportFact()
        {
            InitializeComponent();
        }

        private void btn_ShowFactu_Click(object sender, EventArgs e)
        {
            ReportFactForm rfact = new ReportFactForm(NumFact);
            rfact.Show();
        }

        private void ReportFact_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMultiplesTablas.Factura_Multiple' Puede moverla o quitarla según sea necesario.
            this.factura_MultipleTableAdapter.Fill(this.dataSetMultiplesTablas.Factura_Multiple);
           


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                btn_ShowFactu.Visible = true;
                NumFact = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
