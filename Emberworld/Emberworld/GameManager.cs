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
    class GameManager
    {
        WorldGenerator wg;

        public GameManager()
        {
            wg = new WorldGenerator();
        }

        public void Draw()
        {
            wg.Draw();
        }
    }
}
