namespace is_takip_project.Formlar
{
    partial class frmpersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpersoneller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtgorsel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btngüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtıd = new DevExpress.XtraEditors.TextEdit();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgorsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtıd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(-199, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1180, 556);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtgorsel);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtmail);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtsoyad);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.btngüncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnekle);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtıd);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(978, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 556);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(152, 205);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(223, 22);
            this.lookUpEdit1.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(56, 205);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Departman :";
            // 
            // txtgorsel
            // 
            this.txtgorsel.Location = new System.Drawing.Point(153, 167);
            this.txtgorsel.Margin = new System.Windows.Forms.Padding(5);
            this.txtgorsel.Name = "txtgorsel";
            this.txtgorsel.Size = new System.Drawing.Size(223, 22);
            this.txtgorsel.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(83, 179);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Görsel :";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(153, 135);
            this.txtmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(223, 22);
            this.txtmail.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 141);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Mail :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(153, 103);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(5);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(223, 22);
            this.txtsoyad.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(81, 106);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Soyadı :";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Appearance.Options.UseFont = true;
            this.btngüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngüncelle.ImageOptions.Image")));
            this.btngüncelle.Location = new System.Drawing.Point(151, 404);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(223, 33);
            this.btngüncelle.TabIndex = 7;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(149, 356);
            this.btnsil.Margin = new System.Windows.Forms.Padding(5);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(223, 38);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Appearance.Options.UseFont = true;
            this.btnekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnekle.ImageOptions.Image")));
            this.btnekle.Location = new System.Drawing.Point(151, 307);
            this.btnekle.Margin = new System.Windows.Forms.Padding(5);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(223, 39);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(153, 71);
            this.txtad.Margin = new System.Windows.Forms.Padding(5);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(223, 22);
            this.txtad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(101, 77);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Adı :";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(153, 39);
            this.txtıd.Margin = new System.Windows.Forms.Padding(5);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(223, 22);
            this.txtıd.TabIndex = 2;
            // 
            // btnlistele
            // 
            this.btnlistele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Appearance.Options.UseFont = true;
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(152, 262);
            this.btnlistele.Margin = new System.Windows.Forms.Padding(5);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(223, 35);
            this.btnlistele.TabIndex = 1;
            this.btnlistele.Text = "Listele";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID :";
            // 
            // frmpersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 553);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmpersoneller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.frmpersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgorsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtıd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btngüncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtıd;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtgorsel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtsoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}