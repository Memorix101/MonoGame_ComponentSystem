using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MemoEngine;

namespace MemoEngine
{
    class Tile : GameObjectComponent
    {

        float pos_X;
        float pos_Y;
        int rect_X;
        int rect_Y;

        public Tile(float x, float y, int rx, int ry)
        {
            pos_X = x;
            pos_Y = y;
            rect_X = rx;
            rect_Y = ry;
        }

        public override void Init()
        {
            Sprite sprite = new Sprite();
            gameObject.AddComponent(sprite);
            gameObject.GetComponent<Sprite>().Load("Sprites/plowed_soil");
            gameObject.GetComponent<Sprite>().scale = 1;

            gameObject.GetComponent<Sprite>().rect = new Rectangle(rect_X, rect_Y, 32, 32);
            Transform transform = new Transform();
            gameObject.AddComponent(transform);
            gameObject.GetComponent<Transform>().position = new Vector2(pos_X, pos_Y);

            /*
            RectCollider collider = new RectCollider();
            gameObject.AddComponent(collider);
            gameObject.GetComponent<RectCollider>().Set(gameObject.GetComponent<Sprite>(), gameObject.GetComponent<Transform>());
            */

            SpriteRenderer render = new SpriteRenderer();
            gameObject.AddComponent(render);
            gameObject.GetComponent<SpriteRenderer>().layer = 0;
            gameObject.GetComponent<SpriteRenderer>().Set(gameObject.GetComponent<Sprite>());

        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}
