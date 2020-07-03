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
    public partial class EdMalade : DevExpress.XtraBars.Ribbon.RibbonForm
    {



        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public EdMalade()
        {
            InitializeComponent();

            fillDataGridView();



           


            
        }

        void fillDataGridView()
        {
            Dt.Clear();

            Cmd = new SqlCommand("SELECTALL", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;



        }


        private void BT_ADD_Click(object sender, EventArgs e)
        {

            EDMALADE_ADD FRM = new EDMALADE_ADD();
          FRM.ShowDialog();
        }

        private void BT_DELET_Click(object sender, EventArgs e)
        {
            DialogResult dialog =  MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dialog ==DialogResult.Yes)
            {
            Cmd = new SqlCommand("DELET", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter Param = new SqlParameter();
            Param = new SqlParameter("@cod_mal", SqlDbType.VarChar, 50);
            Param.Value = TXT_COD.Text;
            Cmd.Parameters.Add(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.OK, MessageBoxIcon.Question);

            fillDataGridView();

        }

          
        }

        private void BT_EDIT_Click(object sender, EventArgs e)
        {


            Cmd = new SqlCommand("UPDATEDATA", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[13];
            Param[0] = new SqlParameter("@cod_mal", SqlDbType.VarChar, 50);
            Param[0].Value = TXT_COD.Text;

            Param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            Param[1].Value = TXT_NOM.Text;

            Param[2] = new SqlParameter("@pré_mal", SqlDbType.VarChar, 30);
            Param[2].Value = TXT_PRENOM.Text;

            Param[3] = new SqlParameter("@sex", SqlDbType.VarChar, 20);
            Param[3].Value = comboBox1.Text;

            Param[4] = new SqlParameter("@adrs", SqlDbType.VarChar, 50);
            Param[4].Value = TXT_ADRESS.Text;

            Param[5] = new SqlParameter("@prof", SqlDbType.VarChar, 50);
            Param[5].Value = TXT_PROF.Text;

            Param[6] = new SqlParameter("@d_n_mal", SqlDbType.Date);
            Param[6].Value = DATE.Text;

            Param[7] = new SqlParameter("@sit_mal", SqlDbType.VarChar, 30);
            Param[7].Value = TXT_SITUATION.Text;

            Param[8] = new SqlParameter("@nat_mal", SqlDbType.VarChar, 25);
            Param[8].Value = TXT_NATIONALITE.Text;

            Param[9] = new SqlParameter("@l_n_mal", SqlDbType.VarChar, 30);
            Param[9].Value = TXT_LIEU.Text;

            Param[10] = new SqlParameter("@grps_s_mal", SqlDbType.VarChar, 20);
            Param[10].Value = TXT_SANGUIN.Text;

            Param[11] = new SqlParameter("@tel", SqlDbType.VarChar, 20);
            Param[11].Value = TXT_TEL.Text;

            Param[12] = new SqlParameter("@email", SqlDbType.VarChar, 20);
            Param[12].Value = TXT_EMAIL.Text;

            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" EDITED Succ ", "UpDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillDataGridView();






        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            TXT_COD.Text = dataGridView1.CurrentRow.Cells["cod_mal"].Value.ToString();

            TXT_NOM.Text = dataGridView1.CurrentRow.Cells["nom"].Value.ToString();

            TXT_ADRESS.Text = dataGridView1.CurrentRow.Cells["adrs"].Value.ToString();

            TXT_EMAIL.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

            TXT_LIEU.Text = dataGridView1.CurrentRow.Cells["l_n_mal"].Value.ToString();

            TXT_NATIONALITE.Text = dataGridView1.CurrentRow.Cells["nat_mal"].Value.ToString();

            TXT_PRENOM.Text = dataGridView1.CurrentRow.Cells["pré_mal"].Value.ToString();

            TXT_SANGUIN.Text = dataGridView1.CurrentRow.Cells["grps_s_mal"].Value.ToString();

            comboBox1.Text = dataGridView1.CurrentRow.Cells["sex"].Value.ToString();

            TXT_TEL.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();

            DATE.Text = dataGridView1.CurrentRow.Cells["d_n_mal"].Value.ToString();

            TXT_SITUATION.Text = dataGridView1.CurrentRow.Cells["sit_mal"].Value.ToString();

            TXT_PROF.Text = dataGridView1.CurrentRow.Cells["prof"].Value.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {



           

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Dt.Clear();


            Da = new SqlDataAdapter("SELECT * FROM malade  where convert (varchar ,cod_mal) + convert (varchar , nom )  + convert ( varchar , l_n_mal)  Like '%" + textBox1.Text + "%'   ", cn);

            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EdMalade_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Print_All_Click(object sender, EventArgs e)
        {

            All_report_EDmalade frm = new All_report_EDmalade();
            Da = new SqlDataAdapter("select * from malade where cod_mal=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet5.malade);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select_Report_Edmalade frm = new Select_Report_Edmalade();
            Da = new SqlDataAdapter("select * from malade where cod_mal=' " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.dossier_medical_alectroniqueDataSet5.malade);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TXT_TEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            TXT_COD.Text = null;

            TXT_NOM.Text = null;

            TXT_ADRESS.Text = null;

            TXT_EMAIL.Text = null;

            TXT_LIEU.Text = null;

            TXT_NATIONALITE.Text = null;

            TXT_PRENOM.Text = null;

            TXT_SANGUIN.Text = null;

            comboBox1.Text = null;

            TXT_TEL.Text = null;

            DATE.Text = null;

            TXT_SITUATION.Text = null;

            TXT_PROF.Text = null;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

    }
}
