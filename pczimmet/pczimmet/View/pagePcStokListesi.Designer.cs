namespace pczimmet.View
{
    partial class pagePcStokListesi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collsapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collsapTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnYazdir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(572, 291);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collsapAdi,
            this.collsapTarihi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // collsapAdi
            // 
            this.collsapAdi.Caption = "Parça Adı";
            this.collsapAdi.FieldName = "satinalmaParcaAdi";
            this.collsapAdi.Name = "collsapAdi";
            this.collsapAdi.Visible = true;
            this.collsapAdi.VisibleIndex = 0;
            // 
            // collsapTarihi
            // 
            this.collsapTarihi.Caption = "Satın Alma Tarihi";
            this.collsapTarihi.FieldName = "satinalmaTarihi";
            this.collsapTarihi.Name = "collsapTarihi";
            this.collsapTarihi.Visible = true;
            this.collsapTarihi.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtnYazdir);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 291);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(572, 100);
            this.panelControl1.TabIndex = 1;
            // 
            // sbtnYazdir
            // 
            this.sbtnYazdir.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnYazdir.Appearance.Options.UseFont = true;
            this.sbtnYazdir.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnYazdir.Location = new System.Drawing.Point(464, 2);
            this.sbtnYazdir.Name = "sbtnYazdir";
            this.sbtnYazdir.Size = new System.Drawing.Size(106, 96);
            this.sbtnYazdir.TabIndex = 0;
            this.sbtnYazdir.Text = "Yazdir";
            this.sbtnYazdir.Click += new System.EventHandler(this.sbtnYazdir_Click);
            // 
            // pagePcStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "pagePcStokListesi";
            this.Size = new System.Drawing.Size(572, 391);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn collsapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn collsapTarihi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnYazdir;
    }
}
