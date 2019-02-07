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
    abstract class Block
    {
        protected Vector2 pos;
        protected Texture2D tex;
        protected Rectangle hitbox;

        protected Block(Vector2 p)
        {
            pos = p;
            hitbox = new Rectangle((int)pos.X, (int)pos.Y, Constants.tileSize, Constants.tileSize);
        }

        public virtual void Draw()
        {
            Utilities.spriteBatch.Draw(tex, hitbox, Color.White);
        }
    }
}
