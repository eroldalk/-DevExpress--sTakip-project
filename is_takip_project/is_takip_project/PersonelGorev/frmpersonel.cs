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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }
        public string mail;
        private void Btnaktifgorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorev.frmAktifGorevler  frm = new PersonelGorev.frmAktifGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void Btnpasifgorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorev.frmpasifgorevler frm = new PersonelGorev.frmpasifgorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void Btncagrılistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorev.frmcagrilistesi frm = new PersonelGorev.frmcagrilistesi();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void frmpersonel_Load(object sender, EventArgs e)
        {
            this.Text = "Personel"+" : "+mail.ToString();
        }
    }
}
