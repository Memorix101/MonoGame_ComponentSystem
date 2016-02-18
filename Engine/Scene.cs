using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Zombii.Engine
{
     class Scene
    {
       private List<GameObject> _GO = new List<GameObject>();
       public static List<GameObject> _AddedGO = new List<GameObject>();
       public static List<GameObject> _RemoveGO = new List<GameObject>();

        public void AddGameObject(GameObject gameObject)
        {
            _GO.Add(gameObject);
        }

        public void Update(GameTime gameTime)
        {
            foreach(GameObject go in _AddedGO)
            {
                _GO.Add(go);              
            }

            _AddedGO.Clear();

            foreach (GameObject go in _RemoveGO)
            {
                _GO.Remove(go);
            }

            _RemoveGO.Clear();

            foreach (GameObject go in _GO)
            {
                go.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject go in _GO)
            {
                go.GetComponent<SpriteRenderer>().Draw(spriteBatch);               
            }
        }

    }
}
