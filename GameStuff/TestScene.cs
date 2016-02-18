using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame_Zombii.Engine;

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
