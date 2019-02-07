using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Emberworld
{
    class WorldGenerator
    {
        Block[,] blocks;
        int i;

        public WorldGenerator()
        {
            blocks = new Block[Constants.windowWidth / Constants.tileSize, Constants.windowHeight / Constants.tileSize];
            Generate();
        }

        public void Generate()
        {
            for (int y = 0; y < blocks.GetLength(1); y++)
            {
                for (int x = 0; x < blocks.GetLength(0); x++)
                {
                    if(y >= (blocks.GetLength(1) / 4))
                    {
                        i = Utilities.randomizer.Next(0, y - (blocks.GetLength(1) / 4));
                        if (blocks[x, y - 1] == null)
                            blocks[x, y] = new GrassBlock(new Vector2(x * Constants.tileSize, y * Constants.tileSize));
                        else if (y < blocks.GetLength(1) / 1.5 && (i == 0 || i == 1))
                            blocks[x, y] = new DirtBlock(new Vector2(x * Constants.tileSize, y * Constants.tileSize));
                        else 
                            blocks[x, y] = new StoneBlock(new Vector2(x * Constants.tileSize, y * Constants.tileSize));
                    }
                }
            }
        }

        public void Draw()
        {
            for (int y = 0; y < blocks.GetLength(1); y++)
            {
                for (int x = 0; x < blocks.GetLength(0); x++)
                {
                    if (blocks[x, y] != null)
                    blocks[x, y].Draw();
                }
            }
        }
    }
}