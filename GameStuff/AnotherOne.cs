using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MemoEngine;

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
