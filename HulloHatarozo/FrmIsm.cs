using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HulloHatarozo
{
    public partial class FrmIsm : Form
    {
        public FrmIsm()
        {
            InitializeComponent();
        }

        private void FrmIsm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();
        }

        SqlConnection con;
        string faj = "";

        private void updateText()
        {
            lbl_mag.Text = "Magyar név: ";
            txt_leiras.Text = "";
            lbl_lat.Text = "Tudományos név: ";
            lbl_ertek.Text = "Természetvédelmi érték: ";

            string query = @"
                SELECT leiras
                FROM fajok WHERE nev = 
            ";
            query += "'" + faj + "'";
            lbl_mag.Text += faj;

            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();

            while (reader.Read())
            {
                txt_leiras.Text = reader["leiras"].ToString();
            }
            //txt_leiras.Text = reader.ToString();

            reader.Close();

            query = @"
                SELECT fajok.latinnev, tulajdonsagok.eszmeiertek
                FROM fajok LEFT JOIN tulajdonsagok
                ON fajok.id = tulajdonsagok.fajid WHERE nev = 
            ";
            query += "'"+faj+"'";
            reader = new SqlCommand(query, con).ExecuteReader();
            while (reader.Read())
            {
                lbl_lat.Text += reader["latinnev"].ToString();
                lbl_ertek.Text += reader["eszmeiertek"].ToString() + " Ft";
            }
            reader.Close();

           /* query = @"
                SELECT fajok.nev
                FROM fajok LEFT JOIN tulajdonsagok
                ON fajok.id = tulajdonsagok.fajid WHERE 1=1
            ";*/

        }

        private void mocsáriTeknősToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Mocsári teknos";
            updateText();
        }

        private void vörösfülűÉkszerteknősToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Vörösfülu ékszerteknos";
            updateText();
        }

        private void zöldGyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Zöld gyík";
            updateText();
        }

        private void fürgeGyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Fürge gyík";
            updateText();
        }

        private void elevenszülőGyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Elevenszülo gyík";
            updateText();
        }

        private void faliGyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Fali gyík";
            updateText();
        }

        private void homokiGyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Homoki gyík";
            updateText();
        }

        private void pannongyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Pannongyík";
            updateText();
        }

        private void közönségesLábatlangyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Közönséges lábatlangyík";
            updateText();
        }

        private void kékpettyesLábatlangyíkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Kékpettyes lábatlangyík";
            updateText();
        }

        private void kaszpiHaragossiklóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Kaszpi haragossikló";
            updateText();
        }

        private void erdeiSiklóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Erdei sikló";
            updateText();
        }

        private void rézsiklóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Rézsikló";
            updateText();
        }

        private void vízisiklóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Vízisikló";
            updateText();
        }

        private void kockásSiklóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Kockás sikló";
            updateText();
        }

        private void keresztesViperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Keresztes vipera";
            updateText();
        }

        private void rákosiViperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faj = "Rákosi vipera";
            updateText();
        }
    }
}
