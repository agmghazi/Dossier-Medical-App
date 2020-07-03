using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dossier_medical
{
    public partial class Backup : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;



        public Backup()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup Files (*.Bak) |*.back";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                Cmd = new SqlCommand("Backup Database dossier_medical_alectronique To Disk ='" + sf.FileName + "'", cn);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("تمت عملية حفط نسخة من قاعدة البيانات بنجاح ", "نسخ قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
