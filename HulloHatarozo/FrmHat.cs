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
                ON fajok.id = tulajdonsagok.fajid
            ";

            if (radioButton2.Checked)
            {
                query += " WHERE tulajdonsagok.lab > 0";
            }
            if (radioButton1.Checked)
            {
                query += " WHERE tulajdonsagok.lab < 1";
            }

            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["nev"]);
            }

            reader.Close();

        }
    }
}
