using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HulloHatarozo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnIsm_Click(object sender, EventArgs e)
        {
            FrmIsm frmIsm = new FrmIsm();
            frmIsm.ShowDialog();
        }

        private void btnHat_Click(object sender, EventArgs e)
        {
            FrmHat frmHat = new FrmHat();
            frmHat.ShowDialog();
        }

        private void btnJat_Click(object sender, EventArgs e)
        {
            FrmJat frmJat = new FrmJat();
            frmJat.ShowDialog();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            FrmMon frmMon = new FrmMon();
            frmMon.ShowDialog();
        }
    }
}
