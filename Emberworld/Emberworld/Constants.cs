using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberworld
{
    public static class Constants
    {
        public static int gridSizeX, gridSizeY, tileSize, windowHeight, windowWidth;

        public static void Initialize()
        {
            tileSize = 20;
            windowHeight = 900;
            windowWidth = 1600;
            Utilities.SetWindowSize();

            gridSizeX = windowWidth / tileSize;
            gridSizeY = windowHeight / tileSize;
        }

        //-------------------------

        public static void ChangeWindowSize(int X, int Y)
        {
            windowHeight = Y;
            windowWidth = X;

            Utilities.SetWindowSize();
        }
    }
}
