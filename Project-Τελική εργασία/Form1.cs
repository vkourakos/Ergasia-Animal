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
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null || String.IsNullOrEmpty(textBox1.Text))//both need to have values in order to start the game
            {
                System.Windows.Forms.MessageBox.Show("Πρέπει να εισάγεις όνομα χρήστη ή να επίλεξεις επίπεδο!");
                textBox1.Focus();
                return;
                
            }
            else
            {
                
                string x = comboBox1.SelectedItem.ToString();
                this.Hide();
                Form f2 = new Form2(x, textBox1.Text);//variable x will help us generate the level of difficulty in the second form and textbo1.text=username 
                f2.ShowDialog();
                
                
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the app
            Application.Exit();
        }
    }
    
}
