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

        private void btnGörevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmGörevListesi frm4 = new Formlar.frmGörevListesi();
            frm4.MdiParent = this;
            frm4.Show();
        }

        //ADO.NET
        //metadata=res://*/Entity.Model1.csdl|res://*/Entity.Model1.ssdl|res:
        //    //*/Entity.Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=
        //             //.\SQLEXPRESS;initial catalog=DbisTakip;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"

    }
}
