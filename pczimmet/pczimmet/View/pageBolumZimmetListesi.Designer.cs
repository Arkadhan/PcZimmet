﻿namespace pczimmet.View
{
    partial class pageBolumZimmetListesi
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueBolum = new DevExpress.XtraEditors.LookUpEdit();
            this.sbtnYazdir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repluePersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueParca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repluePersonel,
            this.replueParca,
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(610, 347);
            this.gridControl1.TabIndex = 1;
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
            this.gridView1.OptionsBehavior.Editable = false;
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
            this.panelControl1.Controls.Add(this.sbtnYazdir);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lueBolum);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(610, 100);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(53, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Bölümü Seç";
            // 
            // lueBolum
            // 
            this.lueBolum.Location = new System.Drawing.Point(170, 40);
            this.lueBolum.Name = "lueBolum";
            this.lueBolum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueBolum.Properties.Appearance.Options.UseFont = true;
            this.lueBolum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBolum.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bolumAdi", "Bölümler")});
            this.lueBolum.Properties.DisplayMember = "bolumAdi";
            this.lueBolum.Properties.NullText = "Şeçiniz...";
            this.lueBolum.Properties.ValueMember = "bolumID";
            this.lueBolum.Size = new System.Drawing.Size(205, 32);
            this.lueBolum.TabIndex = 0;
            this.lueBolum.EditValueChanged += new System.EventHandler(this.lueBolum_EditValueChanged);
            // 
            // sbtnYazdir
            // 
            this.sbtnYazdir.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnYazdir.Appearance.Options.UseFont = true;
            this.sbtnYazdir.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnYazdir.Location = new System.Drawing.Point(502, 2);
            this.sbtnYazdir.Name = "sbtnYazdir";
            this.sbtnYazdir.Size = new System.Drawing.Size(106, 96);
            this.sbtnYazdir.TabIndex = 2;
            this.sbtnYazdir.Text = "Yazdir";
            this.sbtnYazdir.Click += new System.EventHandler(this.sbtnYazdir_Click);
            // 
            // pageBolumZimmetListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "pageBolumZimmetListesi";
            this.Size = new System.Drawing.Size(610, 447);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repluePersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueParca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolum.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueBolum;
        private DevExpress.XtraEditors.SimpleButton sbtnYazdir;
    }
}
