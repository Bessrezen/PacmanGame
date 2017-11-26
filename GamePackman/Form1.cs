using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePackman
{
    public partial class Pacman : Form
    {
        public Pacman()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 records = new Form2();
            records.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Game game = new Game();
            game.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }
    }
}
