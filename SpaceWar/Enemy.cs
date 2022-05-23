using System;
using System.Threading;

namespace SpaceWar
{
    public class Enemy
    {
        static public int x = 40;
        static public int y = 5;
        static public bool stop = true;
        static public bool right = false;
        static Timer t;

        public static void SettingEnemy()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("######");

        }

        public static void EnemySpeed(int s)
        {
            while (stop)
            {
                t = new Timer(MoveEnemy, null, 0, s);
                Console.ReadLine();
            }

        }

        public void CreatingEnemy()
        {
            //KeyboardController.UpdateScreen();
            SettingEnemy();
            EnemySpeed(100);

        }

        public static void MoveEnemy(object o)
        {
            if (x < 51 && right == false)
            {
                x++;
                SettingEnemy();
                if (x == 50)
                {
                    right = true;
                }
            }if (right)
            {
                x--;
                SettingEnemy();
                if (x == 0)
                {
                    right = false;
                }
            }
            else
            {
                stop = false;
            }
        }
    }
}
