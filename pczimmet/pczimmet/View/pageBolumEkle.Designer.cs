namespace pczimmet.View
{
    partial class pageBolumEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageBolumEkle));
            this.txtBolumekle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolumekle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBolumekle
            // 
            this.txtBolumekle.Location = new System.Drawing.Point(199, 142);
            this.txtBolumekle.Name = "txtBolumekle";
            this.txtBolumekle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumekle.Properties.Appearance.Options.UseFont = true;
            this.txtBolumekle.Size = new System.Drawing.Size(252, 32);
            this.txtBolumekle.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(83, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Bölüm Adı";
            // 
            // pageBolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBolumekle);
            this.DoubleBuffered = true;
            this.Name = "pageBolumEkle";
            this.Size = new System.Drawing.Size(735, 465);
            ((System.ComponentModel.ISupportInitialize)(this.txtBolumekle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBolumekle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
