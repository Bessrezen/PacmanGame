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
    public partial class Game : Form
    {
        public static GameBoard gameBoard = new GameBoard(); 

        public Game()
        {
            InitializeComponent();
        }

    }
}
