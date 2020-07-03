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
    public partial class REPORT_evacuation : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlDataAdapter Da;

        DataTable Dt = new DataTable();


        public REPORT_evacuation()
        {
            InitializeComponent();

            Da = new SqlDataAdapter("SELECT * FROM evacuation ", cn);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Dt.Clear();

            Da = new SqlDataAdapter("SELECT * FROM evacuation  where convert (varchar ,num_evac) + convert (varchar , date_evac )  + convert ( varchar , motif_evac)  Like '%" + textBox1.Text + "%'   ", cn);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SELECT_R_evacuation frm = new SELECT_R_evacuation();
            Da = new SqlDataAdapter("select * from evacuation where num_evac=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet3.evacuation);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void Print_All_Click(object sender, EventArgs e)
        {
            ALL_R_evacuation frm = new ALL_R_evacuation();
            //Da = new SqlDataAdapter("select * from evacuation where num_evac=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet3.evacuation);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void REPORT_evacuation_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }

        }
    }
}
