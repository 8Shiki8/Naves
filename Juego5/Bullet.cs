using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class Bullet
    {
        Player player;

        public Bullet bulletStatus()
        {
            y = y - 1;
            
            return this;
        }
        public int x { get; set; }
        public int y { get; set; }
        public Bullet(Player player)
        {
            this.player = player;
            x = player.x;
            y = player.y;
        }

    }
}
