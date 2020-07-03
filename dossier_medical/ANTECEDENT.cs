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
    public partial class ANTECEDENT : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SqlConnection cn = new SqlConnection(@" Data Source=.;Database=dossier_medical_alectronique;Integrated Security=true");


        //SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        DataTable Kt  = new DataTable();




        public ANTECEDENT()
        {
            InitializeComponent();


            Da = new SqlDataAdapter("Select * from malade ", cn);
            Da.Fill(Dt);
            comboBox1.DataSource = Dt;
            comboBox1.DisplayMember = "cod_mal";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddataantecedent", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@cod_ant", SqlDbType.VarChar,50);
            Param[0].Value = Txt_Cod.Text;

            Param[1] = new SqlParameter("@tabac", SqlDbType.Char,10);
            Param[1].Value = Com_Tabac.Text;

            Param[2] = new SqlParameter("@ant_per", SqlDbType.VarChar, 50);
            Param[2].Value = textBox5.Text;

            Param[3] = new SqlParameter("@ant_fam", SqlDbType.Char,10);
            Param[3].Value = textBox4.Text;

            Param[4] = new SqlParameter("@Cod_malade", SqlDbType.VarChar,30);
            Param[4].Value = comboBox1.Text;



            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Kt.Clear();

                Da = new SqlDataAdapter("SELECT * FROM antecedent WHERE Cod_malade ='" + comboBox1.Text + "'", cn);
                Da.Fill(Kt);
                Txt_Cod.Text = Kt.Rows[0]["cod_ant"].ToString();
                Com_Tabac.Text = Kt.Rows[0]["tabac"].ToString();
                textBox4.Text = Kt.Rows[0]["ant_fam"].ToString();


                textBox5.Text = Kt.Rows[0]["ant_per"].ToString();
                

            }
            catch
            {
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txt_Cod.Text =null;
            Com_Tabac.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }
    }
}
