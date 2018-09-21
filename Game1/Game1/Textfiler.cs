using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    static class Textfiler
    {
        public static Texture2D Player;

        public static void Load(ContentManager manager)
        {
            Player = manager.Load<Texture2D>("");
        }
    }
}
