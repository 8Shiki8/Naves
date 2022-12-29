using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using Juego3;

namespace Juego5
{
    class Program
    {
        public static ConsoleKeyInfo tecla2;
        static void Main(string[] args)
        {

            //COMENTARIO 1 MASTER 
            //comentario 2 master
            //comentario rama1
            // coemntario 2 rama1
            Console.SetWindowSize(62, 20);
            Console.SetBufferSize(62, 20);
            Console.CursorVisible = false;

            List<Enemy> listaEnemy = CreaEnemigos();
            //var timer = new Timer(80);
            //timer.Elapsed += (sender, obj) => GuardaTecla();
            //timer.Start();
            Enemy enemy = new Enemy(3, 1);
            IAEnemy iaenemy = new IAEnemy();
            Player player = new Player();
            Control control = new Control(player,enemy);
            UI ui = new UI();
            player.x = 24;
            player.y = 15;
            ConsoleKeyInfo tecla;
            
            while (true)
            {
                if (Console.KeyAvailable == true)
                {
                    tecla = Console.ReadKey();
                    control.RespuestaControl(tecla);
                    //Printer.PrintAll(player, listaEnemy, ui.walls,player.Bullets);
                }
                iaenemy.EnemyStatus(listaEnemy);
                Printer.printBullets(player.Bullets,listaEnemy,player);
                Printer.PrintAll(player, listaEnemy, ui.walls, player.Bullets);

                Thread.Sleep(60);

            }

        }

        public static void GuardaTecla()
        {
            tecla2=Console.ReadKey();
           
        }

        

        public static List<Enemy> CreaEnemigos()
        {
            int x = 12;
            int y = 1;
            List<Enemy> lEnemy = new List<Enemy>();
            for (int i = 0; i < 3;i++)
            {
                for (int i2=0;i2<20;i2++)
                {
                    lEnemy.Add(new Enemy(x + i2, y + i));
                }
            }
            return lEnemy;
        }
    }
}
