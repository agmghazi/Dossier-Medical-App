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
    public partial class bilan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;




        public bilan()
        {
            InitializeComponent();

            SqlDataAdapter Da;
            DataTable Dt = new DataTable();
            {
                Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);
                Com_Consuu.DataSource = Dt;
                Com_Consuu.DisplayMember = "num_consult";



                

            }
            SqlDataAdapter Rb;
            DataTable bt = new DataTable();
            {
                Rb = new SqlDataAdapter("Select * from with_pretreatment ", cn);
                Rb.Fill(bt);
                Comb_Bilan.DataSource = bt;
                Comb_Bilan.DisplayMember = "num_bilan";
                COM_nun_bilan.DataSource = bt;
                COM_nun_bilan.DisplayMember = "num_bilan";
            }

             SqlDataAdapter tb;
            DataTable tt = new DataTable();
            {
                tb = new SqlDataAdapter("Select * from with_pretreatment ", cn);
                Rb.Fill(tt);
                Comb_nobi.DataSource = tt;
                Comb_nobi.DisplayMember = "nom_bilan";
                
            }



         
            }
            

        private void bilan_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddata_With_pretreatment", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@num_bilan", SqlDbType.Int);
            Param[0].Value = Comb_Bilan.Text;

            Param[1] = new SqlParameter("@nom_bilan", SqlDbType.VarChar,30);
            Param[1].Value = Comb_nobi.Text;

            Param[2] = new SqlParameter("@num_consult", SqlDbType.Int);
            Param[2].Value = Com_Consuu.Text;


           

            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show(" add succ ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("adddata_resultat_bilan", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@id_bilan", SqlDbType.Int);
            Param[0].Value = ID_Bilan.Text;

            Param[1] = new SqlParameter("@nom_bilan", SqlDbType.VarChar,30);
            Param[1].Value = TXT_NOm.Text;

            Param[2] = new SqlParameter("@result_bilan", SqlDbType.VarChar, 50);
            Param[2].Value = TXT_RESULT.Text;
            

            Param[3] = new SqlParameter("@num_bilan", SqlDbType.Int);
            Param[3].Value = COM_nun_bilan.Text;

          

            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" add sec  ", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Com_Consuu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Comb_nobi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
