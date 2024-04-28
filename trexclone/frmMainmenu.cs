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
using MySql.Data.MySqlClient;

namespace T_Rex_Endless_Runner_MOO_ICT
{


    public partial class frmMainmenu : Form
    {

        Form1 frmgame = new Form1();


        public frmMainmenu()
        {
            InitializeComponent();
           
            LoadData();

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            GlobalVariables.UserName = tbtName.Text;
            frmgame.Show();
            this.Hide();
        }


        public static class GlobalVariables
        {
            public static string UserName { get; set; }
        }



        private void tblScoreboardBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void frmMainmenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMainmenu_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDinorunDataSet.tblScoreboard' table. You can move, or remove it, as needed.
            this.tblScoreboardTableAdapter.Fill(this.dBDinorunDataSet.tblScoreboard);

        }

        private void btndatabase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no way you don't know this game");

        }
        private void LoadData()
        {
            MySqlConnection conn;
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;userid=root;password='root'; database=dinorun";
            try
            {
                conn.Open();
                string query = "SELECT dUsername,dScore FROM tbluserscore ORDER BY dScore DESC LIMIT 5";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
