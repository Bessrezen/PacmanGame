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
        public static PacmanPers pacman = new PacmanPers();

        public Game()
        {
            InitializeComponent();
            SetupGame(1);
        }

        public void SetupGame(int Level)
        {
            // Create Game Board
            gameBoard.CreateBoardImage(this, Level);

            //Create board Matrix
            Tuple<int, int> PacmanStartCoordinates = gameBoard.InitializeBoardMatrix(Level); 

            // Create Pacman
            pacman.CreatePacmanImage(this, PacmanStartCoordinates.Item1, PacmanStartCoordinates.Item2);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Up: pacman.nextDirection = 1; pacman.MovePacman(1); break;
                case Keys.Right: pacman.nextDirection = 2; pacman.MovePacman(2); break;
                case Keys.Down: pacman.nextDirection = 3; pacman.MovePacman(3); break;
                case Keys.Left: pacman.nextDirection = 4; pacman.MovePacman(4); break;
            }
        }


    }
}
