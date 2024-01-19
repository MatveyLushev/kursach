using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using WMPLib;
using System.Diagnostics;
using System.Threading;

namespace kursavaya_poject
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Name_musician, Name_song, Duration_song FROM GeneralDisk", sqlConnection);
            DataSet set = new DataSet();
            dataAdapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (Number_song.Text == "1")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Maroon_5_-_One_More_Night_47829875.mp3";
            if (Number_song.Text == "2")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Aarne_Dora_-_Trezvo_76894963.mp3";
            if (Number_song.Text == "3")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\LIZER_-_Svoboda_73277536.mp3";
            if (Number_song.Text == "4")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\John_Newman_-_Love_Me_Again_48058117.mp3";
            if (Number_song.Text == "5")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Serega_pirat_-_tp_na_ame_73250008.mp3";
            if (Number_song.Text == "6")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\william_Britney_Spears_-_Scream_Shout_56305619.mp3";
            if (Number_song.Text == "7")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\OBLADAET_JEEMBO_-_HELLA_PLAYERS_73125851.mp3";
            if (Number_song.Text == "8")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Egor_Krid_-_Budilnik_47837731.mp3";
            if (Number_song.Text == "9")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Stromae_-_Alors_On_Danse_48744026.mp3";
            if (Number_song.Text == "10")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\shadowraze_-_skyline_ryodan_74936840.mp3";
            if (Number_song.Text == "11")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Pitbull_Soulshock_Biker_-_International_Love_47963604.mp3";
            if (Number_song.Text == "12")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Daryana_Daybe_-_Zastavlyal_75655404.mp3";
            if (Number_song.Text == "13")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\0 похвал - NIX (официальный клип) _ Харизма и блеск (256  kbps).mp3";
            if (Number_song.Text == "14")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\madk1d_-_Tolpy_75934370.mp3";
            if (Number_song.Text == "15")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Kill_Eva_ENCASSATOR_-_psycho_dreamsspeed_up_75724217.mp3";
            if (Number_song.Text == "16")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\INTERWORLD_zxcursed_Sadfriendd_-_METAMORPHOSIS_3_75830129.mp3";
            if (Number_song.Text == "17")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\skazhi_mne_kto_ty_-_xmanera_75506187.mp3";
            if (Number_song.Text == "18")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\INSTASAMKA_-_Otklyuchayu_telefon_75478567.mp3";
            if (Number_song.Text == "19")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\DVRST_Igor_Sklyar_Atomic_Heart_-_Komarovo_75479753.mp3";
            if (Number_song.Text == "20")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Geoffplaysguitar_Zemlyane_Atomic_Heart_-_Trava_u_Doma_75479750.mp3";
            if (Number_song.Text == "21")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Tri_dnya_dozhdya_-_Kristallicheskie_lyarvy_76864075.mp3";
            if (Number_song.Text == "22")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\The_Top_Club_Band_The_Disco_Music_Makers_The_Top_Orchestra_The_Lege_-_Sara_perche_ti_amo_47839961.mp3";
            if (Number_song.Text == "23")axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Umaturman_-_Papiny_dochki_28469014.mp3";
            if (Number_song.Text == "24") axWindowsMediaPlayer1.URL = "C:\\Users\\MSI\\source\\repos\\kursavaya_poject\\bin\\Debug\\songs\\Modern_Talking_-_Cheri_Cheri_Lady_47835463.mp3";
        }

        private void button1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_makeNewPlaylist_Click(object sender, EventArgs e)
        {
            transitionForm Forma = new transitionForm();
            Forma.Show();
        }

        private void button1_show_my_playlists_Click(object sender, EventArgs e)
        {
            ShowMyPlaylists myPlaylists = new ShowMyPlaylists();
            myPlaylists.Show();
        }
        private void search(object sender, MouseEventArgs e)
        {
            textBox1_search.Clear();
        }

        private void textBox1_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name_musician LIKE '%" + textBox1_search.Text + "%'" + " OR Name_song LIKE '%" + textBox1_search.Text + "%'";
        }
    }
}
