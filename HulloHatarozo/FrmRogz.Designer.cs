﻿namespace HulloHatarozo
{
    partial class FrmRogz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRogz));
            this.txtb_jnev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_jnev
            // 
            this.txtb_jnev.Location = new System.Drawing.Point(113, 47);
            this.txtb_jnev.Name = "txtb_jnev";
            this.txtb_jnev.Size = new System.Drawing.Size(100, 20);
            this.txtb_jnev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Játékosnév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adj meg egy játékosnevet a rögzítéshez!";
            // 
            // btn_ment
            // 
            this.btn_ment.Location = new System.Drawing.Point(91, 85);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(75, 23);
            this.btn_ment.TabIndex = 3;
            this.btn_ment.Text = "Mentés";
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.btn_ment_Click);
            // 
            // FrmRogz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 120);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_jnev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRogz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eredmény rögzítés";
            this.Load += new System.EventHandler(this.FrmRogz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_jnev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ment;
    }
}