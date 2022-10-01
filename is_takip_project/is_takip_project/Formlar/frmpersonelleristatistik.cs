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
    public partial class frmpersonelleristatistik : Form
    {
        public frmpersonelleristatistik()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void frmpersonelleristatistik_Load(object sender, EventArgs e)
        {
            lbltoplamdepartman.Text = db.TBLdepartmanlar.Count().ToString();
            lblfirma.Text = db.TBLFirmalar.Count().ToString();
            lbltoplampersonel.Text = db.TBLPersonel.Count().ToString();
            lblaktifis.Text= db.TBLGorevler.Count(x => x.Durum == true).ToString();
            lblpasifis.Text = db.TBLGorevler.Count(x => x.Durum == false).ToString();
            lblsongorev.Text= db.TBLGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblissehir.Text = db.TBLFirmalar.Select(x => x.il).Distinct().Count().ToString();
            lblsektor.Text = db.TBLFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblbugungorev.Text = db.TBLGorevler.Count(x => x.Tarih == bugun).ToString();
            var d1 = db.TBLGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count())
                .Select(y => y.Key).FirstOrDefault();
            lblayinpersoneli.Text = db.TBLPersonel.Where( x => x.ID == d1).Select(y => y.Ad +" "+y.Soyad).FirstOrDefault().ToString();

            lblayindepart.Text = db.TBLdepartmanlar.Where( x => x.ID == db.TBLPersonel.Where
            (t=>t.ID==d1).Select(z=>z.Departman).FirstOrDefault()).Select(y => y.Ad ).FirstOrDefault().ToString();

            lblsonzaman.Text = db.TBLGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();







        }
    }
}
