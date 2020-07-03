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
    public partial class DIAGNOSTIC : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;

        SqlDataAdapter Ra;
        DataTable Rt = new DataTable();
        DataTable mt = new DataTable();
        
        public DIAGNOSTIC()
        {
            InitializeComponent();

            //SqlDataAdapter Da;
            //DataTable Dt = new DataTable();
            //{
            //    Da = new SqlDataAdapter("Select * from diagnostic ", cn);
            //    Da.Fill(Dt);
            //    comboBox1.DataSource = Dt;
            //    comboBox1.DisplayMember = "num_diag";
            //}


           

            {

                Ra = new SqlDataAdapter("Select * from consultation ", cn);
                Ra.Fill(Rt);
                comboBox2.DataSource = Rt;
                comboBox2.DisplayMember = "num_consult";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {


                Cmd = new SqlCommand("adddatadiagnostic", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] Param = new SqlParameter[6];
                Param[0] = new SqlParameter("@num_diag", SqlDbType.VarChar, 50);
                Param[0].Value = comboBox1.Text;

                Param[1] = new SqlParameter("@date_diag", SqlDbType.Date);
                Param[1].Value = dateTimePicker1.Text;

                Param[2] = new SqlParameter("@topg", SqlDbType.VarChar, 50);
                Param[2].Value = textBox1.Text;


                Param[3] = new SqlParameter("@phtyp", SqlDbType.VarChar, 50);
                Param[3].Value = textBox3.Text;


                Param[4] = new SqlParameter("@desc_diag", SqlDbType.VarChar, 80);
                Param[4].Value = textBox2.Text;

                Param[5] = new SqlParameter("@num_Consult", SqlDbType.Int);
                Param[5].Value = comboBox2.Text;

                Cmd.Parameters.AddRange(Param);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mt.Clear();

                Ra = new SqlDataAdapter("SELECT * FROM diagnostic WHERE num_consult ='" + comboBox2.Text + "'", cn);
                Ra.Fill(mt);
                comboBox1.Text = mt.Rows[0]["num_diag"].ToString();
                dateTimePicker1.Text = mt.Rows[0]["date_diag"].ToString();
                textBox1.Text = mt.Rows[0]["topg"].ToString();

                textBox3.Text = mt.Rows[0]["phtyp"].ToString();
                textBox2.Text = mt.Rows[0]["desc_diag"].ToString();

            }
            catch
            {
                return;
            }

        }

        private void DIAGNOSTIC_Load(object sender, EventArgs e)
        {

        }
    }
}
