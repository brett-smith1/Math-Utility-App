using System;

namespace Math_Utility_App
{
    class MainMenu
    {
        //MainMenu Display
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t MAIN MENU \n==================================================");
        }

        //Get User name
        public static string UserName()
        {
            Console.Write("\n Please Enter your Name: "); 
            string userName = Console.ReadLine();
           
            //
            if (userName == "")
            {
                userName = "Guest";
            }
            return userName;
        }

        //Display Greeting and Show Menu Options
        public static void MenuOptions(string userName)
        {
            MenuOptions:
            Console.Clear();
            Display();
            Console.WriteLine($"\n Welcome {userName}, please choose from the following options: ");
            Console.WriteLine("\t" +
                "1.) Basic Calculator\n\t" +
                "2.) Geometry Calculator\n\t" +
                "3.) Measurement Converter\n\t" +
                "4.) Flash Cards\n\t" +
                "5.) Change Name\n\t" +
                "Or press \"q\" to Exit");
            Console.Write(" Enter the number for your selection: ");

            //Receive user selection and call appropriate method

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        BasicCalculator.Menu(userName);
                        goto MenuOptions;
                    }
                case "2":
                    {
                        Geometry.Menu(userName);
                        goto MenuOptions;
                    }
                case "3":
                    {
                        MeasurementConverter.Menu(userName);
                        goto MenuOptions;
                    }
                case "4":
                    {
                        FlashCards.Menu(userName);
                        goto MenuOptions;
                    }
                case "5":
                    {
                        userName = UserName();
                        goto MenuOptions;
                    }
                case "q":
                    {
                        break;
                    }

                    // Used to catch any user entry that does not match an option given.  Returns user top of menu.
                default:
                    {
                        Console.WriteLine("You have entered an invalid response. Please try again.");
                        Console.ReadKey();
                        goto MenuOptions;
                    }
            }
        }
    }
}
