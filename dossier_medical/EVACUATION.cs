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
    public partial class EVACUATION : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        DataTable XD = new DataTable();


        public EVACUATION()
        {
            InitializeComponent();



            {
                Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);
                comboBox1.DataSource = Dt;
                comboBox1.DisplayMember = "num_consult";
            }

            SqlDataAdapter Ra;
            DataTable Rt = new DataTable();
            {
                Ra = new SqlDataAdapter("Select * from evacuation ", cn);
                Ra.Fill(Rt);
                comboBox2.DataSource = Rt;
                comboBox2.DisplayMember = "num_evac";

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddataevacuation", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@num_evac", SqlDbType.Int);
            Param[0].Value = comboBox2.Text;

            Param[1] = new SqlParameter("@date_evac", SqlDbType.Date);
            Param[1].Value = dateTimePicker1.Text;

            Param[2] = new SqlParameter("@motif_evac", SqlDbType.VarChar, 30);
            Param[2].Value = textBox1.Text;

            Param[3] = new SqlParameter("@serv_dist", SqlDbType.VarChar, 30);
            Param[3].Value = textBox2.Text;

            Param[4] = new SqlParameter("@num_consult", SqlDbType.Int);
            Param[4].Value = comboBox1.Text;



            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EVACUATION_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                XD.Clear();

                Da = new SqlDataAdapter("SELECT * FROM evacuation WHERE num_consult ='" + comboBox1.Text + "'", cn);
                Da.Fill(XD);



                comboBox2.Text = XD.Rows[0]["num_evac"].ToString();
                textBox2.Text = XD.Rows[0]["serv_dist"].ToString();
                dateTimePicker1.Text = XD.Rows[0]["date_evac"].ToString();
                textBox1.Text = XD.Rows[0]["motif_evac"].ToString();




            }
            catch
            {

                return;

            }
        }
    }
}
