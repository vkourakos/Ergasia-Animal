using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Τελική_εργασία
{
    public partial class Form3 : Form
    {
        

        public Form3(String diff, int s)
        {
            InitializeComponent();
            
            label2.Text = "You scored: " + s + " points versus " + diff + " !";//shows the user his score vs which animal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Shows highscore form
            this.Hide();
            Form4 form4 = new Form4();
            
            form4.ShowDialog();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //goes back to menu to play again
            this.Hide();
            Form1 form1 = new Form1();
            
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //closes the app
            Application.Exit();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the app
            Application.Exit();
        }
    }
}
