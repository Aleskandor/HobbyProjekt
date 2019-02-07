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
    class StoneBlock : Block
    {
        public StoneBlock(Vector2 p)
            : base(p)
        {
            tex = Textures.stone;
        }
    }
}
