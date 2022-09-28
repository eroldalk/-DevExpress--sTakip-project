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
    public partial class frmpersonelleristatistik : Form
    {
        public frmpersonelleristatistik()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void frmpersonelleristatistik_Load(object sender, EventArgs e)
        {
            lbltoplamdepartman.Text = db.TBLdepartmanlar.Count().ToString();
            lblfirma.Text = db.TBLFirmalar.Count().ToString();
            lbltoplampersonel.Text = db.TBLPersonel.Count().ToString();
        }
    }
}
