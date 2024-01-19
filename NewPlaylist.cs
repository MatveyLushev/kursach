using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kursavaya_poject
{
    public partial class NewPlaylist : Form
    {
        private SqlConnection sqlConnection_genpl = null;
        private SqlConnection sqlConnection_temp = null;
        public string name_newplaylist;
        public NewPlaylist(string _name_newplaylist)
        {
            name_newplaylist = _name_newplaylist;            
            InitializeComponent();
        }

        public NewPlaylist() { }

        private void NewPlaylist_Load(object sender, EventArgs e)
        {
            string str;
            sqlConnection_temp = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            sqlConnection_genpl = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            
            sqlConnection_temp.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection_temp;
            str = " CREATE TABLE [dbo].[" + name_newplaylist + "] (\r\n    [Id]            INT           IDENTITY (1, 1) NOT NULL,\r\n    [Name_musician] NVARCHAR (50) NULL,\r\n    [Name_song]     NVARCHAR (50) NULL,\r\n    [Duration_song] NVARCHAR (50) NULL,\r\n    PRIMARY KEY CLUSTERED ([Id] ASC)\r\n)";
            command.CommandText = str;
            command.ExecuteNonQuery();

            sqlConnection_genpl.Open();
            label2_name_newplaylist.Text = name_newplaylist;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Name_musician, Name_song, Duration_song FROM GeneralDisk", sqlConnection_genpl);
            SqlDataAdapter dataAdapter_temp = new SqlDataAdapter("SELECT Name_musician, Name_song, Duration_song FROM " + name_newplaylist, sqlConnection_temp);
            DataSet set = new DataSet();
            DataSet set_temp = new DataSet();
            dataAdapter.Fill(set);
            dataAdapter_temp.Fill(set_temp);
            dataGridView1_generaldisk.DataSource = set.Tables[0];
            dataGridView1_newplaylist.DataSource = set_temp.Tables[0];
            sqlConnection_temp.Close();
            sqlConnection_genpl.Close();
        }
        private void button1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_add_Click(object sender, EventArgs e)
        {            
            
            string name = textBox1_add_newSong_to_newpl.Text;
            SqlCommand add_newSong = null;

            sqlConnection_temp = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            sqlConnection_genpl = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            sqlConnection_temp.Open();
            sqlConnection_genpl.Open();

            add_newSong = new SqlCommand();
            add_newSong.Connection= sqlConnection_temp;
            add_newSong.CommandText = "INSERT INTO " + label2_name_newplaylist.Text + "(Name_musician,Name_song,Duration_song) SELECT Name_musician, Name_song, Duration_song FROM GeneralDisk WHERE Name_musician LIKE N'%" + textBox1_add_newSong_to_newpl.Text +"%';";
            add_newSong.ExecuteNonQuery();
            sqlConnection_genpl.Close();
            sqlConnection_temp.Close();
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            dataGridView1_newplaylist.Refresh();
            sqlConnection_temp = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            SqlDataAdapter refresh = new SqlDataAdapter("SELECT Name_musician, Name_song, Duration_song FROM " + name_newplaylist, sqlConnection_temp);
            DataSet set_refresh = new DataSet();
            refresh.Fill(set_refresh);
            dataGridView1_newplaylist.DataSource = set_refresh.Tables[0];
        }

        private void button1_del_Click(object sender, EventArgs e)
        {
            string delete_song = textBox2_deleteSong_from_newpl.Text;
            SqlCommand delete = null;

            sqlConnection_temp = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            sqlConnection_temp.Open();

            delete = new SqlCommand();
            delete.Connection= sqlConnection_temp;
            delete.CommandText = "DELETE FROM " + name_newplaylist + " WHERE Name_musician LIKE '%" + delete_song +"%'"; 
            delete.ExecuteNonQuery();
            sqlConnection_temp.Close();
        }
    }
}
