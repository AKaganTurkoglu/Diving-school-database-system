using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "SELECT * FROM courses order by course_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text; //course name
            string text2 = textBox2.Text; // course description
            string text3 = textBox3.Text; // course price
            string text4 = textBox4.Text; // course start date
            string text5 = textBox5.Text; // course end date
            string text6 = textBox6.Text; // teacher id

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select insert_course('{0}','{1}',{2},'{3}','{4}',{5});", text1, text2, text3, text4, text5, text6);
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text1 = textBox7.Text; //course id

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select delete_course({0});", text1);
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text1 = textBox8.Text; //course id
            string text2 = textBox9.Text; //course name
            string text3 = textBox10.Text; //course description
            string text4 = textBox11.Text; //course price
            string text5 = textBox12.Text; //course start date
            string text6 = textBox13.Text; //course end date
            string text7 = textBox14.Text; //teacher id

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select update_course({0},'{1}','{2}',{3},'{4}','{5}',{6});", text1, text2, text3, text4, text5, text6, text7);
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
