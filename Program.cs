using System;

namespace Math_Utility_App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Set title of the Console
            Console.Title = "Math Utility";

            //Set Color of text and console background
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;

            //Enter MainMenu
            MainMenu.Display();
            string userName = MainMenu.UserName();
            MainMenu.MenuOptions(userName);

        }
    }
}
