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
    public class Apple
    {
        public PictureBox[,] FoodImage = new PictureBox[30,27];
        int count = 0;

        public void CreateAppleImages(Game form)
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (Game.gameBoard.Matrix[i, j] == 1 || Game.gameBoard.Matrix[i, j] == 2)
                    {
                        FoodImage[i, j] = new PictureBox();
                        FoodImage[i, j].Name = "AppleImage";
                        FoodImage[i, j].SizeMode = PictureBoxSizeMode.AutoSize;
                        FoodImage[i, j].Location = new Point(j * 16  - 1, i * 16 + 47);

                        if(Game.gameBoard.Matrix[i,j] == 1)
                        {
                            FoodImage[i, j].Image = Properties.Resources.Apple1;
                            count++;
                        }

                        if (Game.gameBoard.Matrix[i, j] == 2)
                        {
                            FoodImage[i, j].Image = Properties.Resources.Apple2;
                            count++;
                        }
                            form.Controls.Add(FoodImage[i, j]);
                        FoodImage[i, j].BringToFront();
                    }
                }
            }
        }

        public void EatApples(int i, int j)
        {
            //Eat apple
            FoodImage[i, j].Visible = false;
            Game.gameBoard.Matrix[i, j] = 0;
            count--;
            //if (count == 0) ; 
        }

        public void EatSuperApples(int i, int j)
        {
            FoodImage[i, j].Visible = false;
            Game.gameBoard.Matrix[i, j] = 0;
            count--;
        }
    }
}
