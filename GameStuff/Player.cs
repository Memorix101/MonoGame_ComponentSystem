using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MemoEngine;

namespace MonoGame_Zombii
{
    class Player : GameObjectComponent
    {
        float speed = 150f;
        KeyboardState keyState;
        
        public Player()
        {          
 
        }

        public override void Init()
        {
            Sprite sprite = new Sprite();
            gameObject.AddComponent(sprite);

            gameObject.GetComponent<Sprite>().Load("Sprites/MainGuySpriteSheet_0");
            gameObject.GetComponent<Sprite>().scale = 2;
            gameObject.GetComponent<Sprite>().layerDepth = 1f;
            gameObject.GetComponent<Sprite>().rect = new Rectangle(46, 0, 32, 36);

            Transform transform = new Transform();
            gameObject.AddComponent(transform);
            gameObject.GetComponent<Transform>().position = new Vector2(Screen.width / 2 - gameObject.GetComponent<Sprite>().rect.Width, Screen.height / 2 - gameObject.GetComponent<Sprite>().rect.Height);

            RectCollider collider = new RectCollider();
            gameObject.AddComponent(collider);
            gameObject.GetComponent<RectCollider>().Set(gameObject.GetComponent<Sprite>(), gameObject.GetComponent<Transform>());

            SpriteRenderer render = new SpriteRenderer();
            gameObject.AddComponent(render);
            gameObject.GetComponent<SpriteRenderer>().Set(gameObject.GetComponent<Sprite>());
        }

        public override void Update(GameTime gameTime)
        {
            //movex = transform.position.X -= 25 * gameTime.DeltaTime();


            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                gameObject.GetComponent<Transform>().Move(-speed * gameTime.DeltaTime(), 0);

           else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                gameObject.GetComponent<Transform>().Move(speed * gameTime.DeltaTime(), 0);

           else if (Keyboard.GetState().IsKeyDown(Keys.Down))
                gameObject.GetComponent<Transform>().Move(0, speed * gameTime.DeltaTime());

           else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                gameObject.GetComponent<Transform>().Move(0, -speed * gameTime.DeltaTime());

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !keyState.IsKeyDown(Keys.Space))
            {
                GameObject tomato = new GameObject();
                tomato.AddComponent(new Tomato());
                tomato.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                GameObject.Instantiate(tomato);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Q) && !keyState.IsKeyDown(Keys.Q))
            {
                SceneManager.LoadScene(new AnotherOne());
            }

            keyState = Keyboard.GetState();


            gameObject.GetComponent<Transform>().position.Y = MathHelper.Clamp(gameObject.GetComponent<Transform>().position.Y, 0, Screen.bounds.Height - gameObject.GetComponent<Sprite>().rect.Height * gameObject.GetComponent<Sprite>().scale);
            gameObject.GetComponent<Transform>().position.X = MathHelper.Clamp(gameObject.GetComponent<Transform>().position.X, 0, Screen.bounds.Width - gameObject.GetComponent<Sprite>().rect.Width * gameObject.GetComponent<Sprite>().scale);
        }

    }
}
