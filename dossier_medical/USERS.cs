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
    public partial class USERS : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;
        //SqlDataAdapter Da;
        DataTable Dt = new DataTable();


        public USERS()
        {
            InitializeComponent();
        }

        private void txtPWDConfirm_Validated(object sender, EventArgs e)
        {
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("PASSWORD NOT CONFIRME", "EROE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("ADD_USERS", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = txtID.Text;

            Param[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 50);
            Param[1].Value = txtPWD.Text;

            Param[2] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            Param[2].Value = cmbType.Text;

            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" Added Succ ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
