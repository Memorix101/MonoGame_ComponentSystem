using Microsoft.Xna.Framework;

namespace MonoGame_Zombii.Engine
{
    class Screen
    {

        static GraphicsDeviceManager graphics = Game1.graphics;

        public static int width
        {
            get
            {
                return graphics.GraphicsDevice.Viewport.Width;
            }
        }

        public static int height
        {
            get
            {
                return graphics.GraphicsDevice.Viewport.Height;
            }
        }

        public static Rectangle bounds
        {
            get
            {
                return graphics.GraphicsDevice.Viewport.Bounds;
            }
        }

        public static bool fullScreen
        {
            set
            {
                graphics.IsFullScreen = value;
            }

        }

        public static void resolution(int width, int height)
        {
            graphics.PreferredBackBufferHeight = height;
            graphics.PreferredBackBufferWidth = width;
        }
       
            
    }
}
