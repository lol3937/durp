using Microsoft.Xna.Framework;
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
        public Player()
        {
            Tex = Textfiler.Player;
            width = Tex.Width;
            height = tex.heigth;

        }
        public override void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                velocity = 20;
            }
            base.Update();
        }
    }
}
