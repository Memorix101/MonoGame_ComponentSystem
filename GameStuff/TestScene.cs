using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MemoEngine;

namespace MonoGame_Zombii
{
    class TestScene : Scene
    {
        OgmoLoader og;

        public TestScene()
        {
            og = new OgmoLoader();
            og.xmlLoader("Test");

            // tomato.AddComponent(new Player());
            // AddGameObject(tomato);
        }
    }
}
