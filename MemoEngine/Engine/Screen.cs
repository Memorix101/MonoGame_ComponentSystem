using Microsoft.Xna.Framework;

namespace MemoEngine
{
    public class Screen
    {

        public static int width
        {
            get
            {
                return Setup.graphics.GraphicsDevice.Viewport.Width;
            }
        }

        public static int height
        {
            get
            {
                return Setup.graphics.GraphicsDevice.Viewport.Height;
            }
        }

        public static Rectangle bounds
        {
            get
            {
                return Setup.graphics.GraphicsDevice.Viewport.Bounds;
            }
        }

        public static bool fullScreen
        {
            set
            {
                Setup.graphics.IsFullScreen = value;
            }

        }

        public static void resolution(int width, int height)
        {
            Setup.graphics.PreferredBackBufferHeight = height;
            Setup.graphics.PreferredBackBufferWidth = width;
        }
       
            
    }
}
