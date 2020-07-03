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
    public partial class LOGIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {



        public string UserType;

        public LOGIN()
        {
            InitializeComponent();

            var someVar = DateTime.Now;
            label2.Text = someVar.ToString("dd/MM/yyyy");
            //LBL_TIME.Text = DateTime.Now.ToShortTimeString();


            label1.Text = DateTime.Now.ToString("HH:mm:ss");


        }

        private void B_LOGIN_Click(object sender, EventArgs e)
        {




        }


        private void B_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source= BILAL-PC;Initial Catalog= dossier_medical_alectronique ;Integrated Security=true ");

            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM USERS WHERE ID='" + TEXT_USERNAME.Text + "' AND PASS='" + TEXT_PASSWORD.Text + "'" + " AND UserType=" + textBox1.Text + "", cn);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM USERS WHERE ID='" + TEXT_USERNAME.Text + "' AND PASS='" + TEXT_PASSWORD.Text + "'", cn);

            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows.Count>0)

                //if (dt.Rows[0][0].ToString() == "1")
            {


                //UserType = dt.Rows[0][2].ToString().Trim();

                if ( dt.Rows[0][2].ToString()==  "MANAGER")
                {

                    MENU frm = new MENU();
                    frm.ShowDialog();
                    this.Close();
                }
                else if (dt.Rows[0][2].ToString() == "USER")
                {
                  
                    USER_MENU frm = new USER_MENU ();
                    frm.ShowDialog();
                    this.Close();
                }

               

            }
            else
            MessageBox.Show(" password Or username Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void TEXT_USERNAME_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        }
    }
        
