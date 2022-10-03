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
                                          adsoyad= x.TBLPersonel.Ad +" "+ x.TBLPersonel.Soyad
                                           
                                       }).ToList();


        }
    }
}
