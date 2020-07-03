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
    public partial class EXAMEN_GENERALE : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;

        SqlDataAdapter Da;
        SqlDataAdapter ra;

        DataTable ty= new DataTable();
        DataTable Dt = new DataTable();
        DataTable YT = new DataTable();
        public EXAMEN_GENERALE()
        {
            InitializeComponent();
            {
                Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);
                com_consu.DataSource = Dt;
                com_consu.DisplayMember = "num_consult";
            }

            fillDataGridView();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Red;

        }
        void fillDataGridView()
        {
            ty.Clear();

            Cmd = new SqlCommand("selecall_General_exame", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            ra = new SqlDataAdapter(Cmd);
            ra.Fill(ty);
            this.dataGridView1.DataSource = ty;
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
           
        }

        private void BT_EDIT_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("updGeneral_exame", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nbr_sel_nuit", TXTNUM44.Text);

                cmd.Parameters.AddWithValue("@num_consult", com_consu.Text);

                cmd.Parameters.AddWithValue("@nbr_sel_nform", TXT_COD.Text);

                cmd.Parameters.AddWithValue("@nbr_evac_glair", TXT_EVAC.Text);

                cmd.Parameters.AddWithValue("@nbr_evac_sang", TXT_NATI.Text);

                cmd.Parameters.AddWithValue("@dlr_abdo", TXT_TEL.Text);

                cmd.Parameters.AddWithValue("@imperiosit_incon", TXT_incon.Text);

                cmd.Parameters.AddWithValue("@astenie", textBo.Text);

                cmd.Parameters.AddWithValue("@fievre", TXT_LIEU.Text);

                cmd.Parameters.AddWithValue("@dlr_articl", textBox3.Text);

                cmd.Parameters.AddWithValue("@ex_physiq", TXT_PHY.Text);

                cmd.Parameters.AddWithValue("@poid", TXT_POI.Text);

                cmd.Parameters.AddWithValue("@taille", TXT_TAIL.Text);

                cmd.Parameters.AddWithValue("@abd_provoq", textBox5.Text);

                cmd.Parameters.AddWithValue("@adenopathie", textB.Text);

                cmd.Parameters.AddWithValue("@prise", textBox44.Text);

                cmd.Parameters.AddWithValue("@perinee", TXT_AD.Text);

                cmd.Parameters.AddWithValue("@num_exam", TXT_Num.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show(" Update Succ ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_DELET_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Cmd = new SqlCommand("DELET_GENERAL_EXAM", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Param = new SqlParameter();
                Param = new SqlParameter("@num_exam", SqlDbType.Int);
                Param.Value = TXT_Num.Text;
                Cmd.Parameters.Add(Param);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.OK, MessageBoxIcon.Question);

                fillDataGridView();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Dt.Clear();



            Da = new SqlDataAdapter("select * from General_exame where  num_exam     Like '%" + textBox1.Text + "%'", cn);

            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("DATAGeneral_exame", cn);
                cmd.CommandType = CommandType.StoredProcedure;




                cmd.Parameters.AddWithValue("@nbr_sel_nuit", TXTNUM44.Text);

                cmd.Parameters.AddWithValue("@num_consult", com_consu.Text);

                cmd.Parameters.AddWithValue("@nbr_sel_nform", TXT_COD.Text);

                cmd.Parameters.AddWithValue("@nbr_evac_glair", TXT_EVAC.Text);

                cmd.Parameters.AddWithValue("@nbr_evac_sang", TXT_NATI.Text);


                cmd.Parameters.AddWithValue("@dlr_abdo", TXT_TEL.Text);

                cmd.Parameters.AddWithValue("@imperiosit_incon", TXT_incon.Text);

                cmd.Parameters.AddWithValue("@astenie", textBo.Text);

                cmd.Parameters.AddWithValue("@fievre", TXT_LIEU.Text);

                cmd.Parameters.AddWithValue("@dlr_articl", textBox3.Text);



                cmd.Parameters.AddWithValue("@ex_physiq", TXT_PHY.Text);


                cmd.Parameters.AddWithValue("@poid", TXT_POI.Text);

                cmd.Parameters.AddWithValue("@taille", TXT_TAIL.Text);

                cmd.Parameters.AddWithValue("@abd_provoq", textBox5.Text);

                cmd.Parameters.AddWithValue("@adenopathie", textB.Text);

                cmd.Parameters.AddWithValue("@prise", textBox44.Text);

                cmd.Parameters.AddWithValue("@perinee", TXT_AD.Text);

                cmd.Parameters.AddWithValue("@num_exam", TXT_Num.Text);



                //SqlParameter outparam = new SqlParameter();
                //outparam.ParameterName = "@num_exam";
                //outparam.SqlDbType = System.Data.SqlDbType.Int;
                //outparam.Direction = System.Data.ParameterDirection.Output;
                //cmd.Parameters.Add(outparam);
                cn.Open();
                cmd.ExecuteNonQuery();


                //string num_ex = outparam.Value.ToString();


                cn.Close();

                MessageBox.Show(" ADD Succ ", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Question);

                fillDataGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void com_consu_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                YT.Clear();
                Da = new SqlDataAdapter("SELECT * FROM General_exame WHERE num_consult ='" + com_consu.Text + "'", cn);
                Da.Fill(YT);
                TXTNUM44.Text = YT.Rows[0]["nbr_sel_nuit"].ToString();

                TXT_COD.Text = YT.Rows[0]["nbr_sel_nform"].ToString();

                TXT_EVAC.Text = YT.Rows[0]["nbr_evac_glair"].ToString();


                TXT_NATI.Text = YT.Rows[0]["nbr_evac_sang"].ToString();

                TXT_incon.Text = YT.Rows[0]["imperiosit_incon"].ToString();


                textBo.Text = YT.Rows[0]["astenie"].ToString();


                TXT_LIEU.Text = YT.Rows[0]["fievre"].ToString();

                textBox3.Text = YT.Rows[0]["dlr_articl"].ToString();

                TXT_PHY.Text = YT.Rows[0]["ex_physiq"].ToString();

                TXT_POI.Text = YT.Rows[0]["poid"].ToString();

                TXT_TAIL.Text = YT.Rows[0]["taille"].ToString();


                textBox5.Text = YT.Rows[0]["abd_provoq"].ToString();

                textB.Text = YT.Rows[0]["adenopathie"].ToString();

                textBox44.Text = YT.Rows[0]["perinee"].ToString();

                TXT_Num.Text = YT.Rows[0]["num_exam"].ToString();

            }
            catch
            {
                return;
            }
        }

        private void Print_All_Click(object sender, EventArgs e)
        {
            All_report_EXAMEN_GENERALE frm = new All_report_EXAMEN_GENERALE();
            Da = new SqlDataAdapter("select * from General_exame where num_exam=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet4.General_exame);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select_Report_EXAMEN_GENERALE frm = new Select_Report_EXAMEN_GENERALE();
            Da = new SqlDataAdapter("select * from General_exame where num_exam=' " + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet4.General_exame);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TXTNUM44.Text = dataGridView1.CurrentRow.Cells["nbr_sel_nuit"].Value.ToString();


            TXT_COD.Text = null;


            TXT_EVAC.Text = null;

            TXT_NATI.Text = null;

            TXT_incon.Text = null;


            textBo.Text = null;


            TXT_LIEU.Text = null;


            textBox3.Text = null;

            TXT_PHY.Text = null;

            TXT_POI.Text = null;
            TXTNUM44.Text = null;
            TXT_TAIL.Text = null;

            textBox5.Text = null;

            textB.Text = null;
            TXT_AD.Text = null;
            textBox44.Text = null;
            TXT_Num.Text = null; 
        }

        private void EXAMEN_GENERALE_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }
    }
}
