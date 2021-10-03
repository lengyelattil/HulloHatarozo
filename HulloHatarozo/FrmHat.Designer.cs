namespace HulloHatarozo
{
    partial class FrmHat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_labv = new System.Windows.Forms.RadioButton();
            this.rdb_labn = new System.Windows.Forms.RadioButton();
            this.cmb_szin = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_pislogn = new System.Windows.Forms.RadioButton();
            this.rdb_pislogi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb_pupillf = new System.Windows.Forms.RadioButton();
            this.rdb_pupillk = new System.Windows.Forms.RadioButton();
            this.hullohatDataSet1 = new HulloHatarozo.hullohatDataSet1();
            this.fajokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fajokTableAdapter = new HulloHatarozo.hullohatDataSet1TableAdapters.fajokTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmb_minta = new System.Windows.Forms.ComboBox();
            this.num_max = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hullohatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fajokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szín";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Becsült méret (cm):";
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(110, 58);
            this.num_min.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_min.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(120, 20);
            this.num_min.TabIndex = 4;
            this.num_min.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_min.ValueChanged += new System.EventHandler(this.minmax_joe);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_labv);
            this.groupBox1.Controls.Add(this.rdb_labn);
            this.groupBox1.Location = new System.Drawing.Point(30, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Van lába?";
            // 
            // rdb_labv
            // 
            this.rdb_labv.AutoSize = true;
            this.rdb_labv.Location = new System.Drawing.Point(8, 43);
            this.rdb_labv.Name = "rdb_labv";
            this.rdb_labv.Size = new System.Drawing.Size(44, 17);
            this.rdb_labv.TabIndex = 1;
            this.rdb_labv.TabStop = true;
            this.rdb_labv.Text = "Van";
            this.rdb_labv.UseVisualStyleBackColor = true;
            this.rdb_labv.CheckedChanged += new System.EventHandler(this.talalat_szukites);
            // 
            // rdb_labn
            // 
            this.rdb_labn.AutoSize = true;
            this.rdb_labn.Location = new System.Drawing.Point(99, 43);
            this.rdb_labn.Name = "rdb_labn";
            this.rdb_labn.Size = new System.Drawing.Size(52, 17);
            this.rdb_labn.TabIndex = 0;
            this.rdb_labn.TabStop = true;
            this.rdb_labn.Text = "Nincs";
            this.rdb_labn.UseVisualStyleBackColor = true;
            this.rdb_labn.CheckedChanged += new System.EventHandler(this.talalat_szukites);
            // 
            // cmb_szin
            // 
            this.cmb_szin.FormattingEnabled = true;
            this.cmb_szin.Items.AddRange(new object[] {
            "Zöld",
            "Barna",
            "Szürke",
            "Bronz",
            "Ezüst",
            "Fekete"});
            this.cmb_szin.Location = new System.Drawing.Point(51, 26);
            this.cmb_szin.Name = "cmb_szin";
            this.cmb_szin.Size = new System.Drawing.Size(121, 21);
            this.cmb_szin.TabIndex = 6;
            this.cmb_szin.SelectedIndexChanged += new System.EventHandler(this.cmb_szin_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_pislogn);
            this.groupBox2.Controls.Add(this.rdb_pislogi);
            this.groupBox2.Location = new System.Drawing.Point(28, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pislog-e?";
            // 
            // rdb_pislogn
            // 
            this.rdb_pislogn.AutoSize = true;
            this.rdb_pislogn.Location = new System.Drawing.Point(88, 41);
            this.rdb_pislogn.Name = "rdb_pislogn";
            this.rdb_pislogn.Size = new System.Drawing.Size(47, 17);
            this.rdb_pislogn.TabIndex = 1;
            this.rdb_pislogn.TabStop = true;
            this.rdb_pislogn.Text = "Nem";
            this.rdb_pislogn.UseVisualStyleBackColor = true;
            this.rdb_pislogn.CheckedChanged += new System.EventHandler(this.talalat_szukites);
            // 
            // rdb_pislogi
            // 
            this.rdb_pislogi.AutoSize = true;
            this.rdb_pislogi.Location = new System.Drawing.Point(17, 41);
            this.rdb_pislogi.Name = "rdb_pislogi";
            this.rdb_pislogi.Size = new System.Drawing.Size(46, 17);
            this.rdb_pislogi.TabIndex = 0;
            this.rdb_pislogi.TabStop = true;
            this.rdb_pislogi.Text = "Igen";
            this.rdb_pislogi.UseVisualStyleBackColor = true;
            this.rdb_pislogi.CheckedChanged += new System.EventHandler(this.talalat_szukites);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lehetséges fajok:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(29, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 243);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Szemek";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdb_pupillf);
            this.groupBox4.Controls.Add(this.rdb_pupillk);
            this.groupBox4.Location = new System.Drawing.Point(28, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pupilla állása";
            // 
            // rdb_pupillf
            // 
            this.rdb_pupillf.AutoSize = true;
            this.rdb_pupillf.Location = new System.Drawing.Point(88, 41);
            this.rdb_pupillf.Name = "rdb_pupillf";
            this.rdb_pupillf.Size = new System.Drawing.Size(80, 17);
            this.rdb_pupillf.TabIndex = 1;
            this.rdb_pupillf.TabStop = true;
            this.rdb_pupillf.Text = "Függőleges";
            this.rdb_pupillf.UseVisualStyleBackColor = true;
            this.rdb_pupillf.CheckedChanged += new System.EventHandler(this.talalat_szukites);
            // 
            // rdb_pupillk
            // 
            this.rdb_pupillk.AutoSize = true;
            this.rdb_pupillk.Location = new System.Drawing.Point(17, 41);
            this.rdb_pupillk.Name = "rdb_pupillk";
            this.rdb_pupillk.Size = new System.Drawing.Size(53, 17);
            this.rdb_pupillk.TabIndex = 0;
            this.rdb_pupillk.TabStop = true;
            this.rdb_pupillk.Text = "Kerek";
            this.rdb_pupillk.UseVisualStyleBackColor = true;
            this.rdb_pupillk.CheckedChanged += new System.EventHandler(this.talalat_szukites);
            // 
            // hullohatDataSet1
            // 
            this.hullohatDataSet1.DataSetName = "hullohatDataSet1";
            this.hullohatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fajokBindingSource
            // 
            this.fajokBindingSource.DataMember = "fajok";
            this.fajokBindingSource.DataSource = this.hullohatDataSet1;
            // 
            // fajokTableAdapter
            // 
            this.fajokTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(433, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 355);
            this.listBox1.TabIndex = 11;
            // 
            // cmb_minta
            // 
            this.cmb_minta.FormattingEnabled = true;
            this.cmb_minta.Items.AddRange(new object[] {
            "Nincs",
            "Mintázott",
            "Csíkos",
            "Kék pettyek",
            "Cikcakkos sáv",
            "Fekete pontsor",
            "Foltos",
            "Világos pettyek",
            "Világos csíkok"});
            this.cmb_minta.Location = new System.Drawing.Point(236, 26);
            this.cmb_minta.Name = "cmb_minta";
            this.cmb_minta.Size = new System.Drawing.Size(121, 21);
            this.cmb_minta.TabIndex = 12;
            this.cmb_minta.SelectedIndexChanged += new System.EventHandler(this.cmb_minta_SelectedIndexChanged);
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(258, 58);
            this.num_max.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_max.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_max.Name = "num_max";
            this.num_max.Size = new System.Drawing.Size(120, 20);
            this.num_max.TabIndex = 13;
            this.num_max.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_max.ValueChanged += new System.EventHandler(this.minmax_joe);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mintázat";
            // 
            // btn_clearall
            // 
            this.btn_clearall.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_clearall.Location = new System.Drawing.Point(473, 12);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(219, 35);
            this.btn_clearall.TabIndex = 15;
            this.btn_clearall.Text = "Minden alaphelyzetbe";
            this.btn_clearall.UseVisualStyleBackColor = false;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "-től";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "-ig";
            // 
            // FrmHat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clearall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_max);
            this.Controls.Add(this.cmb_minta);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_szin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hüllő Határozó V0.1 - Határozó";
            this.Load += new System.EventHandler(this.FrmHat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hullohatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fajokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_labv;
        private System.Windows.Forms.RadioButton rdb_labn;
        private System.Windows.Forms.ComboBox cmb_szin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_pislogn;
        private System.Windows.Forms.RadioButton rdb_pislogi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb_pupillf;
        private System.Windows.Forms.RadioButton rdb_pupillk;
        private hullohatDataSet1 hullohatDataSet1;
        private System.Windows.Forms.BindingSource fajokBindingSource;
        private hullohatDataSet1TableAdapters.fajokTableAdapter fajokTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmb_minta;
        private System.Windows.Forms.NumericUpDown num_max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}