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
    public class PacmanPers
    {
        public int currentDirection = 0;
        public int nextDirection = 0;
        private int xStart = 0;
        private int yStart = 0;
        public int coordinateX = 0;
        public int coordinateY = 0;
        private PictureBox PacmanImage = new PictureBox();
        private ImageList PacmanImages = new ImageList();
        public int ImageOn = 0;
        public Timer timer = new Timer();

        public PacmanPers()
        {
            timer.Interval = 150;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            PacmanImages.Images.Add(Properties.Resources.Pacman_1_0);
            PacmanImages.Images.Add(Properties.Resources.Pacman_1_1);
            PacmanImages.Images.Add(Properties.Resources.Pacman_1_2);
            PacmanImages.Images.Add(Properties.Resources.Pacman_1_3);

            PacmanImages.Images.Add(Properties.Resources.Pacman_2_0);
            PacmanImages.Images.Add(Properties.Resources.Pacman_2_1);
            PacmanImages.Images.Add(Properties.Resources.Pacman_2_2);
            PacmanImages.Images.Add(Properties.Resources.Pacman_2_3);

            PacmanImages.Images.Add(Properties.Resources.Pacman_3_0); 
            PacmanImages.Images.Add(Properties.Resources.Pacman_3_1);
            PacmanImages.Images.Add(Properties.Resources.Pacman_3_2);
            PacmanImages.Images.Add(Properties.Resources.Pacman_3_3);

            PacmanImages.Images.Add(Properties.Resources.Pacman_4_0);
            PacmanImages.Images.Add(Properties.Resources.Pacman_4_1);
            PacmanImages.Images.Add(Properties.Resources.Pacman_4_2);
            PacmanImages.Images.Add(Properties.Resources.Pacman_4_3);

            PacmanImages.ImageSize = new Size(27, 28);
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            MovePacman(currentDirection);
        }

        public void CreatePacmanImage(Game form, int coordinateX, int coordinateY)
        {
            //Create Pacman image
            xStart = coordinateX;
            yStart = coordinateY;
            PacmanImage.Name = "PacmanImage";
            PacmanImage.SizeMode = PictureBoxSizeMode.AutoSize;
            SetPacman();
            form.Controls.Add(PacmanImage);
            PacmanImage.BringToFront();
        }

        public void SetPacman()
        {
            // Place pacman in board
            PacmanImage.Image = Properties.Resources.Pacman_2_1;
            currentDirection = 0;
            nextDirection = 0;
            coordinateX = xStart;
            coordinateY = yStart;
            PacmanImage.Location = new Point(xStart * 16 - 3 , yStart * 16 + 43);
        }

        public void MovePacman(int direction)
        {
            // Move Pacman
            bool CanMove = CheckDirection(nextDirection);
            if (!CanMove)
            {
                CanMove = CheckDirection(currentDirection);
                direction = currentDirection;
            }
            else { direction = nextDirection; }

            if (CanMove) { currentDirection = direction; }

            if (CanMove)
            {
                switch (direction)
                {
                    case 1: PacmanImage.Top -= 16; coordinateY--; break;
                    case 2: PacmanImage.Left += 16; coordinateX++; break;
                    case 3: PacmanImage.Top += 16; coordinateY++; break;
                    case 4: PacmanImage.Left -= 16; coordinateX--; break;
                }
                currentDirection = direction;
                UpdateImage();
               // CheckPacmanPosition();
                //Game.ghost.CheckForPacman();
            }

        }

        public bool CheckDirection(int Direction)
        {
            //Check if Pacman can move
            switch (Direction)
            {
                case 1: return DirectionOk(coordinateX, coordinateY - 1);
                case 2: return DirectionOk(coordinateX + 1, coordinateY);
                case 3: return DirectionOk(coordinateX, coordinateY + 1);
                case 4: return DirectionOk(coordinateX - 1, coordinateY);
                default: return false;
            }
        }

        public bool DirectionOk(int x, int y)
        {
            // Check if board space can be used
            if (x < 0)
            {
                coordinateX = 27;
                PacmanImage.Left = 429;
                return true;
            }
            if (x > 27)
            {   coordinateX = 0;
                PacmanImage.Left = -5;
                return true;
            }
            if (Game.gameBoard.Matrix[y, x] < 3)
            { return true; }
            else { return false; }
        }

        public void UpdateImage()
        {
            PacmanImage.Image = PacmanImages.Images[((currentDirection - 1) * 4) + ImageOn];
            ImageOn++;
            if (ImageOn > 3) { ImageOn = 0; }
        }
    }
}
