namespace kursavaya_poject
{
    partial class ShowMyPlaylists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMyPlaylists));
            this.label1 = new System.Windows.Forms.Label();
            this.button1_close = new System.Windows.Forms.Button();
            this.textBox1_enter_namePL = new System.Windows.Forms.TextBox();
            this.button2_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_deletePL = new System.Windows.Forms.TextBox();
            this.button1_deletePL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваши плейлисты";
            // 
            // button1_close
            // 
            this.button1_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_close.Location = new System.Drawing.Point(560, 445);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(113, 31);
            this.button1_close.TabIndex = 2;
            this.button1_close.Text = "CLOSE";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click);
            // 
            // textBox1_enter_namePL
            // 
            this.textBox1_enter_namePL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_enter_namePL.Location = new System.Drawing.Point(387, 219);
            this.textBox1_enter_namePL.Name = "textBox1_enter_namePL";
            this.textBox1_enter_namePL.Size = new System.Drawing.Size(286, 20);
            this.textBox1_enter_namePL.TabIndex = 3;
            // 
            // button2_ok
            // 
            this.button2_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_ok.Location = new System.Drawing.Point(560, 245);
            this.button2_ok.Name = "button2_ok";
            this.button2_ok.Size = new System.Drawing.Size(113, 31);
            this.button2_ok.TabIndex = 4;
            this.button2_ok.Text = "ОТКРЫТЬ";
            this.button2_ok.UseVisualStyleBackColor = true;
            this.button2_ok.Click += new System.EventHandler(this.button2_ok_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(387, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите название плейлиста, который хотите открыть";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(387, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите название плейлиста, который хотите удалить";
            // 
            // textBox1_deletePL
            // 
            this.textBox1_deletePL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1_deletePL.Location = new System.Drawing.Point(387, 337);
            this.textBox1_deletePL.Name = "textBox1_deletePL";
            this.textBox1_deletePL.Size = new System.Drawing.Size(286, 20);
            this.textBox1_deletePL.TabIndex = 7;
            // 
            // button1_deletePL
            // 
            this.button1_deletePL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1_deletePL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_deletePL.Location = new System.Drawing.Point(560, 363);
            this.button1_deletePL.Name = "button1_deletePL";
            this.button1_deletePL.Size = new System.Drawing.Size(113, 31);
            this.button1_deletePL.TabIndex = 8;
            this.button1_deletePL.Text = "УДАЛИТЬ";
            this.button1_deletePL.UseVisualStyleBackColor = true;
            this.button1_deletePL.Click += new System.EventHandler(this.button1_deletePL_Click);
            // 
            // ShowMyPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 488);
            this.Controls.Add(this.button1_deletePL);
            this.Controls.Add(this.textBox1_deletePL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_ok);
            this.Controls.Add(this.textBox1_enter_namePL);
            this.Controls.Add(this.button1_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowMyPlaylists";
            this.Text = "Мои плейлисты";
            this.Load += new System.EventHandler(this.ShowMyPlaylists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_close;
        private System.Windows.Forms.TextBox textBox1_enter_namePL;
        private System.Windows.Forms.Button button2_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_deletePL;
        private System.Windows.Forms.Button button1_deletePL;
    }
}