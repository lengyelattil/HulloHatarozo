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
    public partial class FrmJat : Form
    {
        public FrmJat()
        {
            InitializeComponent();
        }

        private void btn_kov_Click(object sender, EventArgs e)
        {
            if (txtb_magy.Text == gnev)
            {
                pont++;
            }
            if (txtb_lat.Text == glatin)
            {
                pont++;
            }
            txtb_magy.Text = "";
            txtb_lat.Text = "";
            if (i<9)
            {
                i++;
                Kor_folyamat();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Elért pont: {pont}\n\n" +
                    "Szeretnéd menteni az eredményt?", "Játék vége!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    FrmRogz frmr = new FrmRogz();
                    frmr.ShowDialog();
                }
            }
        }

        SqlConnection con;
        Random rnd = new Random();
        HashSet<int> randomkepek = new HashSet<int>();
        int[] rndkepekt;
        int i = 0;
        string query;
        public static int pont = 0;
        string gnev = "";
        string glatin = "";

        private void FrmJat_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();
        }

        private void btn_indit_Click(object sender, EventArgs e)
        {
            btn_kov.Visible = true;
            btn_indit.Visible = false;
            Jatek_indit();
        }
        private void Jatek_indit()
        {
            randomkepek.Clear();
            while (randomkepek.Count < 10)
            {
                randomkepek.Add(rnd.Next(1, 40));
            }
            rndkepekt = randomkepek.ToArray();
            i = 0;
            pont = 0;
            lbl_szaml.Visible = true;
            Kor_folyamat();
        }
        private void Kor_folyamat()
        {
            string ikepeler = "";
            

            query = $@"
                SELECT kepek.kep, fajok.nev, fajok.latinnev
                FROM fajok RIGHT JOIN kepek
                ON fajok.id = kepek.fajid WHERE kepek.Id = {rndkepekt[i]}
            ";

            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
            while (reader.Read())
            {
                ikepeler = reader["kep"].ToString();
                gnev = reader["nev"].ToString();
                glatin = reader["latinnev"].ToString();
            }
            reader.Close();

            pctB_kep.Image = Image.FromFile($@"hullok\{ikepeler}");
            lbl_pont.Text = $"Eddig elért pontszám: {pont}";
            lbl_szaml.Text = $"Milyen állat van a képen? {i + 1}/10";
        }

        private void újJátékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jatek_indit();
        }

        private void hogyanKellJátszaniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A játék indítása után a program 10 képet fog mutatni.\nMinden egyes képnél le kell írni helyesen a faj magyar és latin nevét.\nMinden helyesen megadott név egy pontot ér, így maximum 20 pont szerezhető.\nA játék végén lehetőség van elmenteni az eredményünket egy játékosnév megadásával.\nA mentett eredmények visszanézhetők, illetve törölhető az eredmények tábla tartalma.", "Játékszabályok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eddigiEredményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPont pontt = new FrmPont();
            pontt.ShowDialog();
        }
    }
}
