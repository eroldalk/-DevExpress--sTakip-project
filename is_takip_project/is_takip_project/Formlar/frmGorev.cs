﻿using System;
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
    public partial class frmGorev : Form
    {
        public frmGorev()
        {
            InitializeComponent();
        }

        private void Btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbisTakipEntities db = new DbisTakipEntities();

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            TBLGorevler t = new TBLGorevler();
            t.Aciklama = txtAciklama.Text;
            t.Durum = true;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih=DateTime.Parse(TxtTarih.Text);
            t.Gorev_Veren = 1;
            db.TBLGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başırılı Olarak Tanımlandı", "Bilgi" ,
                MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void frmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TBLPersonel
                                select new
                                {
                                    x.ID,
                                    AdSoyad = x.Ad +" "+x.Soyad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;
        }
    }
}
