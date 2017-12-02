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
    class Apple
    {
        public PictureBox[,] FoodImage;

        public void CreateAppleImages(Game form)
        {
            for(int i = 0; i < 30; i++)
            {
                for(int j = 0; j < 27; j++)
                {
                    if(Game.gameBoard.Matrix[i,j] == 1)
                    {
                        FoodImage[i, j] = new PictureBox();
                        FoodImage[i, j].Name = "AppleImage";
                        FoodImage[i, j].SizeMode = PictureBoxSizeMode.AutoSize;
                        FoodImage[i, j].Location = new Point(i * 16 - 3, j * 16 + 43);

                        if(Game.gameBoard.Matrix[i,j] == 1)
                        {
                            FoodImage[i, j].Image = Properties.Resources.Apple1;

                        }
                    }
                }
            }
        }
    }
}
