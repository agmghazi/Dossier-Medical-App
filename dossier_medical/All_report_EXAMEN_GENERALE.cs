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
    public partial class All_report_EXAMEN_GENERALE : Form
    {
        public All_report_EXAMEN_GENERALE()
        {
            InitializeComponent();
        }

        private void All_report_EXAMEN_GENERALE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dossier_medical_alectroniqueDataSet4.General_exame' table. You can move, or remove it, as needed.
            this.General_exameTableAdapter.Fill(this.dossier_medical_alectroniqueDataSet4.General_exame);

            this.reportViewer1.RefreshReport();
        }
    }
}
