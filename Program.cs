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

            //Displays TitleScreen
            Menus.TitleScreen();

            //Gets username
            string userName = User.SetUser();

            
            //All program function stems from Main Menu
            Menus.MainMenu(userName);


            //Display TitleScreen and closing message
            Menus.TitleScreen();
            Console.WriteLine("Thank you for using the MATH UTILITY APP!\n" +
                              "Goodbye!");

        }
    }
}
