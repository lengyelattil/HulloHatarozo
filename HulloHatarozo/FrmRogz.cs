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
    public partial class FrmRogz : Form
    {
        public FrmRogz()
        {
            InitializeComponent();
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (txtb_jnev.Text == "")
            {
                MessageBox.Show("Nincs megadva játékosnév!", "Hibás kitöltés!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime ido = DateTime.Now;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $@"INSERT INTO jatek (jatekos, pont, datum) 
                VALUES('{txtb_jnev.Text}', '{FrmJat.pont}', '{ido}')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                this.Close();
            }  
        }

        SqlConnection con;
        

        private void FrmRogz_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();
        }
    }
}
