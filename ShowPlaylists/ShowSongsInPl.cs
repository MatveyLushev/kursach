using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kursavaya_poject.ShowPlaylists
{
    public partial class ShowSongsInPl : Form
    {
        public string namePL;
        private SqlConnection con = null;
        public ShowSongsInPl(string _namePL)
        {
            namePL = _namePL;
            InitializeComponent();
        }

        private void ShowSongsInPl_Load(object sender, EventArgs e)
        {
            label1_namePL.Text = namePL;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            con.Open();

            SqlCommand showsongs = new SqlCommand();
            showsongs.Connection = con;
            SqlDataAdapter dataAdapter= new SqlDataAdapter("SELECT Name_musician, Name_song, Duration_song FROM " + namePL, con);
            DataSet set= new DataSet();
            dataAdapter.Fill(set);
            dataGridView1_songs.DataSource = set.Tables[0];
        }
        private void button1_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_deleteSong_Click(object sender, EventArgs e)
        {
            string deletesong = textBox1_delete_song.Text;
            SqlCommand delete_song = null;

            dataGridView1_songs.Refresh();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            con.Open();
            delete_song= new SqlCommand();
            delete_song.Connection = con;
            delete_song.CommandText = "DELETE FROM " + namePL + " WHERE Name_musician LIKE '%" + deletesong + "%'";
            delete_song.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name_musician, Name_song, Duration_song FROM " + namePL, con);
            DataSet set = new DataSet();
            adapter.Fill(set); 
            dataGridView1_songs.DataSource = set.Tables[0];
            con.Close();
            
        }
    }
}
