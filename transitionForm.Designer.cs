namespace kursavaya_poject
{
    partial class transitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transitionForm));
            this.textBox1_nameNewPlaylist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_nameNewPlaylist
            // 
            this.textBox1_nameNewPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_nameNewPlaylist.Location = new System.Drawing.Point(12, 115);
            this.textBox1_nameNewPlaylist.Name = "textBox1_nameNewPlaylist";
            this.textBox1_nameNewPlaylist.Size = new System.Drawing.Size(322, 26);
            this.textBox1_nameNewPlaylist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название нового плейлиста";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(195, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "СОЗДАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_close
            // 
            this.button2_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_close.Location = new System.Drawing.Point(12, 221);
            this.button2_close.Name = "button2_close";
            this.button2_close.Size = new System.Drawing.Size(139, 46);
            this.button2_close.TabIndex = 3;
            this.button2_close.Text = "CLOSE";
            this.button2_close.UseVisualStyleBackColor = true;
            this.button2_close.Click += new System.EventHandler(this.button2_close_Click);
            // 
            // transitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 279);
            this.Controls.Add(this.button2_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_nameNewPlaylist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "transitionForm";
            this.Text = "Создание нового плейлиста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_close;
        public System.Windows.Forms.TextBox textBox1_nameNewPlaylist;
    }
}