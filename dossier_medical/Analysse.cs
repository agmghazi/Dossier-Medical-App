//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace dossier_medical
//{




//    public partial class Analysse : DevExpress.XtraBars.Ribbon.RibbonForm
//    {


//        SqlConnection cn = new SqlConnection("Data Source= BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        
//        SqlCommand Cmd;
//        SqlDataAdapter Da;
//        DataTable Dt = new DataTable();
//        DataTable Xt = new DataTable();

//        SqlDataAdapter DN;
//        DataTable Nt = new DataTable();
//        DataTable At = new DataTable();

      
//        public Analysse()
//         {
//             InitializeComponent();




//             {
//                 SqlDataAdapter oi;
//                 DataTable vi = new DataTable();
//                 oi = new SqlDataAdapter("Select * from  G_Exam_Result ", cn);
//                 oi.Fill(vi);

//                 ID_analyse.DataSource = vi;
//                 ID_analyse.DisplayMember = "id_analy";

//             }


//             {
//                 SqlDataAdapter Di;
//                 DataTable Ni = new DataTable();
//                 Di = new SqlDataAdapter("Select * from  analyse ", cn);
//                 Di.Fill(Ni);

//                 Com_anal.DataSource = Ni;
//                 Com_anal.DisplayMember = "num_analy";

//             }




//             {

//                 DN = new SqlDataAdapter("Select * from  analyse ", cn);
//                 DN.Fill(Nt);

//                 COM_ANALYSE.DataSource = Nt;
//                 COM_ANALYSE.DisplayMember = "num_analy";

//             }


//             {

//                 Da = new SqlDataAdapter("Select * from consultation ", cn);
//                 Da.Fill(Dt);

//                 Com_Consuu.DataSource = Dt;
//                 Com_Consuu.DisplayMember = "num_consult";
//             }



//         }

//        private void button1_Click(object sender, EventArgs e)
//        {
          
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
            
//            try
//            {
              
//                SqlCommand cmd = new SqlCommand("AddAnalyse", cn);
//                cmd.CommandType = CommandType.StoredProcedure;




//                cmd.Parameters.AddWithValue("@num_analy",Com_anal.Text);

//                cmd.Parameters.AddWithValue("@num_consult", Com_Consuu.Text);
//                 cmd.Parameters.AddWithValue("@HB", checkBox6.Text);

//                cmd.Parameters.AddWithValue("@CRP", checkBox5.Text);

//                cmd.Parameters.AddWithValue("@ASAT", checkBox7.Text);
//                  cmd.Parameters.AddWithValue("@GB", checkBox2.Text);
//                cmd.Parameters.AddWithValue("@UREE", checkBox9.Text);
                

//                cmd.Parameters.AddWithValue("@PLAQUETTE", checkBox11.Text);

//                cmd.Parameters.AddWithValue("@FERRITINEMIE", checkBox3.Text);

//                cmd.Parameters.AddWithValue("@GGT", checkBox4.Text);

//                cmd.Parameters.AddWithValue("@CREATINEMIE", checkBox10.Text);

//                cmd.Parameters.AddWithValue("@ALAT", checkBox1.Text);



//                cmd.Parameters.AddWithValue("@PA", checkBox8.Text);





//                cn.Open();
//                cmd.ExecuteNonQuery();


        


//                cn.Close();

//                MessageBox.Show(" ADD Succ ", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Question);


//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }




//            //try
//            //{


//            //    string s = "";
//            //    foreach (Control cc in this.Controls)
//            //    {
//            //        if (cc is CheckBox)
//            //        {
//            //            CheckBox b = (CheckBox)cc;
//            //            if (b.Checked)
//            //            {
//            //                s = b.Text + "," + s;
//            //            }
//            //        }
//            //    }
//            //    cn.Open();
//            //    SqlCommand cmd = new SqlCommand("insert into analyse(num_analy,num_consult,nom_analy) values('" + Com_anal.Text + "','" + Com_Consuu.Text + "','" + s + "')", cn);

//            //    //SqlCommand cmd = new SqlCommand("insert into analyse(num_analy,nom_analy) values('" + Com_anal.Text + "','" + s + "')", cn);



//            //    cmd.ExecuteNonQuery();
//            //    cn.Close();
//            //    MessageBox.Show("Saved Successfully");
//            //}
//            //catch (Exception ex)
//            //{
//            //    MessageBox.Show(ex.Message);
//            //}



              
//          }

//        private void label8_Click(object sender, EventArgs e)
//        {

//        }

//        private void label12_Click(object sender, EventArgs e)
//        {

//        }

//        private void Analysse_Load(object sender, EventArgs e)
//        {
//            foreach (Control ctl in this.Controls)

//                if (ctl.GetType() == typeof(MdiClient))
//                {
//                    ctl.BackColor = Color.SteelBlue;
//                }
//        }

//        private void button5_Click(object sender, EventArgs e)
//        {



//        }

//        private void Com_Consuu_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            try
//            {
//                Xt.Clear();

//                Da = new SqlDataAdapter("SELECT * FROM analyse WHERE num_consult ='" + Com_Consuu.Text + "'", cn);
//                Da.Fill(Xt);

//                Com_anal.Text = Xt.Rows[0]["num_analy"].ToString();

//                checkBox6.Text = Xt.Rows[0]["HB"].ToString();

//                checkBox5.Text = Xt.Rows[0]["CRP"].ToString();

//                checkBox7.Text = Xt.Rows[0]["ASAT"].ToString();

//                checkBox2.Text = Xt.Rows[0]["GB"].ToString();

//                checkBox9.Text = Xt.Rows[0]["UREE"].ToString();

//                checkBox11.Text = Xt.Rows[0]["PLAQUETTE"].ToString();

//                checkBox3.Text = Xt.Rows[0]["FERRITINEMIE"].ToString();

//                checkBox4.Text = Xt.Rows[0]["GGT"].ToString();

//                checkBox10.Text = Xt.Rows[0]["CREATINEMIE"].ToString();

//                checkBox1.Text = Xt.Rows[0]["ALAT"].ToString();

//                checkBox8.Text = Xt.Rows[0]["PA"].ToString();

//            }
//            catch 
//            {

//                return;
//            }
//        }

//        private void checkBox5_CheckedChanged(object sender, EventArgs e)
//        {
//            checkBox5.Text = null;

//        }

//        private void checkBox6_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox6.Text = "HB";

//        }

//        private void checkBox7_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox7.Text = "ASAT";

//        }

//        private void checkBox2_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox2.Text = "GB";

//        }

//        private void checkBox9_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox9.Text = "UREE";

//        }

//        private void checkBox11_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox11.Text = "PLAQUETTE";

//        }

//        private void checkBox3_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox3.Text = "FERRITINEMIE";

//        }

//        private void checkBox4_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox4.Text = "GGT";

//        }

//        private void checkBox10_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox10.Text = "CREATINEMIE";

//        }

//        private void checkBox1_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox1.Text = "ALAT";

//        }

//        private void checkBox8_CheckedChanged(object sender, EventArgs e)
//        {
//            //checkBox8.Text = "PA";

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {


//            try
//            {


//            Cmd = new SqlCommand("adddataG_Exam_Result", cn);
//            Cmd.CommandType = CommandType.StoredProcedure;
//            SqlParameter[] Param = new SqlParameter[15];
//            Param[0] = new SqlParameter("@id_analy", SqlDbType.Int);
//            Param[0].Value = ID_analyse.Text;

//            Param[1] = new SqlParameter("@nom_analy", SqlDbType.VarChar, 30);
//            Param[1].Value = textBox10.Text;

//            Param[2] = new SqlParameter("@num_analy", SqlDbType.Int);
//            Param[2].Value = COM_ANALYSE.Text;

//            Param[3] = new SqlParameter("@date_analy", SqlDbType.DateTime);
//            Param[3].Value = dateTimePicker1.Text;

//            Param[4] = new SqlParameter("@result_CRP", SqlDbType.VarChar, 50);
//            Param[4].Value = textBox1.Text;

//            Param[5] = new SqlParameter("@result_HB", SqlDbType.VarChar, 50);
//            Param[5].Value = textBox5.Text;

//            Param[6] = new SqlParameter("@result_ASAT", SqlDbType.VarChar, 50);
//            Param[6].Value = textBox4.Text;

//            Param[7] = new SqlParameter("@result_PA", SqlDbType.VarChar, 50);
//            Param[7].Value = textBox11.Text;

//            Param[8] = new SqlParameter("@result_GB", SqlDbType.VarChar, 50);
//            Param[8].Value = textBox6.Text;

//            Param[9] = new SqlParameter("@result_ALAT", SqlDbType.VarChar, 50);
//            Param[9].Value = textBox2.Text;

//            Param[10] = new SqlParameter("@result_UREE", SqlDbType.VarChar, 50);
//            Param[10].Value = textBox7.Text;

//            Param[11] = new SqlParameter("@result_FERRITINEMIE", SqlDbType.VarChar, 50);
//            Param[11].Value = textBox8.Text;

//            Param[12] = new SqlParameter("@result_CREATINEMIE", SqlDbType.VarChar, 50);
//            Param[12].Value = textBox3.Text;


//            Param[13] = new SqlParameter("@result_PLAQUETTE", SqlDbType.VarChar, 50);
//            Param[13].Value = textBox9.Text;

//            Param[14] = new SqlParameter("@result_GGT", SqlDbType.VarChar, 50);
//            Param[14].Value = textBox12.Text;

//            Cmd.Parameters.AddRange(Param);
//            cn.Open();
//            Cmd.ExecuteNonQuery();
//            cn.Close();
//            MessageBox.Show(" add Succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);




//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }

//        private void COM_ANALYSE_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            try
//            {



//                At.Clear();

//                DN = new SqlDataAdapter("SELECT * FROM G_Exam_Result WHERE num_analy ='" + COM_ANALYSE.Text + "'", cn);
//                DN.Fill(At);



//                ID_analyse.Text = At.Rows[0]["id_analy"].ToString();


//                textBox10.Text = At.Rows[0]["nom_analy"].ToString();


//                dateTimePicker1.Text = At.Rows[0]["date_analy"].ToString();


//                textBox1.Text = At.Rows[0]["result_CRP"].ToString();

//                textBox5.Text = At.Rows[0]["result_HB"].ToString();

//                textBox4.Text = At.Rows[0]["result_ASAT"].ToString();

//                textBox11.Text = At.Rows[0]["result_PA"].ToString();

//                textBox6.Text = At.Rows[0]["result_GB"].ToString();

//                textBox2.Text = At.Rows[0]["result_ALAT"].ToString();

//                textBox7.Text = At.Rows[0]["result_UREE"].ToString();

//                textBox8.Text = At.Rows[0]["result_FERRITINEMIE"].ToString();

//                textBox3.Text = At.Rows[0]["result_CREATINEMIE"].ToString();
//                textBox8.Text = At.Rows[0]["result_PLAQUETTE"].ToString();
//                textBox9.Text = At.Rows[0]["result_FERRITINEMIE"].ToString();
//                textBox12.Text = At.Rows[0]["result_GGT"].ToString();



             

//            }
//            catch
//            {

//                return;


//            }
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox3_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void panel3_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void ribbonControl1_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
