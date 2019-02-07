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
    public class Game1 : Game
    {
        GameManager gm;
        
        public Game1()
        {
            Utilities.Constructor(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            Constants.Initialize();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Utilities.LoadContent(GraphicsDevice);
            Textures.LoadContent(Content);
            gm = new GameManager();
        }

        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Utilities.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            Utilities.spriteBatch.Begin();
            gm.Draw();
            Utilities.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
