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
    public partial class EDMALADE_ADD : Form
    {



        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        //SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public EDMALADE_ADD()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("EDITDATA", cn);
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
            MessageBox.Show(" Added Succ ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
