using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dossier_medical
{
    public partial class ALL_RE_analyse : Form
    {
        public ALL_RE_analyse()
        {
            InitializeComponent();
        }

        private void ALL_RE_analyse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dossier_medical_alectroniqueDataSet1.analyse' table. You can move, or remove it, as needed.
            this.analyseTableAdapter.Fill(this.dossier_medical_alectroniqueDataSet1.analyse);

            this.reportViewer1.RefreshReport();
        }
    }
}
