using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace Project_Τελική_εργασία
{
    public partial class Form2 : Form
    {
        int time = 10, score = 0;//Initialisation
        Random r = new Random();
        String animalVS;
        SQLiteConnection connection;
        String username;
        String diff;
        public Form2(String x, String un)
        {
            InitializeComponent();
            username = un;
            diff = x;
            label_User.Text = "User: " + un;
            
            Level level = new Level();
            level.Difficulty = x;
            Animal animal = new Animal();
            //sets the level according to the selected item from the combobox in form1
            if (level.Difficulty.Equals("Medium"))
            {
                animalPic.Size = new Size(50, 50);
                label_Level.Text = "Level:Medium";
                animal.Name = "Medium Animal";

                
            }
            else if (level.Difficulty.Equals("Hard"))
            {
                timer2.Interval = 300;
                label_Level.Text = "Level:Hard";
                animal.Name = "Hard Animal";

            }
            else
            {
                animalPic.Size = new Size(100, 100);
                label_Level.Text = "Level:Easy";
                animal.Name = "Easy Animal";


            }
            animalVS = animal.Name;
            
            
                   
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //In every tick of the timer it reduces the time left
            if (time >= 1)
            {
                time -= 1;
                label_Time.Text = "Time: " + time.ToString();
            }
            else
            {
                gameOver();
            }
        }

        private void gameOver()
        {

            timer1.Stop();
            timer2.Stop();
            connection.Open();
            //passes the user details on the data table
            SQLiteCommand command = new SQLiteCommand("insert into animalAbuseSt (username, level, score) values (@username, @level, @score)", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@level", diff);
            command.Parameters.AddWithValue("@score", score);
            
            command.ExecuteNonQuery();
            connection.Close();
            this.Hide();
            Form3 form3 = new Form3(animalVS, score);
            
            form3.ShowDialog();
            
            
        

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //in every tick of the timer and with the help of random we get new coordinates which we save in variables x and y and set them as the new location of the picturebox
            int x = r.Next(0, 732);
            int y = r.Next(35, 352);
            animalPic.Location = new Point(x, y);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //checks if the database file exists. If it doesnt it creates it and the table inside it. In both cases it creates the connection
            if (File.Exists("AnimalAbuse.db"))
            {
                connection = new SQLiteConnection("Data Source=AnimalAbuse.db;Version=3;");
            }
            else
            {
                
                SQLiteConnection.CreateFile("AnimalAbuse.db");
                connection = new SQLiteConnection("Data Source=AnimalAbuse.db;Version=3;");
                connection.Open();
                string sql = "create table animalAbuseSt (username char, level char, score integer)";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the app
            Application.Exit();
        }

        private void animal_MouseDown(object sender, MouseEventArgs e)
        {
            if (time > 0)
            {
                //in the event of MouseDown in the picturebox it increases our score
                score += 1;
                label_Score.Text = "Score: " + score.ToString();
            }
            
        }  
        
        

    }
}
