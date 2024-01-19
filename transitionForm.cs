using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kursavaya_poject
{
    public partial class transitionForm : Form
    {
        private SqlConnection con = null;
        public transitionForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString); 
            con.Open();
            SqlCommand add_newPl_to_Myplaylists_table = new SqlCommand();
            add_newPl_to_Myplaylists_table.Connection = con;
            add_newPl_to_Myplaylists_table.CommandText = "INSERT INTO Myplaylists (Name_playlist) VALUES ('" + textBox1_nameNewPlaylist.Text + "')";
            add_newPl_to_Myplaylists_table.ExecuteNonQuery();
            con.Close();
            NewPlaylist form = new NewPlaylist(textBox1_nameNewPlaylist.Text);
            form.Show();
            this.Close();
        }

        private void button2_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
