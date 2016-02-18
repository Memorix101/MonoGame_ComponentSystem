using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MemoEngine;

namespace MonoGame_Zombii
{
    class Tomato : GameObjectComponent
    {
        float speed = 150f;
        float movex;

        public Tomato()
        {

        }

        public override void Init()
        {
            Sprite sprite = new Sprite();
            gameObject.AddComponent(sprite);
            gameObject.GetComponent<Sprite>().Load("Sprites/tomatoes01");
            gameObject.GetComponent<Sprite>().scale = 1;
            gameObject.GetComponent<Sprite>().layerDepth = 0f;
            gameObject.GetComponent<Sprite>().rect = new Rectangle(0, 50, 50, 45);

            Transform transform = new Transform();
            gameObject.AddComponent(transform);
            gameObject.GetComponent<Transform>().position = new Vector2(Screen.width / 2 - gameObject.GetComponent<Sprite>().rect.Width, Screen.height / 2 - gameObject.GetComponent<Sprite>().rect.Height);

            RectCollider collider = new RectCollider();
            gameObject.AddComponent(collider);
            gameObject.GetComponent<RectCollider>().Set(gameObject.GetComponent<Sprite>(), gameObject.GetComponent<Transform>());

            SpriteRenderer render = new SpriteRenderer();
            gameObject.AddComponent(render);
            gameObject.GetComponent<SpriteRenderer>().Set(gameObject.GetComponent<Sprite>(), gameObject.GetComponent<Transform>());

        }

        public override void Update(GameTime gameTime)
        {
            movex = gameObject.GetComponent<Transform>().position.X -= 25 * gameTime.DeltaTime();
        }
    }
}
