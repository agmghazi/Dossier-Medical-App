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
    public partial class V_REPORT_1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {



        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlDataAdapter Da;
        SqlDataAdapter Ma;
        SqlDataAdapter DD;

        DataTable Dt = new DataTable();
        DataTable Mt = new DataTable();

        DataTable DDT = new DataTable();


        public V_REPORT_1()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("SELECT * FROM analyse ", cn);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;

            Ma = new SqlDataAdapter("SELECT * FROM medicament ", cn);
            Ma.Fill(Mt);
            this.dataGridView2.DataSource = Mt;

            DD = new SqlDataAdapter("SELECT * FROM radio ", cn);
            DD.Fill(DDT);
            this.dataGridView3.DataSource = DDT;
        }

        private void Print_All_Click(object sender, EventArgs e)
        {
            ALL_RE_analyse frm = new ALL_RE_analyse();
            //Da = new SqlDataAdapter("select * from analyse where num_consult=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet1.analyse);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Dt.Clear();

            Da = new SqlDataAdapter("SELECT * FROM analyse  where convert (varchar ,num_analy) + convert (varchar , num_consult )  + convert ( varchar , CRP)  Like '%" + textBox1.Text + "%'   ", cn);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SELECT_R_analysee frm = new SELECT_R_analysee();
            Da = new SqlDataAdapter("select * from analyse where num_analy=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet1.analyse);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void SELECT_DATA_Click(object sender, EventArgs e)
        {
            SELECT_R_medicamentt frm = new SELECT_R_medicamentt();
            Ma = new SqlDataAdapter("select * from medicament where id_medic=' " + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Ma.Fill(frm.dossier_medical_alectroniqueDataSet.medicament);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Mt.Clear();
            Ma = new SqlDataAdapter("SELECT * FROM medicament  where convert (varchar , id_medic) + convert (varchar , nom_medic )  + convert ( varchar , num_trait)  Like '%" + textBox2.Text + "%'   ", cn);
            Ma.Fill(Mt);
            this.dataGridView2.DataSource = Mt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ALL_R_medicament frm = new ALL_R_medicament();
            //Ma = new SqlDataAdapter("select * from medicament where id_medic=' " + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Ma.Fill(frm.dossier_medical_alectroniqueDataSet.medicament);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            DDT.Clear();
            DD = new SqlDataAdapter("SELECT * FROM radio  where convert (varchar ,num_rad) + convert (varchar , nom_rad )  + convert ( varchar , num_consult)  Like '%" + textBox3.Text + "%'   ", cn);
            DD.Fill(DDT);
            this.dataGridView3.DataSource = DDT;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SELECT_R_RADIO frm = new SELECT_R_RADIO();
            DD = new SqlDataAdapter("select * from radio where num_rad=' " + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            DD.Fill(frm.dossier_medical_alectroniqueDataSet2.radio);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ALL_R_RADIO frm = new ALL_R_RADIO();
            //DD = new SqlDataAdapter("select * from radio where num_rad=' " + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            DD.Fill(frm.dossier_medical_alectroniqueDataSet2.radio);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void V_REPORT_1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }
    }
}
