using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmDepartmanlar frm = new Formlar.frmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnpersonellistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmpersoneller frm2 = new Formlar.frmpersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmpersonelleristatistik frm3 = new Formlar.frmpersonelleristatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }
        Formlar.frmGörevListesi frm4; 
        private void btnGörevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(frm4 == null || frm4.IsDisposed)
            {

                frm4 = new Formlar.frmGörevListesi();
                frm4.MdiParent = this;                                              //if yazılımı için
                frm4.Show();
            }


        }

        private void btngorevtanimlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmGorev frm5 = new Formlar.frmGorev();
            frm5.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmGorevDetay frm6 = new Formlar.frmGorevDetay();
            frm6.Show();
        }

        Formlar.frmAnaform frm7;
        private void BtnAnaform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {

                frm7 = new Formlar.frmAnaform();
                frm7.MdiParent = this;                                              //if yazılımı için
                frm7.Show();
            }
        }
        Formlar.frmAktifcagrılar frm8;
        private void BtnAktif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Formlar.frmAktifcagrılar frm8 = new Formlar.frmAktifcagrılar();
            if (frm8 == null || frm8.IsDisposed)
            {

                frm8 = new Formlar.frmAktifcagrılar();
                frm8.MdiParent = this;                                              //if yazılımı için
                frm8.Show();
            }
        }

        private void BtnPasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
