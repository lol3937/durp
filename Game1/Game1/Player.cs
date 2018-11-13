using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Player : Gubbe
    {
        Vector2 velocity = Vector2.Zero;
        float gravity = 9.82f;
        double width;
        double height;
        
        public Player()
        {
            Tex = Textfiler.Player;
            width = Tex.Width/10;
            height = Tex.Height/10;
            speed = 1;

        }
        public override void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                //velocity =
            }

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                velocity.Y = -10;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                velocity.X = -1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                velocity.X = 1;
            }

            velocity.Y += gravity * (1.0f / 60.0f);
            pos.Y += velocity.Y;
            pos.X += velocity.X * (float)speed;
                base.Update();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(folk, new Rectangle(pos.ToPoint(),new Point((int)width,(int)height)), Color.White);
        }
    }
}
