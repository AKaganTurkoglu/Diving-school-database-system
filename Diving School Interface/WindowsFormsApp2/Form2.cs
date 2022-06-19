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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "SELECT * FROM teachers order by teacher_id";
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

        private void button1_Click(object sender, EventArgs e) //insert teacher
        {
            string text1 = textBox1.Text; //first name
            string text2 = textBox2.Text; // last name
            string text3 = textBox3.Text; // phone number
            string text4 = textBox4.Text; // birth date
            string text5 = textBox5.Text; // salary
            string text6 = textBox6.Text; // hire date
            string text7 = textBox7.Text; // ssn

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select insert_teacher('{0}','{1}','{2}','{3}',{4},'{5}','{6}');", text1, text2, text3, text4, text5, text6, text7);
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


        private void button2_Click_1(object sender, EventArgs e)
        {
            string text1 = textBox8.Text; //teacher id

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select delete_teacher({0});", text1);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            string text1 = textBox9.Text; //teacher id
            string text2 = textBox10.Text; //phone number
            string text3 = textBox11.Text; //salary

            MessageBox.Show(text1, "SONUC BASARILI ");
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=Diving_School_DB;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = String.Format("select update_teacher({0},'{1}',{2});", text1, text2, text3);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e) //delete teacher
        {

        }



        private void button3_Click(object sender, EventArgs e) //update teacher
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

    }



    }

