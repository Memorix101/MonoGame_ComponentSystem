using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Zombii.Engine
{
    static class SceneManager
    {

        static List<Scene> loadedScene= new List<Scene>();
        static List<Scene> deletedScene = new List<Scene>();
        static List<Scene> activeScene = new List<Scene>();

        static Scene lastScene;

        public static void LoadScene(Scene scene)
        {
            if (lastScene != null)
            {
                deletedScene.Add(lastScene);
            }

            loadedScene.Add(scene);
            
            lastScene = scene;
        }

        public static void Update(GameTime gameTime)
        {
            
            foreach (var s in loadedScene)
            {
                activeScene.Add(s);
            }

            loadedScene.Clear();

            foreach (var s in deletedScene)
            {
                activeScene.Remove(s);
            }

            deletedScene.Clear();

            foreach (var s in activeScene)
            {
                s.Update(gameTime);
            }
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var s in activeScene)
            {
                s.Draw(spriteBatch);
            }
        }
    }
}
