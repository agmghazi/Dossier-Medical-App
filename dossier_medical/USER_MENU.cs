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
    public partial class USER_MENU : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public USER_MENU()
        {
            InitializeComponent();
        }

        private void USER_MENU_Load(object sender, EventArgs e)
        {

            foreach (Control ctl in this.Controls)

                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.BlanchedAlmond;
                }
        }

        private void maladeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void antecedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void analyseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void endoscopieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void examenGeneraleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void traitementToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EVACUATION ev = new EVACUATION();
            ev.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EdMalade MLI = new EdMalade();
            MLI.ShowDialog();

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            consultation cons = new consultation();
            cons.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ANTECEDENT antd = new ANTECEDENT();
            antd.ShowDialog(); 
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            analysesss anly = new analysesss();
            anly.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            imagerie img = new imagerie();
            img.ShowDialog(); 
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ENDOSCOPIE end = new ENDOSCOPIE();
            end.ShowDialog();
        }

        private void bilanPréthérapeutiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            EXAMEN_GENERALE EXEM = new EXAMEN_GENERALE();
            EXEM.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            categorie__examen ctg = new categorie__examen();
            ctg.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            EVACUATION ev = new EVACUATION();
            ev.ShowDialog();
        }

        private void ordonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ficheDevacuationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RENDEZ_VOUS RD = new RENDEZ_VOUS();
            RD.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
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
    }
}
