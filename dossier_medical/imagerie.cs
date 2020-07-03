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
using System.IO;

namespace dossier_medical
{
    public partial class imagerie : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        DataTable Xt = new DataTable();


        string picPath = "";


        public imagerie()
        {
            InitializeComponent();


            {
                SqlDataAdapter ya;
                DataTable yt = new DataTable();
                ya = new SqlDataAdapter("Select * from radio ", cn);
                ya.Fill(yt);

                comboBoxNUM.DataSource = yt;
                comboBoxNUM.DisplayMember = "num_rad";
            }



            {
                SqlDataAdapter qa;
                DataTable qt = new DataTable();
                qa = new SqlDataAdapter("Select * from radio ", cn);
                qa.Fill(qt);

                Comb_NUM.DataSource = qt;
                Comb_NUM.DisplayMember = "num_rad";
            }



            {
                SqlDataAdapter yu;
                DataTable ytt = new DataTable();
                yu = new SqlDataAdapter("Select * from resultat_radio ", cn);
                yu.Fill(ytt);

                comboBoxID.DataSource = ytt;
                comboBoxID.DisplayMember = "id_rad";
            }


            {

                Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);

                comboBoxCONSU.DataSource = Dt;
                comboBoxCONSU.DisplayMember = "num_consult";
            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cmd = new SqlCommand("adddataRadio", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] Param = new SqlParameter[5];
                Param[0] = new SqlParameter("@num_rad", SqlDbType.VarChar, 50);
                Param[0].Value = Comb_NUM.Text;

                Param[1] = new SqlParameter("@entro_irm", SqlDbType.VarChar, 30);
                Param[1].Value = checkBoxIRM.Text;

                Param[2] = new SqlParameter("@num_consult", SqlDbType.VarChar, 30);
                Param[2].Value = comboBoxCONSU.Text;

                Param[3] = new SqlParameter("@TDM_ABDOMINAL", SqlDbType.VarChar, 20);
                Param[3].Value = checkBoxTDB.Text;

                Param[4] = new SqlParameter("@enrto_tdmm", SqlDbType.VarChar, 50);
                Param[4].Value = checkBoXTDM.Text;



                Cmd.Parameters.AddRange(Param);
                cn.Open();

                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" Added Succ ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "select  id_rad, result_rad from resultat_radio where num_rad= " + comboBoxNUM.Text + " ";

                if (cn.State != ConnectionState.Open  )
                cn.Open();
                Cmd = new SqlCommand(sql,cn);

                SqlDataReader reader = Cmd.ExecuteReader();
                reader.Read ();

                if (reader.HasRows)
                {
                    comboBoxID.Text = reader[0].ToString();
                  
                    byte[] img = (byte[])  (reader[1]);
                    if (img == null)

                        pictureBox1.Image= null;

                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }


                }
                else
                {

                    comboBoxNUM.Text = "";
                    comboBoxID.Text = "";
                    pictureBox1.Image = null;
                    
                    MessageBox.Show("this ID does not exist ");
                }

                cn.Close();
            }
            catch(Exception ex  )
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            try{
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*"; 
                dlg.Title="SELECT RAIO IMAGE";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                 picPath = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picPath;
            }
            }
                catch (Exception EX)
            {
                    MessageBox.Show(EX.Message);
               
    

            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(picPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "Insert into resultat_radio ( id_rad ,  num_rad , result_rad ) values ("+comboBoxID.Text+",'"+comboBoxNUM.Text+"',@img) ";
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                Cmd = new SqlCommand(sql, cn);
                Cmd.Parameters.Add(new SqlParameter("@img",img));
                int x = Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show  (x.ToString()+  "record(s)  saved. ");
                comboBoxNUM.Text= "";
                comboBoxID.Text= "";
                pictureBox1.Image= null;

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxTDB_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTDB.Text = "TDM_ABDOMINAL";
        }

        private void checkBoXTDM_CheckedChanged(object sender, EventArgs e)
        {
            checkBoXTDM.Text = "ENTRO TDM";
        }

        private void checkBoxIRM_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIRM.Text = "ENTRO IRM";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxCONSU_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Xt.Clear();
                Da = new SqlDataAdapter("SELECT * FROM radio WHERE num_consult ='" + comboBoxCONSU.Text + "'", cn);
                Da.Fill(Xt);


                Comb_NUM.Text = Xt.Rows[0]["num_consult"].ToString();
                checkBoxTDB.Text = Xt.Rows[0]["TDM_ABDOMINAL"].ToString();


                checkBoXTDM.Text = Xt.Rows[0]["enrto_tdmm"].ToString();
                checkBoxIRM.Text = Xt.Rows[0]["entro_irm"].ToString();

            }
            catch
            {

                return;
            }

        }

        private void imagerie_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }

    }
}
