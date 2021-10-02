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
    public partial class FrmMon : Form
    {
        public FrmMon()
        {
            InitializeComponent();
        }

        private void FrmMon_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\hullohat.mdf; Integrated Security=True";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, faj AS Faj, hely AS Hely, datum AS Dátum FROM eszleles", con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dtgv_eszlel.DataSource = dtbl;
        }

        SqlConnection con;

        private void addElement()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $@"INSERT INTO eszleles (hely, datum, faj) 
            VALUES('{txtb_hely.Text}', '{dTP_ido.Value.Date.ToString("d")}', '{cmb_nev.SelectedItem.ToString()}')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        private void btn_rogzit_Click(object sender, EventArgs e)
        {
            if (txtb_hely.Text=="" || cmb_nev.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Nincs kitöltve minden adattag a rögzítéshez!","Hibás kitöltés!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                addElement();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, faj AS Faj, hely AS Hely, datum AS Dátum FROM eszleles", con);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dtgv_eszlel.DataSource = dtbl;
            }
        }

        string torlendoid;
        private void btn_torol_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bitosan törli a kijelölt elemet?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $@"DELETE FROM eszleles WHERE Id= '{torlendoid}'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, faj AS Faj, hely AS Hely, datum AS Dátum FROM eszleles", con);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dtgv_eszlel.DataSource = dtbl;
            }
           
        }

        private void dtgv_eszlel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           torlendoid = (dtgv_eszlel.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
