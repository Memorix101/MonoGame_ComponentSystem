using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Zombii.Engine
{
    static class SceneManager
    {

        static List<Scene> sceneList = new List<Scene>();

        public static void LoadScene(Scene scene)
        {
            if (sceneList != null)
                sceneList.Clear();

            sceneList.Add(scene);
        }

        public static void Update(GameTime gameTime)
        {
            foreach (var s in sceneList)
                s.Update(gameTime);
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var s in sceneList)
                s.Draw(spriteBatch);
        }
    }
}
