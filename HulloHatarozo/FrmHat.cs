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
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();
            updateList();
        }

        SqlConnection con;
        bool szinset = false;
        bool mintaset = false;
        string keresett_szin = "";
        string keresett_minta = "";

        HashSet<string> fajlista = new HashSet<string>();

        private void updateList ()
        {
            listBox1.Items.Clear();

            string query = @"
                SELECT fajok.nev
                FROM fajok LEFT JOIN tulajdonsagok
                ON fajok.id = tulajdonsagok.fajid WHERE 1=1
            ";

            if (rdb_labv.Checked)
            {
                    query += " AND tulajdonsagok.lab > 0";
            }
            if (rdb_labn.Checked)
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

            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();

            while (reader.Read())
            {
                //listBox1.Items.Add(reader["nev"]);
                fajlista.Add(reader["nev"].ToString());
            }
            

            reader.Close();
            foreach (var faj in fajlista)
            {
                listBox1.Items.Add(faj);
            }
            fajlista.Clear();
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
        private void minmax_joe(object sender, EventArgs e)
        {
            if (num_min.Value<num_max.Value)
            {
                updateList();
            }
            else
            {
                MessageBox.Show("A megadott minimum érték kisebb kell legyen a maximumnál!","Hibás értékek!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                num_min.Value = 10;
                num_max.Value = 200;
            }
        }

        private void talalat_szukites(object sender, EventArgs e)
        {
            updateList();
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            szinset = false;
            mintaset = false;
            cmb_szin.Text = "";
            cmb_minta.Text = "";
            num_min.Value = 10;
            num_max.Value = 200;
            rdb_labv.Checked = false;
            rdb_labn.Checked = false;
            rdb_pislogi.Checked = false;
            rdb_pislogn.Checked = false;
            rdb_pupillf.Checked = false;
            rdb_pupillk.Checked = false;
            updateList();
        }
    }
}
