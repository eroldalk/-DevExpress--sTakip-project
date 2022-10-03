using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_project.Entity;

namespace is_takip_project.Formlar
{
    public partial class frmGorevDetay : Form
    {
        public frmGorevDetay()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void frmGorevDetay_Load(object sender, EventArgs e)
        {
            db.TBLGorevDetaylar.Load();
            bindingSource1.DataSource = db.TBLGorevDetaylar.Local;


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();

        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
