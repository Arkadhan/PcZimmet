namespace pczimmet.View
{
    partial class pageKullaniciSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageKullaniciSil));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueKullaniciSil = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcSifre = new DevExpress.XtraEditors.LabelControl();
            this.txteSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txteYetki = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txteBolum = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKullaniciSil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteYetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteBolum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(12, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // lueKullaniciSil
            // 
            this.lueKullaniciSil.Location = new System.Drawing.Point(170, 59);
            this.lueKullaniciSil.Name = "lueKullaniciSil";
            this.lueKullaniciSil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueKullaniciSil.Properties.Appearance.Options.UseFont = true;
            this.lueKullaniciSil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKullaniciSil.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("kullaniciAdi", "Seçiniz")});
            this.lueKullaniciSil.Properties.DisplayMember = "kullaniciAdi";
            this.lueKullaniciSil.Properties.NullText = "Seçiniz";
            this.lueKullaniciSil.Properties.ValueMember = "kullaniciID";
            this.lueKullaniciSil.Size = new System.Drawing.Size(245, 32);
            this.lueKullaniciSil.TabIndex = 2;
            this.lueKullaniciSil.EditValueChanged += new System.EventHandler(this.lueKullaniciSil_EditValueChanged);
            this.lueKullaniciSil.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lueKullaniciSil_EditValueChanging);
            // 
            // lblcSifre
            // 
            this.lblcSifre.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcSifre.Location = new System.Drawing.Point(12, 108);
            this.lblcSifre.Name = "lblcSifre";
            this.lblcSifre.Size = new System.Drawing.Size(141, 25);
            this.lblcSifre.TabIndex = 3;
            this.lblcSifre.Text = "Kullanıcı Şifresi";
            // 
            // txteSifre
            // 
            this.txteSifre.Enabled = false;
            this.txteSifre.Location = new System.Drawing.Point(170, 103);
            this.txteSifre.Name = "txteSifre";
            this.txteSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteSifre.Properties.Appearance.Options.UseFont = true;
            this.txteSifre.Properties.PasswordChar = '*';
            this.txteSifre.Properties.ReadOnly = true;
            this.txteSifre.Size = new System.Drawing.Size(245, 32);
            this.txteSifre.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(12, 152);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Yetkisi";
            // 
            // txteYetki
            // 
            this.txteYetki.Enabled = false;
            this.txteYetki.Location = new System.Drawing.Point(170, 149);
            this.txteYetki.Name = "txteYetki";
            this.txteYetki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteYetki.Properties.Appearance.Options.UseFont = true;
            this.txteYetki.Properties.ReadOnly = true;
            this.txteYetki.Size = new System.Drawing.Size(245, 32);
            this.txteYetki.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Location = new System.Drawing.Point(12, 195);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 25);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Bölümü";
            // 
            // txteBolum
            // 
            this.txteBolum.Enabled = false;
            this.txteBolum.Location = new System.Drawing.Point(170, 192);
            this.txteBolum.Name = "txteBolum";
            this.txteBolum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteBolum.Properties.Appearance.Options.UseFont = true;
            this.txteBolum.Properties.ReadOnly = true;
            this.txteBolum.Size = new System.Drawing.Size(245, 32);
            this.txteBolum.TabIndex = 8;
            // 
            // pageKullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txteBolum);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txteYetki);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txteSifre);
            this.Controls.Add(this.lblcSifre);
            this.Controls.Add(this.lueKullaniciSil);
            this.Controls.Add(this.labelControl1);
            this.Name = "pageKullaniciSil";
            this.Size = new System.Drawing.Size(607, 502);
            ((System.ComponentModel.ISupportInitialize)(this.lueKullaniciSil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteYetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteBolum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueKullaniciSil;
        private DevExpress.XtraEditors.LabelControl lblcSifre;
        private DevExpress.XtraEditors.TextEdit txteSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txteYetki;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txteBolum;
    }
}
