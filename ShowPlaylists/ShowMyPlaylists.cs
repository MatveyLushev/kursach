using kursavaya_poject.ShowPlaylists;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kursavaya_poject
{
    public partial class ShowMyPlaylists : Form
    {
        private SqlConnection userPL = null;
        public ShowMyPlaylists()
        {
            InitializeComponent();
        }

        private void button2_ok_Click(object sender, EventArgs e)
        {
            ShowSongsInPl form = new ShowSongsInPl(textBox1_enter_namePL.Text);
            form.ShowDialog();
        }

        private void ShowMyPlaylists_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            userPL = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            userPL.Open();

            SqlDataAdapter playlists = new SqlDataAdapter("SELECT Name_playlist FROM MyPlaylists", userPL);
            DataSet set = new DataSet();
            playlists.Fill(set);
            dataGridView1.DataSource= set.Tables[0];
            userPL.Close();
        }

        private void button1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_deletePL_Click(object sender, EventArgs e)
        {
            string deletePL = textBox1_deletePL.Text;
            dataGridView1.Refresh();
            userPL = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            userPL.Open();
            SqlCommand deletePlayList = new SqlCommand();
            deletePlayList.Connection = userPL;
            deletePlayList.CommandText = "DELETE FROM MyPlaylists WHERE Name_Playlist LIKE '%" + deletePL + "%'";
            deletePlayList.ExecuteNonQuery();

            SqlDataAdapter delPL = new SqlDataAdapter("SELECT Name_playlist FROM MyPlaylists", userPL);
            DataSet del_set = new DataSet();
            delPL.Fill(del_set);
            dataGridView1.DataSource = del_set.Tables[0];

            SqlCommand dropTable = new SqlCommand();
            dropTable.Connection = userPL;
            dropTable.CommandText = "DROP TABLE " + deletePL;
            userPL.Close();
        }
    }
}
