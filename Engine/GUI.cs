using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGame_Zombii.Engine
{
    class GUI
    {

        SpriteFont font;
        string text;
        Vector2 position;
        Color color = Color.White;

        public GUI (string t)
        {
            text = t;
        }

        public void Text(string t)
        {
            text = t;
        }

        public Color Color
        {
            set
            {
                color = value;
            }

            get
            {
                return color;
            }
        }

        public Vector2 Position
        {
            set
            {
                position = value;
            }

            get
            {
                return position;
            }
        }

        public Vector2 Size
        {
            get
            {
                return font.MeasureString(text);
            }
        }

        public void Load(string path)
        {
            font = Game1.content.Load<SpriteFont>(path);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, text, position, color);
        }
    }
}
