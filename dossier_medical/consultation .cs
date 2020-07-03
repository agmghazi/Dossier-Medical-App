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
    public partial class consultation : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;


        SqlDataAdapter Da;

        DataTable Dt = new DataTable();
        DataTable Yt = new DataTable();
        DataTable xt = new DataTable();



        public consultation()
        {
            InitializeComponent();



           



            {
                Da = new SqlDataAdapter("Select * from malade ", cn);

                Da.Fill(Dt);
                comboBox1.DataSource = Dt;
                comboBox1.DisplayMember = "cod_mal";
            }
           

            //SqlDataAdapter Ra;
            DataTable Rt = new DataTable();

            {

                //Ra = new SqlDataAdapter("Select * from consultation ", cn);
                //Ra.Fill(Rt);
                //comboBox2.DataSource = Rt;
                //comboBox2.DisplayMember = "cod_mal";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {



                Cmd = new SqlCommand("adddataconsultation", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] Param = new SqlParameter[4];
                Param[0] = new SqlParameter("@num_consult", SqlDbType.Int);
                Param[0].Value = comboBox3.Text;

                Param[1] = new SqlParameter("@date_consult", SqlDbType.Date);
                Param[1].Value = dateTimePicker1.Text;

                Param[2] = new SqlParameter("@desc_consult", SqlDbType.VarChar, 80);
                Param[2].Value = textBox2.Text;


                Param[3] = new SqlParameter("@cod_mal", SqlDbType.VarChar, 30);
                Param[3].Value = comboBox1.Text;

                

                Cmd.Parameters.AddRange(Param);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xt.Clear();
                Da = new SqlDataAdapter("SELECT * FROM consultation WHERE num_consult ='" + comboBox3.Text + "'", cn);
                Da.Fill(xt);





                dateTimePicker1.Text = xt.Rows[0]["date_consult"].ToString();
                textBox2.Text = xt.Rows[0]["desc_consult"].ToString();

            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DIAGNOSTIC FRM = new DIAGNOSTIC();
            FRM.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Yt.Clear();
                Da = new SqlDataAdapter("SELECT * FROM consultation WHERE cod_mal ='" + comboBox1.Text + "'", cn);
                Da.Fill(Yt);


                comboBox3.DataSource = Yt;
                comboBox3.DisplayMember = "num_consult";


              
                dateTimePicker1.Text = Yt.Rows[0]["date_consult"].ToString();
                textBox2.Text = Yt.Rows[0]["desc_consult"].ToString();

            }
            catch
            {
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.DisplayMember = null;

            comboBox1.Text = null;

            dateTimePicker1.Text = null;
            textBox2.Text = null;

        }
    }
}
