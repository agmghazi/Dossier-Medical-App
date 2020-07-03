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
    public partial class All_report_EDmalade : Form
    {
        public All_report_EDmalade()
        {
            InitializeComponent();
        }

        private void All_report_EDmalade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dossier_medical_alectroniqueDataSet5.malade' table. You can move, or remove it, as needed.
            this.maladeTableAdapter.Fill(this.dossier_medical_alectroniqueDataSet5.malade);

            this.reportViewer1.RefreshReport();
        }
    }
}
