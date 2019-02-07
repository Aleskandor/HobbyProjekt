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
    public static class Utilities
    {
        public static GraphicsDeviceManager graphics;
        public static KeyboardState keyState, prevKeyState;
        public static MouseState mouseState, prevMouseState;
        public static SpriteBatch spriteBatch;
        public static Random randomizer;

        public static void Constructor(Game game)
        {
            graphics = new GraphicsDeviceManager(game);
            randomizer = new Random();
        }

        public static void LoadContent(GraphicsDevice graphicsDevice)
        {
            spriteBatch = new SpriteBatch(graphicsDevice);
        }

        public static void Update()
        {
            prevKeyState = keyState;
            keyState = Keyboard.GetState();

            prevMouseState = mouseState;
            mouseState = Mouse.GetState();
        }

        //-------------------------

        public static void SetWindowSize()
        {
            graphics.PreferredBackBufferHeight = Constants.windowHeight;
            graphics.PreferredBackBufferWidth = Constants.windowWidth;
            graphics.ApplyChanges();
        }
    }
}
