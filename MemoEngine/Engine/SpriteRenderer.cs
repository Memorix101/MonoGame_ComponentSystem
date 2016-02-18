﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MemoEngine
{
    public class SpriteRenderer : GameObjectComponent
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

        public void Set(Sprite sprite)
        {
           
            _sprite = sprite;
            _transform =  sprite.gameObject.GetComponent<Transform>();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite.texture, _transform.position, _sprite.rect, Color.White, 0f, Vector2.Zero, _sprite.scale, flip, _sprite.layerDepth);
        }
    }
}
