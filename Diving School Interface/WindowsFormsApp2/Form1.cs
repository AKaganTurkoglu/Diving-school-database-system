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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn; 
            comm.CommandType = CommandType.Text;
            
            comm.CommandText = "SELECT * FROM students order by student_id";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         string text1 = textBox1.Text;
         string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            string text5 = textBox5.Text;
        
            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("insert into Students (first_name, last_name, phone_number, birth_date, ssn) values ('{0}', '{1}', '{2}', '{3}', '{4}');", text1, text2, text3, text4, text5);
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.Refresh();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            comm.Dispose();
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deneme2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text1 = textBox6.Text;
           

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select delete_student({0});", text1);

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

        private void button3_Click(object sender, EventArgs e)
        {
            string text1 = textBox7.Text;
            string text2 = textBox8.Text;

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select update_student({0},'{1}');", text1,text2);
            
            NpgsqlDataReader dr3 = comm.ExecuteReader();
            if (dr3.HasRows)
            {
                DataTable dt3 = new DataTable();
                dt3.Load(dr3);
                dataGridView1.DataSource = dt3;
            }
            comm.Dispose();
            conn.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
