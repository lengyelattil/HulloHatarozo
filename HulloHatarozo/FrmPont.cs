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
    public partial class FrmPont : Form
    {
        public FrmPont()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void FrmPont_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT jatekos AS Játékos, pont AS Pont, datum AS Időpont FROM jatek", con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dtgv_pont.DataSource = dtbl;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bitosan üríti a ponttáblát?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"DELETE FROM jatek;";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT jatekos AS Játékos, pont AS Pont, datum AS Időpont FROM jatek", con);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dtgv_pont.DataSource = dtbl;
            }
        }
    }
}
