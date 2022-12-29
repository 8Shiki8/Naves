using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class Enemy
    {
        public string enemyChar = "O";
        public UI userInt = new UI();

        bool right = false;
        bool left = false;
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Enemy(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Enemy enemyStatus()
        {
            
            if(right==false)
            {
               X=X+1;
                if (userInt.ColisionUI(this))
                {
                    right = true;

                    X = X - 1;
                    return this;
                }
                return this;
            }
            if (left == false)
            {
                X = X - 1;
                if (userInt.ColisionUI(this))
                {
                    left = true;

                    X = X + 1;
                    return this;
                }
            }

            if (right == true && left == true)
            {
                right = false;
                left = false;
                Y = Y + 1;
            }
            return this;
        }
    }

}
