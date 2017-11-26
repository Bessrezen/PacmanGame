﻿using System;
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
    class PacmanPers
    {
        public PictureBox PacmanImage = new PictureBox();
        public ImageList PacmanImages = new ImageList();
        public int ImageOn = 0;

        public PacmanPers()
        {
            PacmanImages.Images.Add(Properties.Resources.Pacman_1_0);
            PacmanImages.ImageSize = new Size(27, 28);
        }
    }
}
