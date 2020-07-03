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
    public partial class MEDECIN : Form
    {


        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        

        public MEDECIN()
        {
            InitializeComponent();

            SqlDataAdapter Da;
            DataTable Dt = new DataTable();
            {
                Da = new SqlDataAdapter("Select * from medecin ", cn);
                Da.Fill(Dt);
                comboBox2.DataSource = Dt;
                comboBox2.DisplayMember = "cod_med";
            }


            SqlDataAdapter Ra;
            DataTable Rt = new DataTable();
            {
                Ra = new SqlDataAdapter("Select * from consultation ", cn);
                Ra.Fill(Rt);
                comboBox1.DataSource = Rt;
                comboBox1.DisplayMember = "num_consult";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddatamedecin", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@cod_med", SqlDbType.VarChar,50);
            Param[0].Value = comboBox2.Text;

            Param[1] = new SqlParameter("@nom_med", SqlDbType.VarChar, 30);
            Param[1].Value = textBox3.Text;

            Param[2] = new SqlParameter("@pré_med", SqlDbType.VarChar, 30);
            Param[2].Value = textBox2.Text;


            Param[3] = new SqlParameter("@grade_med", SqlDbType.VarChar, 50);
            Param[3].Value = textBox4.Text;


            Param[4] = new SqlParameter("@spéc_med", SqlDbType.VarChar, 50);
            Param[4].Value = textBox5.Text;


            Param[5] = new SqlParameter("@num_consult", SqlDbType.Int);
            Param[5].Value = comboBox1.Text;

            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MEDECIN_Load(object sender, EventArgs e)
        {

        }
    }
}
