namespace HulloHatarozo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnIsm = new System.Windows.Forms.Button();
            this.btnHat = new System.Windows.Forms.Button();
            this.btnJat = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.ttIsm = new System.Windows.Forms.ToolTip(this.components);
            this.ttHat = new System.Windows.Forms.ToolTip(this.components);
            this.ttJat = new System.Windows.Forms.ToolTip(this.components);
            this.ttMon = new System.Windows.Forms.ToolTip(this.components);
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIsm
            // 
            this.btnIsm.Location = new System.Drawing.Point(12, 30);
            this.btnIsm.Name = "btnIsm";
            this.btnIsm.Size = new System.Drawing.Size(100, 35);
            this.btnIsm.TabIndex = 0;
            this.btnIsm.Text = "Faj ismertető";
            this.ttIsm.SetToolTip(this.btnIsm, "Itt megismerheted a hazai fajokat");
            this.btnIsm.UseVisualStyleBackColor = true;
            this.btnIsm.Click += new System.EventHandler(this.btnIsm_Click);
            // 
            // btnHat
            // 
            this.btnHat.Location = new System.Drawing.Point(12, 94);
            this.btnHat.Name = "btnHat";
            this.btnHat.Size = new System.Drawing.Size(100, 35);
            this.btnHat.TabIndex = 1;
            this.btnHat.Text = "Határozó";
            this.ttHat.SetToolTip(this.btnHat, "Segít a fajok beazonosításában");
            this.btnHat.UseVisualStyleBackColor = true;
            this.btnHat.Click += new System.EventHandler(this.btnHat_Click);
            // 
            // btnJat
            // 
            this.btnJat.Location = new System.Drawing.Point(12, 156);
            this.btnJat.Name = "btnJat";
            this.btnJat.Size = new System.Drawing.Size(100, 35);
            this.btnJat.TabIndex = 2;
            this.btnJat.Text = "Felismerő játék";
            this.ttJat.SetToolTip(this.btnJat, "Játszva gyakorolhatod a fajok felismerését");
            this.btnJat.UseVisualStyleBackColor = true;
            this.btnJat.Click += new System.EventHandler(this.btnJat_Click);
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(12, 216);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(100, 35);
            this.btnMon.TabIndex = 3;
            this.btnMon.Text = "Észlelés";
            this.ttMon.SetToolTip(this.btnMon, "Bejegyezheted, hogy hol történt az észlelés");
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtb1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb1.Location = new System.Drawing.Point(301, 265);
            this.txtb1.Name = "txtb1";
            this.txtb1.ReadOnly = true;
            this.txtb1.Size = new System.Drawing.Size(182, 20);
            this.txtb1.TabIndex = 4;
            this.txtb1.Text = "Készítette: Lengyel Attila Zsolt; 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(495, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.btnMon);
            this.Controls.Add(this.btnJat);
            this.Controls.Add(this.btnHat);
            this.Controls.Add(this.btnIsm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hüllő Határozó V0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsm;
        private System.Windows.Forms.Button btnHat;
        private System.Windows.Forms.Button btnJat;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.ToolTip ttIsm;
        private System.Windows.Forms.ToolTip ttHat;
        private System.Windows.Forms.ToolTip ttJat;
        private System.Windows.Forms.ToolTip ttMon;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

