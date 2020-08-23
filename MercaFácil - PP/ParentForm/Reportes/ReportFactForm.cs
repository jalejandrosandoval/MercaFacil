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
    public partial class ReportFactForm : Form
    {
    
        public ReportFactForm(int numFact)
        {
            InitializeComponent();
            
            FactReport1.SetParameterValue("numFact", numFact);
            FactReport2.SetParameterValue("numFact", numFact);
        }

    }
}
