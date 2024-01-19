namespace kursavaya_poject.ShowPlaylists
{
    partial class ShowSongsInPl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSongsInPl));
            this.label1_namePL = new System.Windows.Forms.Label();
            this.dataGridView1_songs = new System.Windows.Forms.DataGridView();
            this.button1_close = new System.Windows.Forms.Button();
            this.textBox1_delete_song = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_deleteSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_songs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_namePL
            // 
            this.label1_namePL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1_namePL.AutoSize = true;
            this.label1_namePL.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_namePL.Location = new System.Drawing.Point(92, 9);
            this.label1_namePL.Name = "label1_namePL";
            this.label1_namePL.Size = new System.Drawing.Size(237, 39);
            this.label1_namePL.TabIndex = 0;
            this.label1_namePL.Text = "Not named PL";
            // 
            // dataGridView1_songs
            // 
            this.dataGridView1_songs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1_songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_songs.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1_songs.Name = "dataGridView1_songs";
            this.dataGridView1_songs.Size = new System.Drawing.Size(240, 447);
            this.dataGridView1_songs.TabIndex = 1;
            // 
            // button1_close
            // 
            this.button1_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_close.Location = new System.Drawing.Point(334, 467);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(83, 31);
            this.button1_close.TabIndex = 2;
            this.button1_close.Text = "CLOSE";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click_1);
            // 
            // textBox1_delete_song
            // 
            this.textBox1_delete_song.Location = new System.Drawing.Point(258, 262);
            this.textBox1_delete_song.Name = "textBox1_delete_song";
            this.textBox1_delete_song.Size = new System.Drawing.Size(159, 20);
            this.textBox1_delete_song.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(258, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 103);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите имя исполнителя, песню которого вы хотите удалить из плейлиста";
            // 
            // button1_deleteSong
            // 
            this.button1_deleteSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_deleteSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_deleteSong.Location = new System.Drawing.Point(307, 288);
            this.button1_deleteSong.Name = "button1_deleteSong";
            this.button1_deleteSong.Size = new System.Drawing.Size(110, 31);
            this.button1_deleteSong.TabIndex = 5;
            this.button1_deleteSong.Text = "УДАЛИТЬ";
            this.button1_deleteSong.UseVisualStyleBackColor = true;
            this.button1_deleteSong.Click += new System.EventHandler(this.button1_deleteSong_Click);
            // 
            // ShowSongsInPl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 510);
            this.Controls.Add(this.button1_deleteSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_delete_song);
            this.Controls.Add(this.button1_close);
            this.Controls.Add(this.dataGridView1_songs);
            this.Controls.Add(this.label1_namePL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowSongsInPl";
            this.Text = "Мой плейлист";
            this.Load += new System.EventHandler(this.ShowSongsInPl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_songs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_namePL;
        private System.Windows.Forms.DataGridView dataGridView1_songs;
        private System.Windows.Forms.Button button1_close;
        private System.Windows.Forms.TextBox textBox1_delete_song;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_deleteSong;
    }
}