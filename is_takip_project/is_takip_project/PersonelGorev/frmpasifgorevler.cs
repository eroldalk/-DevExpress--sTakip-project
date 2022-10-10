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
    public partial class frmpasifgorevler : Form
    {
        public frmpasifgorevler()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void frmpasifgorevler_Load(object sender, EventArgs e)
        {

            var degerler = (from x in db.TBLGorevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum

                            }).Where(x => x.GorevAlan == 7 && x.Durum == false).ToList();

            gridControl1.DataSource = degerler;

            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

            int say = gridView1.RowCount;
            if (say <= 0)
            {
                MessageBox.Show("Herhangi Bir Pasif Görev Bulunamadı", "BİLGİ", 0, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Toplam " + say.ToString() + " Adet pasif Görev Bulundu", "BİLGİ", 0, MessageBoxIcon.Information);
            }

        }
    }
}
