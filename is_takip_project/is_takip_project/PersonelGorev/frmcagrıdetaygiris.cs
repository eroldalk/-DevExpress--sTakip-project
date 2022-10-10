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
    public partial class frmcagrıdetaygiris : Form
    {
        public frmcagrıdetaygiris()
        {
            InitializeComponent();
        }
                DbisTakipEntities db = new DbisTakipEntities();
        public int id;
        private void Btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcagrıdetaygiris_Load(object sender, EventArgs e)
        {
           // TxtCagriID.Enabled = false;
          //  TxtCagriID.Text = id.ToString();
            txtıd.Enabled = false;
            txtıd.Text = id.ToString();
            string saat, tarih;
            tarih=DateTime.Now.ToShortDateString();
            saat=DateTime.Now.ToShortTimeString();
            TxtTarih.Text=tarih;
            txtsaat.Text=saat;



        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            TBLCagriDetay t = new TBLCagriDetay();
            t.Cagri = int.Parse(txtıd.Text);
            t.Saat = txtsaat.Text;
            t.Tarih= DateTime.Parse(TxtTarih.Text);
            t.Aciklama=txtAciklama.Text;
            db.TBLCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı sisteme başarılı olarak kaydedildi");
        }
    }
}
