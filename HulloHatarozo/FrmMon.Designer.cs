namespace HulloHatarozo
{
    partial class FrmMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMon));
            this.txtb_hely = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rogzit = new System.Windows.Forms.Button();
            this.cmb_nev = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dTP_ido = new System.Windows.Forms.DateTimePicker();
            this.dtgv_eszlel = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_torol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_eszlel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_hely
            // 
            this.txtb_hely.Location = new System.Drawing.Point(7, 90);
            this.txtb_hely.Name = "txtb_hely";
            this.txtb_hely.Size = new System.Drawing.Size(100, 20);
            this.txtb_hely.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Az észlelt faj neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Az észlelés helyszíne:";
            // 
            // btn_rogzit
            // 
            this.btn_rogzit.Location = new System.Drawing.Point(16, 185);
            this.btn_rogzit.Name = "btn_rogzit";
            this.btn_rogzit.Size = new System.Drawing.Size(75, 23);
            this.btn_rogzit.TabIndex = 4;
            this.btn_rogzit.Text = "Rögzítés";
            this.btn_rogzit.UseVisualStyleBackColor = true;
            this.btn_rogzit.Click += new System.EventHandler(this.btn_rogzit_Click);
            // 
            // cmb_nev
            // 
            this.cmb_nev.FormattingEnabled = true;
            this.cmb_nev.Items.AddRange(new object[] {
            "Zöld gyík",
            "Fürge gyík",
            "Homoki gyík",
            "Elevenszülő gyík",
            "Fali gyík",
            "Pannongyík",
            "Közönséges lábatlangyík",
            "Kékpettyes lábatlangyík",
            "Keresztes vipera",
            "Rákosi vipera",
            "Kaszpi haragossikló",
            "Erdei sikló",
            "Vízisikló",
            "Kockás sikló",
            "Rézsikló",
            "Mocsári teknős",
            "Vörösfülű ékszerteknős"});
            this.cmb_nev.Location = new System.Drawing.Point(7, 36);
            this.cmb_nev.Name = "cmb_nev";
            this.cmb_nev.Size = new System.Drawing.Size(121, 21);
            this.cmb_nev.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Az észlelés ideje:";
            // 
            // dTP_ido
            // 
            this.dTP_ido.Location = new System.Drawing.Point(7, 143);
            this.dTP_ido.Name = "dTP_ido";
            this.dTP_ido.Size = new System.Drawing.Size(200, 20);
            this.dTP_ido.TabIndex = 10;
            // 
            // dtgv_eszlel
            // 
            this.dtgv_eszlel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_eszlel.Location = new System.Drawing.Point(253, 25);
            this.dtgv_eszlel.Name = "dtgv_eszlel";
            this.dtgv_eszlel.Size = new System.Drawing.Size(386, 228);
            this.dtgv_eszlel.TabIndex = 11;
            this.dtgv_eszlel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_eszlel_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eddigi észelések:";
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(357, 259);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(175, 23);
            this.btn_torol.TabIndex = 13;
            this.btn_torol.Text = "A kijelölt észelés törlése";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // FrmMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 311);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgv_eszlel);
            this.Controls.Add(this.dTP_ido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_nev);
            this.Controls.Add(this.btn_rogzit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_hely);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMon";
            this.Text = "Hüllő Határozó V0.1 - Észlelés";
            this.Load += new System.EventHandler(this.FrmMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_eszlel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtb_hely;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rogzit;
        private System.Windows.Forms.ComboBox cmb_nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTP_ido;
        private System.Windows.Forms.DataGridView dtgv_eszlel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_torol;
    }
}