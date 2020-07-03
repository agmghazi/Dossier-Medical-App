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
    public partial class DOSSIER : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

       
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        DataTable yt = new DataTable();



        public DOSSIER()
        {
            InitializeComponent();



            {
                Da = new SqlDataAdapter("Select * from consultation ", cn);
                Da.Fill(Dt);
                com_codemalade.DataSource = Dt;
                com_codemalade.DisplayMember = "cod_mal";
                com_codemalade.ValueMember = "num_consult";
            }

        }

        private void com_codemalade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                yt.Clear();
                Da = new SqlDataAdapter("SELECT * FROM consultation WHERE num_consult ='" + com_codemalade.SelectedValue + "'", cn);
                Da.Fill(yt);
                dataGridView1.DataSource = yt;

            }
            catch
            {
                return;
            }
        }
    }
}
