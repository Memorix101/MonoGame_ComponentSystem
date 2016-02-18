using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MemoEngine;

namespace MonoGame_Zombii
{
    class TestScene : Scene
    {
        GameObject tomato = new GameObject();

        public TestScene()
        {
            tomato.AddComponent(new Player());
            AddGameObject(tomato);
        }
    }
}
