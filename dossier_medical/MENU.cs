using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dossier_medical
{
    public partial class MENU : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static MENU frm;

        static void frm_frmclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }

        public static MENU getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new MENU();
                    frm.FormClosed += new FormClosedEventHandler(frm_frmclosed);

                }
                return frm;
            }
        }



        public MENU()
        {
            InitializeComponent();


            if (frm == null)
                frm = this;
            //this.addUsersToolStripMenuItem.Enabled = false;
            //this.eDITUSERSToolStripMenuItem.Enabled = false;



        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_dossier_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {
              foreach (Control ctl  in this.Controls)
                    
                        if (ctl.GetType() ==typeof(MdiClient))
                        {
                            ctl.BackColor = Color.SlateBlue;
                        }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

          


        }

        private void aCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analysesss FRM = new analysesss();
            FRM.ShowDialog();
        }

        private void kLEBNFLEBNLFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void jLFBELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kJEBFKJEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ENDOSCOPIE END = new ENDOSCOPIE();
            END.ShowDialog();
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bilanPréthérapeutiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilan bil = new bilan();
            bil.ShowDialog();
        }

        private void resultatConsultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultation consult = new consultation();
            consult.ShowDialog();

        }

        private void maladeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdMalade mal = new EdMalade();
            mal.ShowDialog();
        }

        private void gestionDesRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultation consult = new consultation();
            consult.ShowDialog();
        }

        private void diagnosticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIAGNOSTIC DIAG = new DIAGNOSTIC();
            DIAG.ShowDialog();

        }

        private void antecedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ANTECEDENT ANT = new ANTECEDENT();
            ANT.ShowDialog();

        }

        private void analyseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analysesss frm = new analysesss();

            frm.ShowDialog();

        }

        private void radioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          imagerie rad = new imagerie();
            rad.ShowDialog();

        }

        private void endoscopieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ENDOSCOPIE END = new ENDOSCOPIE();
            END.ShowDialog();

        }

        private void traitementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categorie__examen trait = new categorie__examen();
            trait.ShowDialog();

        }

        private void rendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RENDEZ_VOUS rvd = new RENDEZ_VOUS();
            rvd.ShowDialog();

        }

        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEDECIN MED = new MEDECIN();
            MED.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EVACUATION EVA = new EVACUATION();
            EVA.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void eDITUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN frm = new LOGIN ();
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void examenGeneraleToolStripMenuItem_Click(object sender, EventArgs e)
        {

     EXAMEN_GENERALE EXM = new EXAMEN_GENERALE() ;
            EXM.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            USERS frm = new USERS();
            frm.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit_users frm = new Edit_users();
            frm.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EdMalade mal = new EdMalade();
            mal.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            consultation consult = new consultation();
            consult.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ANTECEDENT ANT = new ANTECEDENT();
            ANT.ShowDialog();

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            analysesss anty = new analysesss();
            anty.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imagerie rad = new imagerie();
            rad.ShowDialog();

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ENDOSCOPIE END = new ENDOSCOPIE();
            END.ShowDialog();
        }

        private void bilanPréthérapeutiqueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EXAMEN_GENERALE EXM = new EXAMEN_GENERALE();
            EXM.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categorie__examen trait = new categorie__examen();
            trait.ShowDialog();

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EVACUATION EVA = new EVACUATION();
            EVA.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RENDEZ_VOUS rvd = new RENDEZ_VOUS();
            rvd.ShowDialog();

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            V_REPORT_1 RD = new V_REPORT_1();
            RD.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            REPORT_evacuation RD = new REPORT_evacuation();
            RD.ShowDialog();

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Backup RD = new Backup();
            RD.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Restory RD = new Restory();
            RD.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categorie__examen ctg = new categorie__examen();
            ctg.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
