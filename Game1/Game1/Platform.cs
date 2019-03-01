using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Platform
    {
        protected Texture2D tex;
        protected Vector2 pos;
        protected Rectangle hitbox;

        public Texture2D Tex
        {
            get;
            private set; 
        }

        public Vector2 Pos
        {
            get;
            private set;
        }

        public Rectangle Hitbox
        {
            get;
            private set;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, pos, Color.White);
        }

        public Platform(Texture2D t, Vector2 p, Rectangle h)
        {
            tex = t;
            pos = p;
            hitbox = h;
        }
    }
}
