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
    public partial class ENDOSCOPIE : DevExpress.XtraBars.Ribbon.RibbonForm
    {



        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;

        SqlDataAdapter Ra;

        DataTable DR = new DataTable();
        DataTable tR = new DataTable();


        SqlDataAdapter Ma;

        DataTable MR = new DataTable();


        DataTable qR = new DataTable();


        public ENDOSCOPIE()
        {
            InitializeComponent();

            SqlDataAdapter Da;

            DataTable Dt = new DataTable();
            {

                Da = new SqlDataAdapter("Select * from resultat_endoscopie ", cn);
                Da.Fill(Dt);
                comboBox5.DataSource = Dt;
                comboBox5.DisplayMember = "id_end";

            }

            {
                Ra = new SqlDataAdapter("Select * from consultation ", cn);
                Ra.Fill(DR);
                comboBox1.DataSource = DR;
                comboBox1.DisplayMember = "num_consult";
            }


            SqlDataAdapter Ma;

            DataTable MR = new DataTable();
            {
                Ma = new SqlDataAdapter("Select * from endoscopie ", cn);
                Ma.Fill(MR);
                comboBox2.DataSource = MR;
                comboBox2.DisplayMember = "num_end";
                comboBox4.DataSource = MR;
                comboBox4.DisplayMember = "num_end";
            }

            {
                SqlDataAdapter wa;

                DataTable zR = new DataTable();
                {
                    wa = new SqlDataAdapter("Select * from endoscopie ", cn);
                    wa.Fill(zR);

                    comboBox4.DataSource = zR;
                    comboBox4.DisplayMember = "num_end";
                }

            }


          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddataendoscopie", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@num_end", SqlDbType.Int);
            Param[0].Value = comboBox2.Text;

            Param[1] = new SqlParameter("@nom_end", SqlDbType.VarChar, 30);
            Param[1].Value = textBox3.Text;
            Param[2] = new SqlParameter("@num_consult", SqlDbType.Int);
            Param[2].Value = comboBox1.Text;


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

        private void button3_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddataresultat_endoscopie", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@id_end", SqlDbType.Int);
            Param[0].Value = comboBox5.Text;

            Param[1] = new SqlParameter("@nom_end", SqlDbType.VarChar, 30);
            Param[1].Value = textBox4.Text;

            Param[2] = new SqlParameter("@result_end", SqlDbType.VarChar, 50);
            Param[2].Value = textBox1.Text;

            Param[3] = new SqlParameter("@num_end", SqlDbType.Int);
            Param[3].Value = comboBox4.Text;


            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    tR.Clear();

                    Ra = new SqlDataAdapter("SELECT * FROM endoscopie WHERE num_consult ='" + comboBox1.Text + "'", cn);
                    Ra.Fill(tR);

                    comboBox2.Text = tR.Rows[0]["num_end"].ToString();

                    textBox3.Text = tR.Rows[0]["nom_end"].ToString();
                }
                {

                    qR.Clear();

                    Ma = new SqlDataAdapter("SELECT * FROM resultat_endoscopie WHERE num_end ='" + comboBox4.Text + "'", cn);
                    Ma.Fill(qR);

                    textBox4.Text = qR.Rows[0]["nom_end"].ToString();

                    textBox1.Text = qR.Rows[0]["result_end"].ToString();
                    comboBox5.Text = qR.Rows[0]["id_end"].ToString();

                    

                }
            }
            catch 
            {

                return;

            }



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                
                {

                    qR.Clear();

                    Ma = new SqlDataAdapter("SELECT * FROM resultat_endoscopie WHERE num_end ='" + comboBox4.Text + "'", cn);
                    Ma.Fill(qR);

                    textBox4.Text = qR.Rows[0]["nom_end"].ToString();

                    textBox1.Text = qR.Rows[0]["result_end"].ToString();
                    comboBox5.Text = qR.Rows[0]["id_end"].ToString();



                }
            }
            catch
            {

                return;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENDOSCOPIE_Load(object sender, EventArgs e)
        {

            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }
    }

            
        
    
}
