using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Zombii.Engine
{
    class Transform : GameObjectComponent
    {

        public Vector2 position = Vector2.Zero;
        
        public void Move(float x, float y)
        {
            position.X = position.X + x;
            position.Y = position.Y + y;
        }
    }
}
