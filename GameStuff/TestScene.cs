using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame_Zombii.Engine;

namespace MonoGame_Zombii
{
    class TestScene : Scene
    {
        GameObject player = new GameObject();

        public TestScene()
        {
            player.AddComponent(new Player());
            AddGameObject(player);
        }
    }
}
