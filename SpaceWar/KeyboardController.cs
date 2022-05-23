using System;
namespace SpaceWar
{
    public class KeyboardController
    {
        static public int y = 3;
        static public int x = 2;

        public static void SettingPlayer()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("-");

        }

        public static void MovingArrow()
        {
            ConsoleKeyInfo KeyPressed;
            KeyPressed = Console.ReadKey();

            if (KeyPressed.Key == ConsoleKey.LeftArrow )
            {
                x--;
                UpdateScreen();
            }

            else if (KeyPressed.Key == ConsoleKey.RightArrow)
            {
                x++;
                UpdateScreen();
            }

        }

        public static void UpdateScreen()
        {
            Console.Clear();
            Enemy.SettingEnemy();
            SettingPlayer();
            
            MovingArrow();
        }

    }
}