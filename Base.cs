using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    abstract class Base
    {
        protected Texture2D image;
        protected Color color = Color.White;  //Set the image color white to make it transparent
        public Vector2 Position,Velocity;
        public float Orientation;
        public float Radius = 20;  //Radius is used to detect collisions around
        public bool IsDead;  // Checks whether the player is dead or alive


        public Vector2 Size
        {
            get
            {
        return image == null ? Vector2.Zero : new Vector2(image.Width, image.Height);
            }
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, Position, null, color, Orientation, Size / 2f, 1f, 0, 0);

        }
    }
}
