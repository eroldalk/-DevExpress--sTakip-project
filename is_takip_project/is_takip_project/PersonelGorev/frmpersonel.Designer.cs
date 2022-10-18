namespace is_takip_project.PersonelGorev
{
    partial class frmpersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpersonel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.Btnaktifgorev = new DevExpress.XtraBars.BarButtonItem();
            this.Btnpasifgorev = new DevExpress.XtraBars.BarButtonItem();
            this.Btncagrılistesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barCheckItem1,
            this.Btnaktifgorev,
            this.Btnpasifgorev,
            this.Btncagrılistesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1232, 176);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // Btnaktifgorev
            // 
            this.Btnaktifgorev.Caption = "Aktif Görevler";
            this.Btnaktifgorev.Id = 2;
            this.Btnaktifgorev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnaktifgorev.ImageOptions.Image")));
            this.Btnaktifgorev.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btnaktifgorev.ImageOptions.LargeImage")));
            this.Btnaktifgorev.Name = "Btnaktifgorev";
            this.Btnaktifgorev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnaktifgorev_ItemClick);
            // 
            // Btnpasifgorev
            // 
            this.Btnpasifgorev.Caption = "Pasif Görevler";
            this.Btnpasifgorev.Id = 3;
            this.Btnpasifgorev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnpasifgorev.ImageOptions.Image")));
            this.Btnpasifgorev.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btnpasifgorev.ImageOptions.LargeImage")));
            this.Btnpasifgorev.Name = "Btnpasifgorev";
            this.Btnpasifgorev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btnpasifgorev_ItemClick);
            // 
            // Btncagrılistesi
            // 
            this.Btncagrılistesi.Caption = "Çağrı Listesi";
            this.Btncagrılistesi.Id = 4;
            this.Btncagrılistesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btncagrılistesi.ImageOptions.Image")));
            this.Btncagrılistesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btncagrılistesi.ImageOptions.LargeImage")));
            this.Btncagrılistesi.Name = "Btncagrılistesi";
            this.Btncagrılistesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btncagrılistesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Personel Görev";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btnaktifgorev);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btnpasifgorev);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btncagrılistesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmpersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmpersonel";
            this.Load += new System.EventHandler(this.frmpersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem Btnaktifgorev;
        private DevExpress.XtraBars.BarButtonItem Btnpasifgorev;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem Btncagrılistesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}