namespace HulloHatarozo
{
    partial class FrmJat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJat));
            this.lbl_szaml = new System.Windows.Forms.Label();
            this.pctB_kep = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_magy = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.játékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újJátékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eddigiEredményekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hogyanKellJátszaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb_lat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kov = new System.Windows.Forms.Button();
            this.btn_indit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctB_kep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_szaml
            // 
            this.lbl_szaml.AutoSize = true;
            this.lbl_szaml.Location = new System.Drawing.Point(12, 24);
            this.lbl_szaml.Name = "lbl_szaml";
            this.lbl_szaml.Size = new System.Drawing.Size(128, 13);
            this.lbl_szaml.TabIndex = 0;
            this.lbl_szaml.Text = "Milyen állat van a képen?";
            this.lbl_szaml.Visible = false;
            // 
            // pctB_kep
            // 
            this.pctB_kep.Location = new System.Drawing.Point(72, 40);
            this.pctB_kep.Name = "pctB_kep";
            this.pctB_kep.Size = new System.Drawing.Size(584, 287);
            this.pctB_kep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctB_kep.TabIndex = 1;
            this.pctB_kep.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Magyar név:";
            // 
            // txtb_magy
            // 
            this.txtb_magy.Location = new System.Drawing.Point(78, 19);
            this.txtb_magy.Name = "txtb_magy";
            this.txtb_magy.Size = new System.Drawing.Size(158, 20);
            this.txtb_magy.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.játékToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // játékToolStripMenuItem
            // 
            this.játékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újJátékToolStripMenuItem,
            this.eddigiEredményekToolStripMenuItem});
            this.játékToolStripMenuItem.Name = "játékToolStripMenuItem";
            this.játékToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.játékToolStripMenuItem.Text = "Játék";
            // 
            // újJátékToolStripMenuItem
            // 
            this.újJátékToolStripMenuItem.Name = "újJátékToolStripMenuItem";
            this.újJátékToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újJátékToolStripMenuItem.Text = "Új játék";
            this.újJátékToolStripMenuItem.Click += new System.EventHandler(this.újJátékToolStripMenuItem_Click);
            // 
            // eddigiEredményekToolStripMenuItem
            // 
            this.eddigiEredményekToolStripMenuItem.Name = "eddigiEredményekToolStripMenuItem";
            this.eddigiEredményekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eddigiEredményekToolStripMenuItem.Text = "Eddigi eredmények";
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hogyanKellJátszaniToolStripMenuItem});
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // hogyanKellJátszaniToolStripMenuItem
            // 
            this.hogyanKellJátszaniToolStripMenuItem.Name = "hogyanKellJátszaniToolStripMenuItem";
            this.hogyanKellJátszaniToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hogyanKellJátszaniToolStripMenuItem.Text = "Hogyan kell játszani?";
            this.hogyanKellJátszaniToolStripMenuItem.Click += new System.EventHandler(this.hogyanKellJátszaniToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb_lat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtb_magy);
            this.groupBox1.Location = new System.Drawing.Point(72, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válaszod:";
            // 
            // txtb_lat
            // 
            this.txtb_lat.Location = new System.Drawing.Point(335, 19);
            this.txtb_lat.Name = "txtb_lat";
            this.txtb_lat.Size = new System.Drawing.Size(158, 20);
            this.txtb_lat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tudományos név:";
            // 
            // btn_kov
            // 
            this.btn_kov.Location = new System.Drawing.Point(604, 376);
            this.btn_kov.Name = "btn_kov";
            this.btn_kov.Size = new System.Drawing.Size(75, 23);
            this.btn_kov.TabIndex = 6;
            this.btn_kov.Text = "Következő";
            this.btn_kov.UseVisualStyleBackColor = true;
            this.btn_kov.Visible = false;
            this.btn_kov.Click += new System.EventHandler(this.btn_kov_Click);
            // 
            // btn_indit
            // 
            this.btn_indit.Location = new System.Drawing.Point(282, 136);
            this.btn_indit.Name = "btn_indit";
            this.btn_indit.Size = new System.Drawing.Size(180, 88);
            this.btn_indit.TabIndex = 7;
            this.btn_indit.Text = "Játék indítása";
            this.btn_indit.UseVisualStyleBackColor = true;
            this.btn_indit.Click += new System.EventHandler(this.btn_indit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // FrmJat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_indit);
            this.Controls.Add(this.btn_kov);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctB_kep);
            this.Controls.Add(this.lbl_szaml);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmJat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hüllő Határozó V0.1 - Játék";
            this.Load += new System.EventHandler(this.FrmJat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctB_kep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_szaml;
        private System.Windows.Forms.PictureBox pctB_kep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_magy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem játékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újJátékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eddigiEredményekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hogyanKellJátszaniToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb_lat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kov;
        private System.Windows.Forms.Button btn_indit;
        private System.Windows.Forms.Label label1;
    }
}