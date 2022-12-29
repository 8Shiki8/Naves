using System;
using System.Collections.Generic;
using System.Text;

namespace Juego3
{
    public class Printer
    {
        
        public static void PrintAll(Player player, List<Enemy> lEnemy,string[]walls,List<Bullet>bullets)
        {
            string[] walls2 = walls;
            for (int i = 0; i < walls.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, i);
                Console.WriteLine(walls[i]);
            }
            for (int i = 0; i < bullets.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(bullets[i].x, bullets[i].y);
                Console.Write("|");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(player.x, player.y);
            Console.Write(player.PlayerChar);

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var elem in lEnemy)
            {
                Console.SetCursorPosition(elem.X, elem.Y);
                Console.Write(elem.enemyChar);
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(48, 2);
            Console.WriteLine(player.Score); 
            
           

                 

        }


        public static void PrintAll2(Player player, Enemy enemy, string[] walls)
        {
            for (int i = 0; i < walls.Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(walls[i]);
            }
            //Console.Clear();
            Console.SetCursorPosition(player.x, player.y);
            Console.Write(player.PlayerChar);
            Console.SetCursorPosition(enemy.X, enemy.Y);
            Console.Write(enemy.enemyChar);
        }

        public static void printEnemy(Enemy enemy,string[]walls,Player player,List<Bullet>bullets)
        {
         
            enemy.enemyStatus();
           
           

        }
        public static List<Bullet> printBullets(List<Bullet>bullets,List<Enemy>enemys,Player player)
        {
         
            List<Bullet> bullets2 = bullets;
            List<Enemy> enemys2 = enemys;
            for (int i = 0; i < bullets2.Count; i++)
            {
                bullets2[i].bulletStatus();
                if (bullets2[i].y == 0)
                {
                    bullets2.Remove(bullets2[i]);
                    break;
                    
                    
                }
                for (int i2 = 0; i2 < enemys2.Count; i2++)
                {
                    if (bullets2[i].x==enemys2[i2].X && bullets2[i].y == enemys2[i2].Y)
                    {
                        bullets2.Remove(bullets2[i]);
                        enemys2.Remove(enemys2[i2]);
                        player.Score = player.Score + 10;
                        break;
                    }
                }
                
            }

            bullets = bullets2;
            enemys = enemys2;

            return bullets2;
        }
        public static void PrintUI(string[] walls)
        {
            for (int i = 0; i < walls.Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(walls[i]);
            }
           
        }

        public static void canvasClear(Player player, Enemy enemy)
        {
            //(y1-15)(2-45)5
            for (int i = 1; i < 16; i++)
            {
                for (int i2 = 2; i2 < 45; i2++)
                {
                    
                        Console.SetCursorPosition(i2, i);
                        Console.Write(" ");
                    Console.SetCursorPosition(player.x, player.y);
                    Console.Write(player.PlayerChar);


                }
            }
        }
    }
}
