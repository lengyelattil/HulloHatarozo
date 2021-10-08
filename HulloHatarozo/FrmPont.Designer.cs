namespace HulloHatarozo
{
    partial class FrmPont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPont));
            this.dtgv_pont = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pont)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_pont
            // 
            this.dtgv_pont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_pont.Location = new System.Drawing.Point(12, 12);
            this.dtgv_pont.Name = "dtgv_pont";
            this.dtgv_pont.ReadOnly = true;
            this.dtgv_pont.Size = new System.Drawing.Size(386, 228);
            this.dtgv_pont.TabIndex = 12;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(417, 117);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 23);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Ponttábla ürítése";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // FrmPont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 269);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.dtgv_pont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hüllő Határozó V1.0 - Ponttábla";
            this.Load += new System.EventHandler(this.FrmPont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_pont;
        private System.Windows.Forms.Button btn_reset;
    }
}