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

namespace is_takip_project.Login
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorev.frmpersonel fr = new
                PersonelGorev.frmpersonel();
            fr.Show();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void txtkullanıcı_Click(object sender, EventArgs e)
        {
            panel3.BackColor=Color.Red;
            panel4.BackColor=Color.PaleTurquoise;

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.PaleTurquoise;
            panel4.BackColor = Color.Red;
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void btnadmin_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TBLAdmin.Where(x => x.Kullanici == txtkullanici.Text &&
                x.Sifre == txtsifre.Text).FirstOrDefault();
            if(adminvalue != null)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {     
               XtraMessageBox.Show("Hatalı Giriş");
            }
        }

       

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        
        
        
        
        
        private void btnpersonel_Click(object sender, EventArgs e)
        {
            var personel = db.TBLPersonel.Where(x => x.Mail == txtkullanici.Text &&
              x.Sifre == txtsifre.Text).FirstOrDefault();
            if (personel != null)
            {
                PersonelGorev.frmpersonel fr 
                    = new PersonelGorev.frmpersonel();
                fr.mail= txtkullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
