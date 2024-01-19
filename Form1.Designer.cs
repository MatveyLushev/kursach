namespace kursavaya_poject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Number_song = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_close = new System.Windows.Forms.Button();
            this.button1_makeNewPlaylist = new System.Windows.Forms.Button();
            this.button1_show_my_playlists = new System.Windows.Forms.Button();
            this.textBox1_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 625);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(390, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 265);
            this.panel1.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, -12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(392, 274);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Number_song
            // 
            this.Number_song.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Number_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_song.Location = new System.Drawing.Point(495, 325);
            this.Number_song.Name = "Number_song";
            this.Number_song.Size = new System.Drawing.Size(100, 31);
            this.Number_song.TabIndex = 1;
            // 
            // button_play
            // 
            this.button_play.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_play.Location = new System.Drawing.Point(601, 325);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(100, 31);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(443, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите номер песни";
            // 
            // button1_close
            // 
            this.button1_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_close.Location = new System.Drawing.Point(713, 602);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(75, 23);
            this.button1_close.TabIndex = 4;
            this.button1_close.Text = "CLOSE";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click);
            // 
            // button1_makeNewPlaylist
            // 
            this.button1_makeNewPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1_makeNewPlaylist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1_makeNewPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_makeNewPlaylist.Location = new System.Drawing.Point(393, 407);
            this.button1_makeNewPlaylist.Name = "button1_makeNewPlaylist";
            this.button1_makeNewPlaylist.Size = new System.Drawing.Size(183, 31);
            this.button1_makeNewPlaylist.TabIndex = 5;
            this.button1_makeNewPlaylist.Text = "+Новый плейлист";
            this.button1_makeNewPlaylist.UseVisualStyleBackColor = true;
            this.button1_makeNewPlaylist.Click += new System.EventHandler(this.button1_makeNewPlaylist_Click);
            // 
            // button1_show_my_playlists
            // 
            this.button1_show_my_playlists.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1_show_my_playlists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1_show_my_playlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_show_my_playlists.Location = new System.Drawing.Point(393, 444);
            this.button1_show_my_playlists.Name = "button1_show_my_playlists";
            this.button1_show_my_playlists.Size = new System.Drawing.Size(183, 31);
            this.button1_show_my_playlists.TabIndex = 6;
            this.button1_show_my_playlists.Text = "Мои плейлисты";
            this.button1_show_my_playlists.UseVisualStyleBackColor = true;
            this.button1_show_my_playlists.Click += new System.EventHandler(this.button1_show_my_playlists_Click);
            // 
            // textBox1_search
            // 
            this.textBox1_search.Location = new System.Drawing.Point(393, 371);
            this.textBox1_search.Name = "textBox1_search";
            this.textBox1_search.Size = new System.Drawing.Size(392, 20);
            this.textBox1_search.TabIndex = 7;
            this.textBox1_search.Text = "Поиск....";
            this.textBox1_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search);
            this.textBox1_search.TextChanged += new System.EventHandler(this.textBox1_search_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.textBox1_search);
            this.Controls.Add(this.button1_show_my_playlists);
            this.Controls.Add(this.button1_makeNewPlaylist);
            this.Controls.Add(this.button1_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.Number_song);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VK music";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox Number_song;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_close;
        private System.Windows.Forms.Button button1_makeNewPlaylist;
        private System.Windows.Forms.Button button1_show_my_playlists;
        private System.Windows.Forms.TextBox textBox1_search;
    }
}