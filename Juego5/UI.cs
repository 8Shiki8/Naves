using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class UI
    {
        public string[] walls = { "████████████████████████████████████████████████████████████"
                                 ,"██                                           ██  SCORE    ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██  VIDAS    ██"
                                 ,"██                                           ██   ♥♥♥     ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"██                                           ██           ██"
                                 ,"████████████████████████████████████████████████████████████"};

        public bool ColisionUI( Player player)
        {
            if (walls[player.y][player.x].ToString() == "█")
            {
                return true;
            }
            return false;
        }
        public bool ColisionUI(Enemy enemy)
        {
            if (walls[enemy.Y][enemy.X].ToString() == "█")
            {
                return true;
            }
            return false;
        }


    }
}
