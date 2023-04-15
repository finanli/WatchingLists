﻿namespace WatchingLists
{
    partial class Series
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series));
            this.catcbx = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.wstcbx = new System.Windows.Forms.ComboBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.mnametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.deleteb = new System.Windows.Forms.Button();
            this.listb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.addb = new System.Windows.Forms.Button();
            this.exitb = new System.Windows.Forms.Button();
            this.episodes = new System.Windows.Forms.Label();
            this.eptxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // catcbx
            // 
            this.catcbx.FormattingEnabled = true;
            this.catcbx.Items.AddRange(new object[] {
            "Romance",
            "Comedy",
            "Action",
            "Fantastic"});
            this.catcbx.Location = new System.Drawing.Point(330, 162);
            this.catcbx.Name = "catcbx";
            this.catcbx.Size = new System.Drawing.Size(173, 21);
            this.catcbx.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 450);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(339, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "0  1  2   3  4   5   6  7  8   9  10";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.MistyRose;
            this.trackBar1.Location = new System.Drawing.Point(330, 492);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(173, 45);
            this.trackBar1.TabIndex = 36;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // wstcbx
            // 
            this.wstcbx.FormattingEnabled = true;
            this.wstcbx.Items.AddRange(new object[] {
            "Waiting to Watching",
            "Just Starting",
            "Still Watching",
            "Finished"});
            this.wstcbx.Location = new System.Drawing.Point(330, 362);
            this.wstcbx.Name = "wstcbx";
            this.wstcbx.Size = new System.Drawing.Size(173, 21);
            this.wstcbx.TabIndex = 34;
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(330, 208);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(173, 20);
            this.yeartxt.TabIndex = 33;
            // 
            // mnametxt
            // 
            this.mnametxt.Location = new System.Drawing.Point(327, 123);
            this.mnametxt.Name = "mnametxt";
            this.mnametxt.Size = new System.Drawing.Size(176, 20);
            this.mnametxt.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(245, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(159, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Watching Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(182, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Watching\r\nStarting Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(254, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Year :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(220, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Category :";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.BackColor = System.Drawing.Color.Transparent;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sname.Location = new System.Drawing.Point(188, 123);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(121, 20);
            this.sname.TabIndex = 26;
            this.sname.Text = "Series Name :";
            // 
            // deleteb
            // 
            this.deleteb.BackColor = System.Drawing.Color.Transparent;
            this.deleteb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteb.Location = new System.Drawing.Point(27, 402);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(95, 79);
            this.deleteb.TabIndex = 25;
            this.deleteb.UseVisualStyleBackColor = false;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // listb
            // 
            this.listb.BackColor = System.Drawing.Color.Transparent;
            this.listb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listb.Location = new System.Drawing.Point(27, 311);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(104, 85);
            this.listb.TabIndex = 24;
            this.listb.UseVisualStyleBackColor = false;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // updateb
            // 
            this.updateb.BackColor = System.Drawing.Color.Transparent;
            this.updateb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateb.Location = new System.Drawing.Point(27, 221);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(95, 82);
            this.updateb.TabIndex = 23;
            this.updateb.UseVisualStyleBackColor = false;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // addb
            // 
            this.addb.BackColor = System.Drawing.Color.Transparent;
            this.addb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addb.Location = new System.Drawing.Point(27, 123);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(95, 82);
            this.addb.TabIndex = 22;
            this.addb.UseVisualStyleBackColor = false;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // exitb
            // 
            this.exitb.BackColor = System.Drawing.Color.Transparent;
            this.exitb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitb.Location = new System.Drawing.Point(1242, 1);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(104, 69);
            this.exitb.TabIndex = 21;
            this.exitb.UseVisualStyleBackColor = false;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // episodes
            // 
            this.episodes.AutoSize = true;
            this.episodes.BackColor = System.Drawing.Color.Transparent;
            this.episodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.episodes.Location = new System.Drawing.Point(216, 255);
            this.episodes.Name = "episodes";
            this.episodes.Size = new System.Drawing.Size(93, 20);
            this.episodes.TabIndex = 40;
            this.episodes.Text = "Episodes :";
            // 
            // eptxt
            // 
            this.eptxt.Location = new System.Drawing.Point(330, 253);
            this.eptxt.Name = "eptxt";
            this.eptxt.Size = new System.Drawing.Size(173, 20);
            this.eptxt.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(330, 427);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(192, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 40);
            this.label7.TabIndex = 42;
            this.label7.Text = "Watching\r\nEnding Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Toledo", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(39, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(506, 83);
            this.label8.TabIndex = 44;
            this.label8.Text = "SERIES PANEL";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(511, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 29);
            this.button5.TabIndex = 78;
            this.button5.Text = "List";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(511, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 29);
            this.button6.TabIndex = 77;
            this.button6.Text = "List";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Series
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 562);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eptxt);
            this.Controls.Add(this.episodes);
            this.Controls.Add(this.catcbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.wstcbx);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.mnametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.listb);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.exitb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Series";
            this.Text = "Series";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catcbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox wstcbx;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.TextBox mnametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Label episodes;
        private System.Windows.Forms.TextBox eptxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}