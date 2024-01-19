namespace kursavaya_poject
{
    partial class NewPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlaylist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1_generaldisk = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1_newplaylist = new System.Windows.Forms.DataGridView();
            this.label1_generalpl = new System.Windows.Forms.Label();
            this.label2_name_newplaylist = new System.Windows.Forms.Label();
            this.button1_add = new System.Windows.Forms.Button();
            this.button1_del = new System.Windows.Forms.Button();
            this.button1_close = new System.Windows.Forms.Button();
            this.textBox1_add_newSong_to_newpl = new System.Windows.Forms.TextBox();
            this.textBox2_deleteSong_from_newpl = new System.Windows.Forms.TextBox();
            this.button1_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_generaldisk)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_newplaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1_generaldisk);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 390);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1_generaldisk
            // 
            this.dataGridView1_generaldisk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_generaldisk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1_generaldisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_generaldisk.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1_generaldisk.Name = "dataGridView1_generaldisk";
            this.dataGridView1_generaldisk.Size = new System.Drawing.Size(335, 384);
            this.dataGridView1_generaldisk.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1_newplaylist);
            this.panel2.Location = new System.Drawing.Point(462, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 390);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1_newplaylist
            // 
            this.dataGridView1_newplaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_newplaylist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1_newplaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_newplaylist.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1_newplaylist.Name = "dataGridView1_newplaylist";
            this.dataGridView1_newplaylist.Size = new System.Drawing.Size(335, 384);
            this.dataGridView1_newplaylist.TabIndex = 8;
            // 
            // label1_generalpl
            // 
            this.label1_generalpl.AutoSize = true;
            this.label1_generalpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_generalpl.Location = new System.Drawing.Point(12, 9);
            this.label1_generalpl.Name = "label1_generalpl";
            this.label1_generalpl.Size = new System.Drawing.Size(245, 33);
            this.label1_generalpl.TabIndex = 2;
            this.label1_generalpl.Text = "Общий плейлист";
            // 
            // label2_name_newplaylist
            // 
            this.label2_name_newplaylist.AutoSize = true;
            this.label2_name_newplaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_name_newplaylist.Location = new System.Drawing.Point(605, 9);
            this.label2_name_newplaylist.Name = "label2_name_newplaylist";
            this.label2_name_newplaylist.Size = new System.Drawing.Size(183, 33);
            this.label2_name_newplaylist.TabIndex = 3;
            this.label2_name_newplaylist.Text = "not named pl";
            // 
            // button1_add
            // 
            this.button1_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_add.Location = new System.Drawing.Point(676, 468);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(112, 36);
            this.button1_add.TabIndex = 4;
            this.button1_add.Text = "ДОБАВИТЬ";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // button1_del
            // 
            this.button1_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_del.Location = new System.Drawing.Point(676, 510);
            this.button1_del.Name = "button1_del";
            this.button1_del.Size = new System.Drawing.Size(112, 36);
            this.button1_del.TabIndex = 5;
            this.button1_del.Text = "УДАЛИТЬ";
            this.button1_del.UseVisualStyleBackColor = true;
            this.button1_del.Click += new System.EventHandler(this.button1_del_Click);
            // 
            // button1_close
            // 
            this.button1_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_close.Location = new System.Drawing.Point(676, 556);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(112, 36);
            this.button1_close.TabIndex = 6;
            this.button1_close.Text = "CLOSE";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click);
            // 
            // textBox1_add_newSong_to_newpl
            // 
            this.textBox1_add_newSong_to_newpl.Location = new System.Drawing.Point(12, 478);
            this.textBox1_add_newSong_to_newpl.Name = "textBox1_add_newSong_to_newpl";
            this.textBox1_add_newSong_to_newpl.Size = new System.Drawing.Size(658, 20);
            this.textBox1_add_newSong_to_newpl.TabIndex = 7;
            // 
            // textBox2_deleteSong_from_newpl
            // 
            this.textBox2_deleteSong_from_newpl.Location = new System.Drawing.Point(12, 520);
            this.textBox2_deleteSong_from_newpl.Name = "textBox2_deleteSong_from_newpl";
            this.textBox2_deleteSong_from_newpl.Size = new System.Drawing.Size(658, 20);
            this.textBox2_deleteSong_from_newpl.TabIndex = 8;
            // 
            // button1_save
            // 
            this.button1_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_save.Location = new System.Drawing.Point(549, 556);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(121, 36);
            this.button1_save.TabIndex = 9;
            this.button1_save.Text = "ПРИМЕНИТЬ";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // NewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.textBox2_deleteSong_from_newpl);
            this.Controls.Add(this.textBox1_add_newSong_to_newpl);
            this.Controls.Add(this.button1_close);
            this.Controls.Add(this.button1_del);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.label2_name_newplaylist);
            this.Controls.Add(this.label1_generalpl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlaylist";
            this.Text = "Новый плейлист";
            this.Load += new System.EventHandler(this.NewPlaylist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_generaldisk)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_newplaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1_generaldisk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1_newplaylist;
        private System.Windows.Forms.Label label1_generalpl;
        private System.Windows.Forms.Label label2_name_newplaylist;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.Button button1_del;
        private System.Windows.Forms.Button button1_close;
        private System.Windows.Forms.TextBox textBox1_add_newSong_to_newpl;
        private System.Windows.Forms.TextBox textBox2_deleteSong_from_newpl;
        private System.Windows.Forms.Button button1_save;
    }
}