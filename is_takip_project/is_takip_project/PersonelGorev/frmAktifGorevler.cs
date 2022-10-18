using DevExpress.XtraEditors;
using is_takip_project.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_project.PersonelGorev
{
    public partial class frmAktifGorevler : Form
    {
        public frmAktifGorevler()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        public string mail2;
        private void frmAktifGorevler_Load(object sender, EventArgs e)
        {
            var personelid = db.TBLPersonel.Where(x=>x.Mail == mail2).Select(y => y.ID).FirstOrDefault();



            var degerler = (from x in db.TBLGorevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum

                            }).Where(x => x.GorevAlan == personelid && x.Durum == true).ToList();

            gridControl1.DataSource = degerler;

            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

            int say = gridView1.RowCount;
            if (say <= 0)
            {
                MessageBox.Show("Herhangi Bir Aktif Görev Bulunamadı", "BİLGİ", 0, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Toplam " + say.ToString() + " Adet Aktif Görev Bulundu", "BİLGİ", 0, MessageBoxIcon.Information);
            }



        }
    }
}
