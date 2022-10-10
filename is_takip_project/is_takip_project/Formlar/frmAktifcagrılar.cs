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
    public partial class frmAktifcagrılar : Form
    {
        public frmAktifcagrılar()
        {
            InitializeComponent();
        }

        private void frmAktifcagrılar_Load(object sender, EventArgs e)
        {

            DbisTakipEntities db = new DbisTakipEntities();

            var degerler = (from x in db.TBLCagrilar
                            select new
                            {
                                x.ID,
                                x.TBLFirmalar.Ad,
                                x.TBLFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                x.Durum
                            }
                            ).Where(y => y.Durum == true).ToList();


            gridControl1.DataSource = degerler;
        }

       
    }
}
