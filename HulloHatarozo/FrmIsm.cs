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

        private void updateText()
        {

            string query = @"
                SELECT leiras
                FROM fajok WHERE nev = 'Zöld gyík'
            ";

            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();

            while (reader.Read())
            {
                txt_leiras.Text = reader["leiras"].ToString();
            }
            //txt_leiras.Text = reader.ToString();

            reader.Close();

        }

        private void mocsáriTeknősToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateText();
        }

        private void FrmIsm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hullohatDataSet1.fajok' table. You can move, or remove it, as needed.
            this.fajokTableAdapter.Fill(this.hullohatDataSet1.fajok);

        }
    }
}
