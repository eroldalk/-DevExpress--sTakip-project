using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_project.Entity;

namespace is_takip_project.Formlar
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void frmAnaform_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource = (from x in db.TBLGorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Personel= x.TBLPersonel.Ad +" "+ x.TBLPersonel.Soyad,
                                           x.Durum
                                       }).Where(y=>y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;

            //Bugün yapılan görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.TBLGorevDetaylar
                                       select new
                                       {
                                          Görev = x.TBLGorevler.Aciklama,
                                          x.Aciklama,
                                          x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();


            //Aktif çağrı listesi

            gridControl3.DataSource = (from x in db.TBLCagrilar
                                       select new
                                       {
                                           x.TBLFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;


            //Fihrist Cmds
            gridControl4.DataSource

        }
    }
}
