using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class Player
    {
        private int score=0;
        private string playerChar="A";
        private bool shoot = false;
        private List<Bullet> bullets = new List<Bullet>();
       
        
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public string PlayerChar
        {
            get { return playerChar; }
            set { playerChar=value; }
        }
        public List<Bullet> Bullets
        {
            get { return bullets; }
            set { bullets = value;}
        }
        public bool Shoot
        {
            get { return shoot;}
            set { shoot = value;}
        }
        public int x { get; set; }
        public int y { get; set; }
       
    }
}
