using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Emberworld
{
    public static class Textures
    {
        public static Texture2D dirt, grass, stone, water;

        public static void LoadContent(ContentManager content)
        {
            dirt = content.Load<Texture2D>("dirt_block");
            grass = content.Load<Texture2D>("grass_block");
            stone = content.Load<Texture2D>("stone_block");
            water = content.Load<Texture2D>("water_block");
        }
    }
}
