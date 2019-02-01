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
            windowHeight = 1600;
            windowWidth = 900;

            gridSizeX = windowWidth / tileSize;
            gridSizeY = windowHeight / tileSize;
        }
    }
}
