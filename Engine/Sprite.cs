using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Zombii.Engine
{
    class Sprite : GameObjectComponent
    {
        public Texture2D texture;
        public Vector2 origin = Vector2.Zero;
        public Rectangle rect;
        public Rectangle sourceRect;
        public Color color = Color.White;
        public float rotation = 0f;
        public float layerDepth = 0f;
        public int scale = 1;
                
        public Sprite()
        {

        } 

        public void Load(string path)
        {
            texture = Game1.content.Load<Texture2D>(path);
        }

    }
}
