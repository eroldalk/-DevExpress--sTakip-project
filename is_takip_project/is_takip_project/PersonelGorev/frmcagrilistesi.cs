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
    public partial class frmcagrilistesi : Form
    {
        public frmcagrilistesi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        public string mail2;
        private void frmGorevlistesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TBLCagrilar
                                     select new
                                     {
                                         x.ID,
                                         x.TBLFirmalar.Ad,
                                         x.TBLFirmalar.Telefon,
                                         x.TBLFirmalar.Mail,
                                         x.Aciklama,
                                         x.CagriPersonel,
                                         x.Durum
                                     }).Where(y=>y.Durum == true &&
                                     y.CagriPersonel==personelid).ToList();
            
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersonel"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmcagrıdetaygiris fr = new frmcagrıdetaygiris();
            fr.id=int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
