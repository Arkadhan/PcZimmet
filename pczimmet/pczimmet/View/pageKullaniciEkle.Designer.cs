namespace pczimmet.View
{
    partial class pageKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageKullaniciEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueBolumAdi = new DevExpress.XtraEditors.LookUpEdit();
            this.icbeKullYetki = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolumAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeKullYetki.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(123, 124);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // txtKullAdi
            // 
            this.txtKullAdi.Location = new System.Drawing.Point(284, 121);
            this.txtKullAdi.Name = "txtKullAdi";
            this.txtKullAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullAdi.Size = new System.Drawing.Size(243, 32);
            this.txtKullAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(173, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(223, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kullanıcı Ekleme Sayfası";
            // 
            // txtKullSifre
            // 
            this.txtKullSifre.Location = new System.Drawing.Point(284, 161);
            this.txtKullSifre.Name = "txtKullSifre";
            this.txtKullSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullSifre.Properties.Appearance.Options.UseFont = true;
            this.txtKullSifre.Properties.PasswordChar = '*';
            this.txtKullSifre.Size = new System.Drawing.Size(243, 32);
            this.txtKullSifre.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Location = new System.Drawing.Point(123, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(141, 25);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Kullanıcı Şifresi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Location = new System.Drawing.Point(123, 202);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(143, 25);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Kullanıcı Yetkisi";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Location = new System.Drawing.Point(123, 240);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 25);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Bölüm Adı";
            // 
            // lueBolumAdi
            // 
            this.lueBolumAdi.Location = new System.Drawing.Point(284, 237);
            this.lueBolumAdi.Name = "lueBolumAdi";
            this.lueBolumAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueBolumAdi.Properties.Appearance.Options.UseFont = true;
            this.lueBolumAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBolumAdi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bolumAdi", "Seçiniz")});
            this.lueBolumAdi.Properties.DisplayMember = "bolumAdi";
            this.lueBolumAdi.Properties.NullText = "Seçiniz...";
            this.lueBolumAdi.Properties.ValueMember = "bolumID";
            this.lueBolumAdi.Size = new System.Drawing.Size(243, 32);
            this.lueBolumAdi.TabIndex = 9;
            // 
            // icbeKullYetki
            // 
            this.icbeKullYetki.Location = new System.Drawing.Point(284, 199);
            this.icbeKullYetki.Name = "icbeKullYetki";
            this.icbeKullYetki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.icbeKullYetki.Properties.Appearance.Options.UseFont = true;
            this.icbeKullYetki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbeKullYetki.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Admin", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Birim Yetkilisi", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Standart Kullanıcı", 2, -1)});
            this.icbeKullYetki.Size = new System.Drawing.Size(243, 32);
            this.icbeKullYetki.TabIndex = 10;
            // 
            // pageKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.icbeKullYetki);
            this.Controls.Add(this.lueBolumAdi);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtKullSifre);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtKullAdi);
            this.Controls.Add(this.labelControl1);
            this.DoubleBuffered = true;
            this.Name = "pageKullaniciEkle";
            this.Size = new System.Drawing.Size(563, 510);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolumAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeKullYetki.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullSifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lueBolumAdi;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbeKullYetki;
    }
}
