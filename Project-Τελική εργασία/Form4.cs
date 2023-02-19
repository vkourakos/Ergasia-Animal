using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Project_Τελική_εργασία
{
    public partial class Form4 : Form
    {
        //initializing the sqlite connection
        SQLiteConnection connection;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //connects to the database, reads all the data by descending score order. it puts them in a datatable and then gives that datatable as a data source for the dataGridView
            connection = new SQLiteConnection("Data Source=AnimalAbuse.db;Version=3;");
            connection.Open();

            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = "select * from animalAbuseSt order by score desc";
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Level");
            dataTable.Columns.Add("Score");
            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Username"] = reader["username"];
                row["Level"] = reader["level"];
                row["Score"] = reader["score"];
                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Back to Menu
            this.Hide();
            Form1 form1 = new Form1();
            
            form1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //closes the app
            Application.Exit();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the app
            Application.Exit();
        }
    }
}
