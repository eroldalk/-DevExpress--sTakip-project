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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }
        //crud  -->creat read update delete

        DbisTakipEntities db = new DbisTakipEntities();

        void listele()
        {

           
            var degerler = (from x in db.TBLdepartmanlar
                           select new
                           {
                               x.ID,
                               x.Ad
                           }).ToList();
            gridControl1.DataSource = degerler;
        }


        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLdepartmanlar t = new TBLdepartmanlar();
            t.Ad = txtad.Text;
            db.TBLdepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi", "Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtıd.Text);
            var deger=db.TBLdepartmanlar.Find(x);
            db.TBLdepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
