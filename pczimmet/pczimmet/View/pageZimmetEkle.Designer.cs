namespace pczimmet.View
{
    partial class pageZimmetEkle
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
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repluePersonel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colParca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.replueParca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnOnay = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repluePersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueParca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
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
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repluePersonel,
            this.replueParca,
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(636, 371);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPersonel,
            this.colParca,
            this.colAdet});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPersonel
            // 
            this.colPersonel.Caption = "Personel Adı";
            this.colPersonel.ColumnEdit = this.repluePersonel;
            this.colPersonel.FieldName = "personelID";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.Visible = true;
            this.colPersonel.VisibleIndex = 0;
            // 
            // repluePersonel
            // 
            this.repluePersonel.AutoHeight = false;
            this.repluePersonel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repluePersonel.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("personelAdi", "Personel Adı")});
            this.repluePersonel.DisplayMember = "personelAdi";
            this.repluePersonel.Name = "repluePersonel";
            this.repluePersonel.NullText = "Şeçiniz...";
            this.repluePersonel.ValueMember = "personelID";
            // 
            // colParca
            // 
            this.colParca.Caption = "Parça Adı";
            this.colParca.ColumnEdit = this.replueParca;
            this.colParca.FieldName = "satinalmaID";
            this.colParca.Name = "colParca";
            this.colParca.Visible = true;
            this.colParca.VisibleIndex = 1;
            // 
            // replueParca
            // 
            this.replueParca.AutoHeight = false;
            this.replueParca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replueParca.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("satinalmaParcaAdi", "Parça Adı")});
            this.replueParca.DisplayMember = "satinalmaParcaAdi";
            this.replueParca.Name = "replueParca";
            this.replueParca.NullText = "Şeçiniz...";
            this.replueParca.ValueMember = "satinalmaID";
            // 
            // colAdet
            // 
            this.colAdet.Caption = "Parça Adedi";
            this.colAdet.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colAdet.FieldName = "zimmetAdet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.NullText = "Şeçiniz...";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtnOnay);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 371);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(636, 100);
            this.panelControl1.TabIndex = 4;
            // 
            // sbtnOnay
            // 
            this.sbtnOnay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnOnay.Location = new System.Drawing.Point(470, 25);
            this.sbtnOnay.Name = "sbtnOnay";
            this.sbtnOnay.Size = new System.Drawing.Size(123, 37);
            this.sbtnOnay.TabIndex = 0;
            this.sbtnOnay.Text = "Onayla";
            this.sbtnOnay.Click += new System.EventHandler(this.sbtnOnay_Click);
            // 
            // pageZimmetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "pageZimmetEkle";
            this.Size = new System.Drawing.Size(636, 471);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repluePersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueParca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repluePersonel;
        private DevExpress.XtraGrid.Columns.GridColumn colParca;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replueParca;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnOnay;
    }
}
