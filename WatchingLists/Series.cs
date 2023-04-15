﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WatchingLists
{
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server = LAPTOP-DI6H08K1; Database = WatchingList; Integrated Security = true;");

        public void Listele(string komutkod)
        {
            SqlDataAdapter da = new SqlDataAdapter(komutkod, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into series(seriesName, category, year, episodes, wstartd, watchingStatus, wendd, score) " +
                "                           values(@seriesName, @category, @year, @episodes, @wstartd, @watchingStatus, @wendd, @score)", conn);
            cmd.Parameters.AddWithValue("@seriesName", mnametxt.Text);
            cmd.Parameters.AddWithValue("@category", catcbx.Text);
            cmd.Parameters.AddWithValue("@year", yeartxt.Text);
            cmd.Parameters.AddWithValue("@episodes", eptxt.Text);
            cmd.Parameters.AddWithValue("@wstartd", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@watchingStatus", wstcbx.Text);
            cmd.Parameters.AddWithValue("@wendd", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@score", trackBar1.Value);
            cmd.ExecuteNonQuery();

            conn.Close();
            Listele("select * from series");
        }

        private void listb_Click(object sender, EventArgs e)
        {
            Listele("select * from series");
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update series set seriesName = '" + mnametxt.Text.ToString() + "'," +
                " category = '" + catcbx.Text.ToString() + "', year = '" + yeartxt.Text.ToString() + "' , episodes = '"+eptxt.Text.ToString()+"'," +
                " wdate = '" + dateTimePicker1.Text.ToString() + "', watchingStatus = '" + wstcbx.Text.ToString() + "'," +
                "wendd = '"+dateTimePicker2.Text.ToString()+"', score ='" + trackBar1.Value + "' where seriesID = @seriesID", conn);
            cmd.Parameters.AddWithValue("@seriesID", mnametxt.Tag);
            cmd.ExecuteNonQuery();

            conn.Close();
            Listele("select * from series");
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from series where seriesID = @seriesD", conn);
            cmd.Parameters.AddWithValue("@seriesID", mnametxt.Tag);
            cmd.ExecuteNonQuery();

            conn.Close();
            Listele("select * from series");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            mnametxt.Text = satir.Cells["seriesName"].Value.ToString();
            catcbx.Text = satir.Cells["category"].Value.ToString();
            yeartxt.Text = satir.Cells["year"].Value.ToString();
            eptxt.Text = satir.Cells["episodes"].Value.ToString();
            dateTimePicker1.Text = satir.Cells["wstartd"].Value.ToString();
            wstcbx.Text = satir.Cells["watchingStatus"].Value.ToString();
            dateTimePicker2.Text = satir.Cells["wendd"].Value.ToString();
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            if (wstcbx.SelectedIndex == 0)
            {
                Listele("select * from series where watchingStatus = 'Waiting to Watching'");
            }
            else if (wstcbx.SelectedIndex == 2)
            {
                Listele("select * from series where watchingStatus = 'Still Watching'");
            }
            else if (wstcbx.SelectedIndex == 1)
            {
                Listele("select * from series where watchingStatus = 'Just Starting'");
            }
            else
            {
                Listele("select * from series where watchingStatus = 'Finished'");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (catcbx.SelectedIndex == 0)
            {
                Listele("select * from series where Category = 'Romance'");
            }
            else if (catcbx.SelectedIndex == 1)
            {
                Listele("select * from series where Category = 'Comedy'");
            }
            else if (catcbx.SelectedIndex == 2)
            {
                Listele("select * from series where Category = 'Action'");
            }
            else
            {
                Listele("select * from series where Category = 'Fantastic'");
            }
        }
    
    }
}
