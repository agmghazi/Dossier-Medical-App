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
    public partial class categorie__examen : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        
        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique  ;Integrated Security=true ");

        SqlCommand Cmd;
       
          SqlDataAdapter Da,fy;
          DataTable ft = new DataTable();
        DataTable Dt = new DataTable();
        DataTable Yt = new DataTable();
        DataTable mdt = new DataTable();
        DataTable effdt = new DataTable();
        DataTable EFCdt = new DataTable();
        DataTable comCdt = new DataTable();
        DataTable soCdt = new DataTable();





        public categorie__examen()
        {
            InitializeComponent();



            {

                  Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);

                Com_consu.DataSource = Dt;
                Com_consu.DisplayMember = "num_consult";
            }


            {

                fy = new SqlDataAdapter("Select * from traitement ", cn);
                fy.Fill(ft);

                num_tratim.DataSource = ft;
                num_tratim.DisplayMember = "num_trait";
            }

           





        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            {
                Cmd = new SqlCommand("adddata_medicament", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] Param_2 = new SqlParameter[3];
                Param_2[0] = new SqlParameter("@id_medic", SqlDbType.Int);
                Param_2[0].Value = id_medic.Text;

                Param_2[1] = new SqlParameter("@nom_medic", SqlDbType.VarChar, 30);
                Param_2[1].Value = txt_nom.Text;

                Param_2[2] = new SqlParameter("@num_consult", SqlDbType.Int);
                Param_2[2].Value = Com_consu.Text;




                Cmd.Parameters.AddRange(Param_2);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            {

                Cmd = new SqlCommand("adddata_traitement", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] Param_2 = new SqlParameter[5];
                Param_2[0] = new SqlParameter("@num_trait", SqlDbType.Int);
                Param_2[0].Value = num_tratim.Text;

                Param_2[1] = new SqlParameter("@d_d_trait", SqlDbType.Date);
                Param_2[1].Value = dt_tratim.Text;


                Param_2[2] = new SqlParameter("@d_f_trait", SqlDbType.Date);
                Param_2[2].Value = d_f_tratim.Text;

                Param_2[3] = new SqlParameter("@nom_trait", SqlDbType.VarChar, 30);
                Param_2[3].Value = nom_tratim.Text;
                Param_2[4] = new SqlParameter("@num_consult", SqlDbType.Int);
                Param_2[4].Value = Com_consu.Text;





                Cmd.Parameters.AddRange(Param_2);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Cmd = new SqlCommand("adddata_efficiency", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[3];
           

            Param[0] = new SqlParameter("@date_effic", SqlDbType.Date);
            Param[0].Value = date_effi.Text;


            Param[1] = new SqlParameter("@desc_effic", SqlDbType.VarChar, 80);
            Param[1].Value = txt_descr.Text;

            Param[2] = new SqlParameter("@num_trait", SqlDbType.Int);
            Param[2].Value = num_tratim.Text;



         



            Cmd.Parameters.AddRange(Param);
            cn.Open();
            
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);



            {


                {
                    Cmd = new SqlCommand("adddata_effet_secondaire", cn);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] Param_3 = new SqlParameter[4];


                    Param_3[0] = new SqlParameter("@date_effet", SqlDbType.Date);
                    Param_3[0].Value = dateeffsoc.Text;


                    Param_3[1] = new SqlParameter("@dgr_effet", SqlDbType.VarChar, 30);
                    Param_3[1].Value = textdeg0.Text;

                    Param_3[2] = new SqlParameter("@typ_effet", SqlDbType.VarChar, 30);
                    Param_3[2].Value = textypdg.Text;

                    Param_3[3] = new SqlParameter("@num_trait", SqlDbType.Int);
                    Param_3[3].Value = num_tratim.Text;




                    Cmd.Parameters.AddRange(Param_3);
                    cn.Open();
                    Cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    {
                        Cmd = new SqlCommand("adddata_complication", cn);
                        Cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter[] Param_4 = new SqlParameter[3];
                        
                        Param_4[0] = new SqlParameter("@typ_compl", SqlDbType.VarChar, 50);
                        Param_4[0].Value = textypcom.Text;


                        Param_4[1] = new SqlParameter("@desc_compl", SqlDbType.VarChar, 80);
                        Param_4[1].Value = textdesccom.Text;

                        Param_4[2] = new SqlParameter("@num_trait", SqlDbType.Int);
                        Param_4[2].Value = num_tratim.Text;

                      

                        Cmd.Parameters.AddRange(Param_4);
                        cn.Open();
                        Cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    }


                }


            }
        }

        private void Com_consu_TextChanged(object sender, EventArgs e)
        {

            try
            {

                mdt.Clear();
                Da = new SqlDataAdapter("SELECT * FROM medicament WHERE num_consult ='" + Com_consu.Text + "'", cn);
                Da.Fill(mdt);


                id_medic.Text = mdt.Rows[0]["id_medic"].ToString();
                txt_nom.Text = mdt.Rows[0]["nom_medic"].ToString();

            }
            catch
            {

                return;
            }

            try
            {

                Yt.Clear();
                Da = new SqlDataAdapter("SELECT * FROM traitement WHERE num_consult ='" + Com_consu.Text + "'", cn);
                Da.Fill(Yt);
                nom_tratim.Text = Yt.Rows[0]["nom_trait"].ToString();
                dt_tratim.Text = Yt.Rows[0]["d_d_trait"].ToString();
                d_f_tratim.Text = Yt.Rows[0]["d_f_trait"].ToString();

                id_medic.Text = Yt.Rows[0]["id_medic"].ToString();
                txt_nom.Text = Yt.Rows[0]["nom_medic"].ToString();

            }

            catch
            {
                return;
            }
           
                
                {
            }

        }

        private void Com_consu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void num_tratim_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                EFCdt.Clear();
                fy = new SqlDataAdapter("SELECT * FROM efficiency WHERE num_trait ='" + num_tratim.Text + "'", cn);
                fy.Fill(EFCdt);
                date_effi.Text = EFCdt.Rows[0]["date_effic"].ToString();
                txt_descr.Text = EFCdt.Rows[0]["desc_effic"].ToString();

            }
            catch
            {
                return;
            }
               

            try{

                soCdt.Clear();
                fy = new SqlDataAdapter("SELECT * FROM effet_secondaire WHERE num_trait ='" + num_tratim.Text + "'", cn);
                fy.Fill(soCdt);
                textdeg0.Text = soCdt.Rows[0]["dgr_effet"].ToString();
                textypdg.Text = soCdt.Rows[0]["typ_effet"].ToString();
                dateeffsoc.Text = soCdt.Rows[0]["date_effet"].ToString();
          


          


            }

            catch
            {
                return;
            }

            finally
            {


            comCdt.Clear();
            fy = new SqlDataAdapter("SELECT * FROM complication WHERE num_trait ='" + num_tratim.Text + "'", cn);
            fy.Fill(comCdt);
            textypcom.Text = comCdt.Rows[0]["typ_compl"].ToString();
            textdesccom.Text = comCdt.Rows[0]["desc_compl"].ToString();



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categorie__examen_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }
        }
    }

