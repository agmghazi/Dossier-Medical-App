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
    public partial class Edit_users : DevExpress.XtraBars.Ribbon.RibbonForm
    {



        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();




        public Edit_users()
        {
            InitializeComponent();

            fillDataGridView();

        }
        void fillDataGridView()
        {

            Dt.Clear();

            Cmd = new SqlCommand("selectall_users", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cmd = new SqlCommand("update_users", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] Param = new SqlParameter[3];
                Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                Param[0].Value = TXT_User.Text;

                Param[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 30);
                Param[1].Value = TXT_Pass.Text;

                Param[2] = new SqlParameter("@UserType", SqlDbType.VarChar, 30);
                Param[2].Value = cmbType.Text;




                Cmd.Parameters.AddRange(Param);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" update Succ ", "UpDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillDataGridView();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXT_User.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            TXT_Pass.Text = dataGridView1.CurrentRow.Cells["PASS"].Value.ToString();

            cmbType.Text = dataGridView1.CurrentRow.Cells["UserType"].Value.ToString();
        }

        private void BT_DELET_Click(object sender, EventArgs e)
        {
            try{

            DialogResult dialog = MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Cmd = new SqlCommand("delete_usrts", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Param = new SqlParameter();
                Param = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                Param.Value = TXT_User.Text;
                Cmd.Parameters.Add(Param);
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(" Delet Succ ", "DELET", MessageBoxButtons.OK, MessageBoxIcon.Question);

                fillDataGridView();

            }
            }
                catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void Edit_users_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.SteelBlue;
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Dt.Clear();

            Da = new SqlDataAdapter("select * from USERS where ID +PASS+ UserType    Like '%" + textBox1.Text + "%'", cn);

            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();

        }
    }
}
