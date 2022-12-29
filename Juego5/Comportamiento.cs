using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class Comportamiento
    {
        public static List<Bullet> Colision(List<Bullet>bullets,List<Enemy>enemys,int puntaje)
        {
            List<Bullet> bullets2 = bullets;
            List<Enemy> enemys2 = enemys;



            if (bullets.Count > 0)
            {
                for (int i = 0; i < bullets2.Count; i++)
                {
                    for (int i2 = 0; i2 < enemys2.Count; i2++)
                    {
                        if (bullets2[i].x == enemys2[i2].X && bullets2[i].x == enemys2[i2].X)
                        {
                            bullets2.Remove(bullets[i]);
                            enemys2.Remove(enemys[i2]);
                            puntaje = puntaje + 10;
                        }
                    }
                }
                bullets = bullets2;
                enemys = enemys2;
            }
            return bullets2;
        }
    }
}
