using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame_Zombii.Engine;

namespace MonoGame_Zombii.Engine
{
    class SpriteRenderer : GameObjectComponent
    {
        private Sprite _sprite;
        private Transform _transform;
        public SpriteEffects flip = SpriteEffects.None;

        /*
        public SpriteRenderer(GameObject go)
        {
            _sprite = go.GetComponent<Sprite>();
            _transform = go.GetComponent<Transform>();
        }
        */

        public void Set(Sprite sprite, Transform transform)
        {
            _sprite = sprite;
            _transform = transform;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite.texture, _transform.position, _sprite.rect, Color.White, 0f, Vector2.Zero, _sprite.scale, flip, _sprite.layerDepth);
        }
    }
}
