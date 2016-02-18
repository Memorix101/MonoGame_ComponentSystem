using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame_Zombii.Engine;

namespace MonoGame_Zombii
{
    class AnotherOne : Scene
    {
        GameObject player = new GameObject();

        public AnotherOne()
        {
            player.AddComponent(new Tomato());
            AddGameObject(player);
        }
    }
}
