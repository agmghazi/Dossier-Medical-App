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
    public partial class RENDEZ_VOUS : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        SqlDataAdapter qa;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        DataTable rt = new DataTable();
        DataTable ft = new DataTable();

        public RENDEZ_VOUS()
        {
            InitializeComponent();



            fillDataGridView();


            {
                SqlDataAdapter ua;
                DataTable ut = new DataTable();
                ua = new SqlDataAdapter("Select * from rendez_vous ", cn);
                ua.Fill(ut);
                ID_COM.DataSource = ut;
                ID_COM.DisplayMember = "ID";
            }

            {
                Da = new SqlDataAdapter("Select * from malade ", cn);
                Da.Fill(Dt);
                comboBox1.DataSource = Dt;
                comboBox1.DisplayMember = "cod_mal";
            }
        }

            void fillDataGridView()
        {

            rt.Clear();

            Cmd = new SqlCommand("RENDEZ_VOUS_select", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            qa = new SqlDataAdapter(Cmd);
            qa.Fill(rt);
            this.dataGridView1.DataSource = rt;
        }
           
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = DateTime.Value;
            DateTime t = DateTime.Value;
            DateTime dtCombined = new DateTime(d.Year, d.Month, d.Day, t.Hour, t.Minute, t.Second);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Cmd = new SqlCommand("adddata_rendez_vous", cn);
                Cmd.CommandType = CommandType.StoredProcedure;


              
                Cmd.Parameters.AddWithValue("@cod_mal", this.comboBox1.Text);


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

        private void RENDEZ_VOUS_Load(object sender, EventArgs e)
        {
              foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ft.Clear();
                Da = new SqlDataAdapter("SELECT * FROM rendez_vous WHERE cod_mal ='" + comboBox1.Text + "'", cn);
                Da.Fill(ft);
                ID_COM.Text = ft.Rows[0]["ID"].ToString();
                DateTime.Text = ft.Rows[0]["date_rdv"].ToString();
             

            }
            catch
            {
                return;
            }
       
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try{

            DialogResult dialog = MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Cmd = new SqlCommand("rendz_DELET", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Param = new SqlParameter();
                Param = new SqlParameter("@ID", SqlDbType.Int);
                Param.Value = ID_COM.Text;
                Cmd.Parameters.Add(Param);

                //Cmd.Parameters.AddWithValue("@date_rdv", DateTime.Text);


                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.OK, MessageBoxIcon.Question);

              
            }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void RENDEZ_VOUS_Activated(object sender, EventArgs e)
        {
            fillDataGridView();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ID_COM.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            comboBox1.Text = dataGridView1.CurrentRow.Cells["cod_mal"].Value.ToString();

            DateTime.Text = dataGridView1.CurrentRow.Cells["date_rdv"].Value.ToString();

           

        }
        }
}
