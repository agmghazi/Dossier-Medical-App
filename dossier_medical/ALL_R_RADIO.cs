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
    public partial class ALL_R_RADIO : Form
    {
        public ALL_R_RADIO()
        {
            InitializeComponent();
        }

        private void ALL_R_RADIO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dossier_medical_alectroniqueDataSet2.radio' table. You can move, or remove it, as needed.
            this.radioTableAdapter.Fill(this.dossier_medical_alectroniqueDataSet2.radio);

            this.reportViewer1.RefreshReport();
        }
    }
}
