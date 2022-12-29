using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    class IAEnemy
    {
        public UI userInt = new UI();
        bool right = false;
        bool left = false;

        public void EnemyStatus(List<Enemy>lEnemy)
        {
          
            if (right == false)
            {
                foreach (var item in lEnemy)
                {
                   item.X = item.X + 1;
                   if (userInt.ColisionUI(item))
                   {
                      right = true;
                   }
                }

            }

            if (left==false&&right==true)
            {
                foreach (var item in lEnemy)
                {
                    item.X = item.X - 1;
                    if (userInt.ColisionUI(item))
                    {   
                        left = true;
                    }

                    
                }
            }
         

            if (right == true && left == true)
            {
                foreach (var item in lEnemy)
                {
                    item.Y = item.Y + 1;
                    item.X = item.X + 1;

                }
                right = false;
                left = false;
            }

        }
    }
}
