namespace pczimmet.View
{
    partial class pageAtikPcGir
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collsil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.collAtikAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repluePersonel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.replueParca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repluePersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueParca)).BeginInit();
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
            this.repositoryItemSpinEdit1,
            this.ribeSil});
            this.gridControl1.Size = new System.Drawing.Size(620, 332);
            this.gridControl1.TabIndex = 2;
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
            this.colParca,
            this.colAdet,
            this.collsil,
            this.collAtikAdet});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            // 
            // colParca
            // 
            this.colParca.Caption = "Parça Adı";
            this.colParca.FieldName = "satinalmaParcaAdi";
            this.colParca.Name = "colParca";
            this.colParca.OptionsColumn.AllowEdit = false;
            this.colParca.OptionsColumn.ReadOnly = true;
            this.colParca.Visible = true;
            this.colParca.VisibleIndex = 0;
            // 
            // colAdet
            // 
            this.colAdet.Caption = "Mevcut Parça Adedi";
            this.colAdet.FieldName = "satinalmaAdet";
            this.colAdet.Name = "colAdet";
            this.colAdet.OptionsColumn.AllowEdit = false;
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 1;
            // 
            // collsil
            // 
            this.collsil.Caption = "Atığa Gönder";
            this.collsil.ColumnEdit = this.ribeSil;
            this.collsil.FieldName = "satinalmaID";
            this.collsil.Name = "collsil";
            this.collsil.OptionsEditForm.Caption = "Zimmet Sil";
            this.collsil.Visible = true;
            this.collsil.VisibleIndex = 3;
            // 
            // ribeSil
            // 
            this.ribeSil.AutoHeight = false;
            this.ribeSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Sil", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.ribeSil.Name = "ribeSil";
            this.ribeSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeSil.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeSil_ButtonClick);
            // 
            // collAtikAdet
            // 
            this.collAtikAdet.Caption = "Atık Adedi";
            this.collAtikAdet.ColumnEdit = this.repositoryItemSpinEdit1;
            this.collAtikAdet.FieldName = "atikadet";
            this.collAtikAdet.Name = "collAtikAdet";
            this.collAtikAdet.Visible = true;
            this.collAtikAdet.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
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
            this.repluePersonel.ValueMember = "personelID";
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
            this.replueParca.ValueMember = "satinalmaID";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 332);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(620, 100);
            this.panelControl1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(313, 42);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(221, 53);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Son İşlemi Geri Al";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pageAtikPcGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "pageAtikPcGir";
            this.Size = new System.Drawing.Size(620, 432);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repluePersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueParca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colParca;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replueParca;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn collsil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repluePersonel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn collAtikAdet;
    }
}
