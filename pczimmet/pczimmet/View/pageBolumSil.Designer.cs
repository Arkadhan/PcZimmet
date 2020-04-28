namespace pczimmet.View
{
    partial class pageBolumSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageBolumSil));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueBolumSil = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolumSil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(68, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bölüm Adı:";
            // 
            // lueBolumSil
            // 
            this.lueBolumSil.Location = new System.Drawing.Point(177, 153);
            this.lueBolumSil.Name = "lueBolumSil";
            this.lueBolumSil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueBolumSil.Properties.Appearance.Options.UseFont = true;
            this.lueBolumSil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBolumSil.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bolumAdi", "Seçiniz")});
            this.lueBolumSil.Properties.DisplayMember = "bolumAdi";
            this.lueBolumSil.Properties.NullText = "Seçiniz";
            this.lueBolumSil.Properties.ValueMember = "bolumID";
            this.lueBolumSil.Size = new System.Drawing.Size(302, 32);
            this.lueBolumSil.TabIndex = 1;
            // 
            // pageBolumSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lueBolumSil);
            this.Controls.Add(this.labelControl1);
            this.DoubleBuffered = true;
            this.Name = "pageBolumSil";
            this.Size = new System.Drawing.Size(513, 399);
            ((System.ComponentModel.ISupportInitialize)(this.lueBolumSil.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueBolumSil;
    }
}
