using System;
using Microsoft.Xna.Framework;


namespace MemoEngine
{
    public class RectCollider : GameObjectComponent
    {

        Rectangle _rect;
        Sprite _sprite;
        Transform _transform;
        
        /*
        public RectCollider (Sprite sprite, Transform transform)
        {
            _sprite = sprite;
            _transform = transform;
        }
        */

        public void Set (Sprite sprite, Transform transform)
        {
            _sprite = sprite;
            _transform = transform;
        }

        public Rectangle TextureBoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)_transform.position.X,
                    (int)_transform.position.Y,
                    _sprite.texture.Width,
                    _sprite.texture.Height);
            }
        }

        public Rectangle RectBoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)_transform.position.X,
                    (int)_transform.position.Y,
                    _sprite.rect.Width,
                    _sprite.rect.Height);
            }
        }

        /*
        public bool OnRectCollsion(RectCollider me, RectCollider other)
        {
            if (me.RectBoundingBox.Intersects(other.RectBoundingBox))
            {
                return true;
            }

            return false;
        }

        public bool OnTextureCollsion(RectCollider me, RectCollider other)
        {
            if (me.TextureBoundingBox.Intersects(other.TextureBoundingBox))
            {
                return true;
            }

            return false;
        }

        */
    }
}
