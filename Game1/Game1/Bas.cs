using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Bas
    {
        protected Vector2 pos;
        protected Texture2D folk;

        public virtual void Update() { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(folk, pos, Color.White);
        }

        public Texture2D Tex
        {
            get { return folk; }
            set { folk = value; }
        }

        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }
    }
}
