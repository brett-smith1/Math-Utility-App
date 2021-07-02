using System;
using System.IO;

namespace Math_Utility_App
{
    class Menus
    {
        //Display Title Screen text file
        public static void TitleScreen()
        {
            Console.Clear();
            string line;
            TextReader reader = new StreamReader("TitleScreen.txt");
            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(line);
            }
            reader.Close();
            Console.WriteLine();
        }

        //Display Greeting and Show Menu Options
        public static void MainMenu(string userName)
        {
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t MAIN MENU\n==================================================\n");
                Console.WriteLine($"Welcome {userName}, please choose from the following options: ");
                Console.WriteLine("\t" +
                    "1.) Basic Calculator\n\t" +
                    "2.) Geometry Calculator\n\t" +
                    "3.) Measurement Converter\n\t" +
                    "4.) Flash Cards\n\t" +
                    "5.) Change Name\n\t" +
                    "Or press \"q\" to Exit");
                Console.Write(" Enter the number for your selection: ");

                //Receive user selection and call appropriate menu method

                switch (Console.ReadLine())
                {
                    case "1":
                        BasicCalcMenu(userName);
                        break;
                    case "2":
                        GeometryMenu(userName);
                        break;
                    case "3":
                        MeasurementMenu(userName);
                        break;
                    case "4":
                        FlashCardsMenu(userName);
                        break;
                    case "5":
                        userName = User.SetUser();
                        break;
                    case "q":
                        flag = false; //sets flag to false, and will break while loop, ending program.
                        break;

                    // Used to catch any user entry that does not match an option given.  Returns user top of menu.
                    default:
                        Console.WriteLine("You have entered an invalid response. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public static void BasicCalcMenu(string userName)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t Basic Calulator \n==================================================");
                Console.WriteLine($"\n Welcome to the Basic Calculator {userName}." +
                                  "\n Here you can calculate a mathematic expression between two numbers." +
                                  "\n For example: (1 + 5) or (2 * 6);\n\n");
                Console.WriteLine(" Press \"q\" to quit and return to the Main Menu\n" +
                                  " Press any any other key to continue.");

                //Breaks while loop and returns to MainMenu (calling function)
                if (Console.ReadLine() == "q")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    BasicCalculator.Calculate();
                    break;
                }
            }
        }
        public static void MeasurementMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine("\n\t      Measurement Converter\n==================================================");
            Console.WriteLine($"\n Welcome to the Measurement Converter {userName}.\n" +
                              " Here you can convert different units of measurement.\n");
            Console.WriteLine("Press any any other key to continue.");
            Console.ReadKey();


            bool flag = true;

            while (flag)  //Allows user to continue repeating Conversions until they choose to return to Main Menu
            {
                Console.Clear();
                Console.WriteLine("\n\t      Measurement Converter\n==================================================");
                Console.WriteLine("\n Please choose a measurement type from the following options: ");
                Console.WriteLine("\t" +
                    "1.) Temperature\n\t" +
                    "2.) Distance\n\t" +
                    "3.) Volume\n\t" +
                    "4.) Weight\n\t" +
                    "Or press \"q\" to return to Main Menu");
                Console.Write(" Enter the number for your selection: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        TempMenu();
                        break;
                    case "2":
                        DistanceMenu();
                        break;
                    case "3":
                        VolumeMenu();
                        break;
                    case "4":
                        WeightMenu();
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                }
            }
        }

        public static void TempMenu()
        {
            string input_unit;
            string output_unit;
            double temp;
            double new_temp;

            Console.Clear();
            InputUnit:
                Console.WriteLine("\n\t      Temperature Converter\n==================================================\n");
                Console.WriteLine(" Please choose the unit of measurement you are converting from: \n\t" +
                                    "1.) Fahrenheit\n\t" +
                                    "2.) Celcius\n\t" +
                                    "3.) Kelvin\n\t");
                Console.Write(" Enter the number for your selection: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        input_unit = "Fahrenheit";
                        break;
                    case "2":
                        input_unit = "Celcius";
                        break;
                    case "3":
                        input_unit = "Kelvin";
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Try again.");
                        Console.ReadKey();
                        Console.Clear();
                        goto InputUnit;
                }

            TempInput:
                Console.Write("\n Please Enter your temperature: ");
                try
                {
                    temp = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input.  Please Try Again.");
                    goto TempInput;
                }

            OutputUnit:
                Console.WriteLine("\n Please choose the unit of measurement you are converting to: \n\t" +
                                    "1.) Fahrenheit\n\t" +
                                    "2.) Celcius\n\t" +
                                    "3.) Kelvin\n\t");
                Console.Write(" Enter the number for your selection: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        output_unit = "Fahrenheit";
                        break;
                    case "2":
                        output_unit = "Celcius";
                        break;
                    case "3":
                        output_unit = "Kelvin";
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Try again.");
                        Console.ReadKey();
                        Console.Clear();
                        goto OutputUnit;
                }

                new_temp = (Temperature.Conversion(input_unit, output_unit, temp));
                Console.WriteLine($"\n {temp} {input_unit} = {new_temp} {output_unit}");
                Console.ReadKey();
                Console.Clear();
        }

        public static void DistanceMenu()
        {
            string input_unit;
            string output_unit;
            double distance;
            double new_dist;
            string[] units = { "Miles", "Yards", "Feet", "Inches", "Kilometers", "Meters", "Centimeters", "Millimeters" };

            Console.Clear();
            Console.WriteLine("\n\t      Distance Converter\n==================================================\n");
            Console.WriteLine(" Please choose the unit of measurement you are converting from: \t");

            //Uses a foreach loop and array to display options for units
            int i = 1;
            foreach (var item in units)
            {
                Console.WriteLine($"\t{i}.) {item}");
                i++;
            }

        InputUnit:
            Console.Write(" Enter the number for your selection: ");
            try
            {
                input_unit = units[(Convert.ToInt32(Console.ReadLine()) - 1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto InputUnit;
            }


        DistInput:
            Console.Write("\n Please Enter your distance: ");
            try
            {
                distance = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" Invalid input.  Please Try Again.");
                goto DistInput;
            }


            Console.WriteLine("\n Please choose the unit of measurement you are converting to: \t");
            i = 1;
            foreach (var item in units)
            {
                Console.WriteLine($"\t{i}.) {item}");
                i++;
            }
        OutputUnit:
            Console.Write(" Enter the number for your selection: ");
            try
            {
                output_unit = units[(Convert.ToInt32(Console.ReadLine()) - 1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto OutputUnit;
            }

            new_dist = (Distance.Conversion(input_unit, output_unit, distance));
            Console.WriteLine($"\n {distance} {input_unit} = {new_dist} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        public static void VolumeMenu()
        {
            string input_unit;
            string output_unit;
            double volume;
            double new_vol;
            string[] volumes = { "Gallon", "Quart", "Pint", "Cup", "Ounce", "Liter", "Milliliter" };
            int i = 1;

            Console.Clear();
            Console.WriteLine("\n\t      Volume Converter\n==================================================");
            Console.WriteLine(" Please choose the volume unit you are converting from: \t");

            foreach (var item in volumes)
            {
                Console.WriteLine($"\t{i}.) {item}");
                i++;
            }

        InputUnit:
            Console.Write(" Enter the number for your selection: ");
            try
            {
                input_unit = volumes[(Convert.ToInt32(Console.ReadLine()) - 1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto InputUnit;
            }

        VolumeInput:
            Console.Write("\n Please Enter the volume: ");
            try
            {
                volume = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" Invalid input.  Please Try Again.");
                goto VolumeInput;
            }

            Console.WriteLine(" Please choose the volume unit you are converting to \t");
            i = 1;
            foreach (var item in volumes)
            {
                Console.WriteLine($"\t{i}.) {item}");
                i++;
            }

        OutputUnit:
            Console.Write(" Enter the number for your selection: ");
            try
            {
                output_unit = volumes[(Convert.ToInt32(Console.ReadLine()) - 1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto OutputUnit;
            }

            new_vol = (Volume.Conversion(input_unit, output_unit, volume));
            Console.WriteLine($"\n {volume} {input_unit} = {new_vol} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        public static void WeightMenu()
        {
            string input_unit;
            string output_unit;
            double weight;
            double new_weight;
            string[] weights = { "Tons", "Pounds", "Ounces", "Kilograms", "Grams", "Stones" };
            int i = 1;

            Console.Clear();
            Console.WriteLine("\n\t      Weight Converter\n==================================================");
            Console.WriteLine(" Please choose the weight unit you are converting from: \t");

            foreach (var item in weights)
            {
                Console.WriteLine($"\t{i}.) {item}");
                i++;
            }

        InputUnit:
            Console.Write(" Enter the number for your selection: ");
            try
            {
                input_unit = weights[(Convert.ToInt32(Console.ReadLine()) - 1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto InputUnit;
            }

        WeightInput:
            Console.Write("\n Please Enter the weight: ");
            try
            {
                weight = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" Invalid input.  Please Try Again.");
                goto WeightInput;
            }

            Console.WriteLine(" Please choose the weight unit you are converting to \t");
            i = 1;
            foreach (var item in weights)
            {
                Console.WriteLine($"\t{i}.) {item}");
                i++;
            }

        OutputUnit:
            Console.Write(" Enter the number for your selection: ");
            try
            {
                output_unit = weights[(Convert.ToInt32(Console.ReadLine()) - 1)];
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto OutputUnit;
            }

            new_weight = (Weight.Conversion(input_unit, output_unit, weight));
            Console.WriteLine($"\n {weight} {input_unit} = {new_weight} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        public static void FlashCardsMenu(string userName)
        {
            bool flag = true;

            while (flag)  //Allows user to continue with Flash Cards until they choose to return to Main Menu
            {
                Console.Clear();
                Console.WriteLine("\n\t\t Flash Cards\n==================================================");
                Console.WriteLine($"\n Welcome to Flash Cards {userName}.\n" +
                                  " Here you will test your basic arithmetic skills.\n");
                Console.WriteLine(" Choose from one of the following options: \n\t" +
                                  " 1.) Addition\n\t" +
                                  " 2.) Subtraction\n\t" +
                                  " 3.) Multiplication\n\t" +
                                  " 4.) Division\n\t" +
                                  "Or press \"q\" to return to the Main Menu");
                Console.Write(" Enter the number for your selection: ");

                switch (Console.ReadLine())
                {
                    case "1":
                            Console.Clear();
                            FlashCards.Addition();
                            continue;
                    case "2":
                            Console.Clear();
                            FlashCards.Subtraction();
                            continue;
                    case "3":
                            Console.Clear();
                            FlashCards.Multiplication();
                            continue;
                    case "4":
                            Console.Clear();
                            FlashCards.Division(); ;
                            continue;
                    case "q":
                            Console.Clear();
                            flag = false;  //Will break the while loop.  User will be returned to Main Menu
                            break;
                    default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                }
            }
        }

        public static void GeometryMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine("\n\t\tGeometry Calculator\n==================================================");
            Console.WriteLine($"\n Welcome to the Geometry Calculator {userName}.\n" +
                                " Here you can find the perimeter and area of a basic geometric shape.\n" +
                                " You must provide the type and dimensions of the shape.\n");
            Console.WriteLine(" Press \"Esc\" return to the Main Menu\n" +
                                " Press any any other key to continue.");

            if (Console.ReadKey().Key == ConsoleKey.Escape) //Reads key input, if ESC, 
            { }
            else
            {
                Console.Clear();
                Geometry.CreateShape();
            }

        }
    }
}