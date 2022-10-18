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

namespace is_takip_project.Formlar
{
    public partial class frmCagrıAtama : Form
    {
        public frmCagrıAtama()
        {
            InitializeComponent();
        }
        public int id;
        DbisTakipEntities db = new DbisTakipEntities();
        private void frmCagrıAtama_Load(object sender, EventArgs e)
        {
            //lookupedit için verilerin listelenmesi
            var degerler = (from x in db.TBLPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;


            txtcagriid.Text =id.ToString();
            var gelenveri=db.TBLCagrilar.Find(id);
            txtAciklama.Text =gelenveri.Aciklama;
            TxtTarih.Text =gelenveri.Tarih.ToString();
            txtkonu.Text = gelenveri.Konu;
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TBLCagrilar.Find(id);
            gelenveri.Konu= txtkonu.Text;
            gelenveri.Tarih=Convert.ToDateTime(TxtTarih.Text);
            gelenveri.Aciklama = txtAciklama.Text;
            gelenveri.CagriPersonel=int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başırılı Olarak Tanımlandı", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
