using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace dossier_medical
{
    public partial class EXMENE : DevExpress.XtraEditors.XtraForm
    {


        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

        SqlCommand Cmd;


        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        DataTable YT = new DataTable();

        public EXMENE()
        {
            InitializeComponent();



            {
                Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);
                com_consu.DataSource = Dt;
                com_consu.DisplayMember = "num_consult";

            }



            fillDataGridView();

        }
        void fillDataGridView()
        {
            Dt.Clear();

            Cmd = new SqlCommand("selecall_General_exame", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);
            this.dataGridView1.DataSource = Dt;


        }
    }
}