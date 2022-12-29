using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class Control
    {
        public Player player;
        public Enemy enemy;
        public UI ui = new UI();
        public Player RespuestaControl(ConsoleKeyInfo tecla)
        {
            if (ConsoleKey.UpArrow==tecla.Key)
            {
                return player;
            }
            if (ConsoleKey.DownArrow==tecla.Key)
            {
                return player;
            }

            if (ConsoleKey.LeftArrow==tecla.Key)
            {
                
                player.x = player.x - 1;
                if (ui.ColisionUI(player) == true)
                {
                    player.x = player.x + 1;
                    
                    return player;
                }

            }

            if (ConsoleKey.RightArrow==tecla.Key)
            {
                
                player.x = player.x + 1;
                if (ui.ColisionUI( player) == true)
                {
                    player.x = player.x - 1;
                    return player;
                }
                
               
            }
            if (ConsoleKey.Spacebar == tecla.Key)
            {
                player.Shoot = true;
                player.Bullets.Add(new Bullet(player));
                return player;
            }
            
            return player;
        }


        public Control(Player player, Enemy enemy)
        { 
            this.player = player;
            this.enemy = enemy;
        }
    }
}

