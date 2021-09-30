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
    public partial class FrmHat : Form
    {

        public FrmHat()
        {
            InitializeComponent();
        }

        private void FrmHat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hullohatDataSet1.fajok' table. You can move, or remove it, as needed.
            // this.fajokTableAdapter.Fill(this.hullohatDataSet1.fajok);
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();


            //SqlCommand command = new SqlCommand($"SELECT nev FROM fajok", con);
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    listBox1.Items.Add(reader["nev"]);
            //}

            //reader.Close();

            updateList();
        }

        SqlConnection con;
        bool szinset = false;
        bool mintaset = false;
        string keresett_szin = "";
        string keresett_minta = "";

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList ()
        {
            listBox1.Items.Clear();

            string query = @"
                SELECT fajok.nev
                FROM fajok LEFT JOIN tulajdonsagok
                ON fajok.id = tulajdonsagok.fajid WHERE 1=1
            ";

            if (radioButton2.Checked)
            {
                    query += " AND tulajdonsagok.lab > 0";
            }
            if (radioButton1.Checked)
            {
                    query += " AND tulajdonsagok.lab < 1";
            }
            if (rdb_pislogi.Checked)
            {
                query += " AND tulajdonsagok.pislog > 0";
            }
            if (rdb_pislogn.Checked)
            {
                query += " AND tulajdonsagok.pislog < 1";
            }
            if (rdb_pupillk.Checked)
            {
                query += " AND tulajdonsagok.pupilla = 'kerek'";
            }
            if (rdb_pupillf.Checked)
            {
                query += " AND tulajdonsagok.pupilla = 'függoleges'";
            }
            if (szinset)
            {
                query += $" AND tulajdonsagok.szin = '{keresett_szin}'";
            }
            if (mintaset)
            {
                query += $" AND tulajdonsagok.minta = '{keresett_minta}'";
            }
            query += $" AND NOT ((tulajdonsagok.meret_min > {num_max.Value}) OR (tulajdonsagok.meret_max < {num_min.Value}))";
            //query += $" AND tulajdonsagok.meret_max <= {num_max.Value}";

            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["nev"]);
            }

            reader.Close();

        }

        private void rdb_pislogi_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void rdb_pupillk_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void cmb_szin_SelectedIndexChanged(object sender, EventArgs e)
        {
            szinset = true;
            keresett_szin = cmb_szin.SelectedItem.ToString();
            updateList();
        }

        private void cmb_minta_SelectedIndexChanged(object sender, EventArgs e)
        {
            mintaset = true;
            keresett_minta = cmb_minta.SelectedItem.ToString();
            updateList();
        }

        private void num_min_ValueChanged(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
