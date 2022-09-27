using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_project.Entity;

namespace is_takip_project.Formlar
{
    public partial class frmpersoneller : Form
    {
        public frmpersoneller()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        void personeller()
        {
            var degerler = from x in db.TBLPersonel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               x.Departman

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void frmpersoneller_Load(object sender, EventArgs e)
        {
            personeller();

            var departmanlar = (from x in db.TBLdepartmanlar select new
            {
                x.ID,
                x.Ad
            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            personeller();
        }
         private void btnekle_Click(object sender, EventArgs e)
        {
            TBLPersonel t= new TBLPersonel();
            t.Ad =txtad.Text;
            t.Soyad =txtsoyad.Text;
            t.Mail =txtmail.Text;
            t.Gorsel =txtgorsel.Text;
            t.Departman=int.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel kaydı başırılı bir şekilde gerçekleşti", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            personeller();
        }





















        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
