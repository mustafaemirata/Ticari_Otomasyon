namespace Ticari_Otomasyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridAlan = new DevExpress.XtraGrid.GridControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtExtra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.rtNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.su = new DevExpress.XtraEditors.TextEdit();
            this.elektrik = new DevExpress.XtraEditors.TextEdit();
            this.internet = new DevExpress.XtraEditors.TextEdit();
            this.txtMaas = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.su.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridAlan;
            this.gridView1.Name = "gridView1";
            // 
            // gridAlan
            // 
            this.gridAlan.Location = new System.Drawing.Point(1, 1);
            this.gridAlan.MainView = this.gridView1;
            this.gridAlan.Name = "gridAlan";
            this.gridAlan.Size = new System.Drawing.Size(1558, 658);
            this.gridAlan.TabIndex = 7;
            this.gridAlan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(2, 540);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(327, 29);
            this.simpleButton2.TabIndex = 29;
            this.simpleButton2.Text = "Kaydet";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaas);
            this.groupControl1.Controls.Add(this.internet);
            this.groupControl1.Controls.Add(this.elektrik);
            this.groupControl1.Controls.Add(this.su);
            this.groupControl1.Controls.Add(this.cmbYil);
            this.groupControl1.Controls.Add(this.cmbAy);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtExtra);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.temizleBtn);
            this.groupControl1.Controls.Add(this.rtNotlar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.dogalgaz);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1582, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 658);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Müşteri Kayıt Oluştur";
            // 
            // cmbAy
            // 
            this.cmbAy.Location = new System.Drawing.Point(138, 70);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Properties.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.cmbAy.Size = new System.Drawing.Size(125, 22);
            this.cmbAy.TabIndex = 30;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(40, 339);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 22);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "Notlar";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(139, 296);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExtra.Properties.Appearance.Options.UseFont = true;
            this.txtExtra.Size = new System.Drawing.Size(125, 28);
            this.txtExtra.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(87, 299);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 22);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Extra:";
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.Location = new System.Drawing.Point(2, 569);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(327, 29);
            this.guncelleBtn.TabIndex = 20;
            this.guncelleBtn.Text = "Güncelle";
            // 
            // silBtn
            // 
            this.silBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.Location = new System.Drawing.Point(2, 598);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(327, 29);
            this.silBtn.TabIndex = 19;
            this.silBtn.Text = "Sil";
            // 
            // temizleBtn
            // 
            this.temizleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.Location = new System.Drawing.Point(2, 627);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(327, 29);
            this.temizleBtn.TabIndex = 18;
            this.temizleBtn.Text = "Temizle";
            // 
            // rtNotlar
            // 
            this.rtNotlar.Location = new System.Drawing.Point(93, 339);
            this.rtNotlar.Name = "rtNotlar";
            this.rtNotlar.Size = new System.Drawing.Size(210, 157);
            this.rtNotlar.TabIndex = 17;
            this.rtNotlar.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(92, 265);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 22);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Maaş:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(70, 228);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 22);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İnternet:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(61, 200);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 22);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Doğalgaz:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(104, 167);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 22);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Su:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(70, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 22);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Elektrik:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(115, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 22);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Yıl:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(113, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ay:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 31);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(125, 28);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // cmbYil
            // 
            this.cmbYil.Location = new System.Drawing.Point(138, 104);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYil.Properties.Items.AddRange(new object[] {
            "2025",
            "2026"});
            this.cmbYil.Size = new System.Drawing.Size(125, 22);
            this.cmbYil.TabIndex = 31;
            // 
            // dogalgaz
            // 
            this.dogalgaz.Location = new System.Drawing.Point(139, 197);
            this.dogalgaz.Name = "dogalgaz";
            this.dogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogalgaz.Properties.Appearance.Options.UseFont = true;
            this.dogalgaz.Size = new System.Drawing.Size(125, 28);
            this.dogalgaz.TabIndex = 13;
            // 
            // su
            // 
            this.su.Location = new System.Drawing.Point(139, 167);
            this.su.Name = "su";
            this.su.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.su.Properties.Appearance.Options.UseFont = true;
            this.su.Size = new System.Drawing.Size(125, 28);
            this.su.TabIndex = 32;
            // 
            // elektrik
            // 
            this.elektrik.Location = new System.Drawing.Point(139, 133);
            this.elektrik.Name = "elektrik";
            this.elektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elektrik.Properties.Appearance.Options.UseFont = true;
            this.elektrik.Size = new System.Drawing.Size(125, 28);
            this.elektrik.TabIndex = 33;
            // 
            // internet
            // 
            this.internet.Location = new System.Drawing.Point(139, 228);
            this.internet.Name = "internet";
            this.internet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.internet.Properties.Appearance.Options.UseFont = true;
            this.internet.Size = new System.Drawing.Size(125, 28);
            this.internet.TabIndex = 34;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(139, 262);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Properties.Appearance.Options.UseFont = true;
            this.txtMaas.Size = new System.Drawing.Size(125, 28);
            this.txtMaas.TabIndex = 35;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.gridAlan);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmGiderler";
            this.Text = "Giderler";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.su.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridAlan;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtExtra;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private System.Windows.Forms.RichTextBox rtNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
        private DevExpress.XtraEditors.TextEdit txtMaas;
        private DevExpress.XtraEditors.TextEdit internet;
        private DevExpress.XtraEditors.TextEdit elektrik;
        private DevExpress.XtraEditors.TextEdit su;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYil;
        private DevExpress.XtraEditors.TextEdit dogalgaz;
    }
}