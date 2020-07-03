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
    public partial class Restory : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");


        SqlCommand Cmd;



        public Restory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strQuery = "ALTER Database dossier_medical_alectronique SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database dossier_medical_alectronique From Disk='" + txtFileName.Text + "'";
            Cmd = new SqlCommand(strQuery, cn);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }
    }
}
