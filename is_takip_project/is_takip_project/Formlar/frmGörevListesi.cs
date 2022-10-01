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
    public partial class frmGörevListesi : Form
    {
        public frmGörevListesi()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void frmGörevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in  db.TBLGorevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();


            lblaktifgorev.Text = db.TBLGorevler.Where(x => x.Durum == true).Count().ToString();
            lblpasifgorev.Text = db.TBLGorevler.Where(x => x.Durum == false).Count().ToString();
            lbltoplamdepart.Text = db.TBLdepartmanlar.Count().ToString();




            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblaktifgorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblpasifgorev.Text));





        }

       
    }
}
