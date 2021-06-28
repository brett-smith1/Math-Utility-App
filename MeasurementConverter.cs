using System;

namespace Math_Utility_App
{
    class MeasurementConverter
    {
        public static void Menu(string userName)
        {
   
                Console.Clear();
                Console.WriteLine("\n\t      Measurement Converter\n==================================================");
                Console.WriteLine($"\n Welcome to the Measurement Converter {userName}.\n" +
                                  " Here you can convert different units of measurement.\n");
                Console.WriteLine(" Press \"Esc\" return to the Main Menu\n" +
                                  " Press any any other key to continue.");

                if (Console.ReadKey().Key == ConsoleKey.Escape) //If user pressed ESC, program skips to
                                                                //end of this Menu method and returns to Main Menu
                {  }
                else
                {
                    Console.Clear();
                    TypeMenu();
                }
        }

        public static void TypeMenu()
        {
            bool flag = true;

            while (flag)  //Allows user to continue repeating Conversions until they choose to return to Main Menu
            {
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
                        {
                            Console.Clear();
                            Temperature.Menu();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Distance.Menu();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Volume.Menu();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Weight.Menu();
                            break;
                        }
                    case "q":
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input. Please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                }
            }
        }
    }

    class Temperature
    {
        public static void Menu()
        {
            string input_unit;
            string output_unit;
            double temp;
            double new_temp;

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
                    {
                        input_unit = "Fahrenheit";
                        break;
                    }
                case "2":
                    {
                        input_unit = "Celcius";
                        break;
                    }
                case "3":
                    {
                        input_unit = "Kelvin";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                        Console.ReadKey();
                        Console.Clear();
                        goto InputUnit;
                    }
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
                    {
                        output_unit = "Fahrenheit";
                        break;
                    }
                case "2":
                    {
                        output_unit = "Celcius";
                        break;
                    }
                case "3":
                    {
                        output_unit = "Kelvin";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                        Console.ReadKey();
                        Console.Clear();
                        goto OutputUnit;
                    }
            }

            new_temp = (Conversion(input_unit, output_unit, temp));
            Console.WriteLine($"\n {temp} {input_unit} = {new_temp} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        public static double Conversion(string input, string output, double temp)
        {
            double temp_In_F;

            if (input == "Fahrenheit")
            {
                temp_In_F = temp;
            }
            else if (input == "Celcius")
            {
                temp_In_F = temp * 1.8 + 32;
            }
            else
            {
                temp_In_F = temp * 1.8 - 459.67;
            }

            if (output == "Fahrenheit")
            {
                return temp_In_F;
            }
            else if (output == "Celcius")
            {
                return (temp_In_F - 32) / 1.8;
            }
            else
            {
                return (temp_In_F - 32) / 1.8 + 273.15;
            }
        }
    }

    class Distance
    {

        public static void Menu()
        {
            string input_unit;
            string output_unit;
            double distance;
            double new_dist;
            string[] units = { "Miles", "Yards", "Feet", "Inches", "Kilometers", "Meters", "Centimeters", "Millimeters" };


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
                input_unit = units[(Convert.ToInt32(Console.ReadLine())-1)];
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
                output_unit = units[(Convert.ToInt32(Console.ReadLine())-1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto OutputUnit;
            }

            new_dist = (Conversion(input_unit, output_unit, distance));
            Console.WriteLine($"\n {distance} {input_unit} = {new_dist} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        
        public static double Conversion(string input, string output, double dist)
        {
            double dist_in_m;

            // Takes input distance and distance type and converts input to a common unit (meters)
            if (input == "Miles")
            {
                dist_in_m = dist * 1609.344;
            }
            else if (input == "Yards")
            {
                dist_in_m = dist * 0.9144;
            }
            else if (input == "Feet")
            {
                dist_in_m = dist * 0.3048;
            }
            else if (input == "Inches")
            {
                dist_in_m = dist * 0.0254;
            }
            else if (input == "Kilometers")
            {
                dist_in_m = dist * 1000;
            }
            else if (input == "Centimeters")
            {
                dist_in_m = dist * 0.01;
            }
            else if (input == "Millimeters")
            {
                dist_in_m = dist * 0.001;
            }
            else //input must == "Meters"
            {
                dist_in_m = dist;
            }


           //Takes common unit (meters) and converts to output unit type
            if (output == "Miles")
            {
                return dist_in_m  / 1609.344;
            }
            else if (output == "Yards")
            {
                return dist_in_m * 0.9144;
            }
            else if (output == "Feet")
            {
                return dist_in_m * 0.3048;
            }
            else if (output == "Inches")
            {
                return dist_in_m * 39.3700787;
            }
            else if (output == "Kilometers")
            {
                return dist_in_m / 1000;
            }
            else if (output == "Centimeters")
            {
                return dist_in_m * 100;
            }
            else if (output == "Millimeters")
            {
                return dist_in_m * 1000;
            }
            else //output must == "Meters"
            {
                return dist_in_m;
            }
        }
    }

    class Volume
    {
        public static void Menu()
        {
            string input_unit;
            string output_unit;
            double volume;
            double new_vol;
            string[] volumes = { "Gallon", "Quart", "Pint", "Cup", "Ounce", "Liter", "Milliliter" };
            int i = 1;

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

            new_vol = (Conversion(input_unit, output_unit, volume));
            Console.WriteLine($"\n {volume} {input_unit} = {new_vol} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        public static double Conversion(string input, string output, double vol)
        {
            //"Gallon", "Quart", "Pint", "Cup", "Ounce", "Liter", "Milliliter"
            double vol_in_oz;

            if (input == "Gallon")
            {
                vol_in_oz = vol * 128;
            }
            else if (input == "Quart")
            {
                vol_in_oz = vol * 32;
            }
            else if (input == "Pint")
            {
                vol_in_oz = vol * 16;
            }
            else if (input == "Cup")
            {
                vol_in_oz = vol * 8;
            }
            else if (input == "Liter")
            {
                vol_in_oz = vol * 33.814;
            }
            else if (input == "Milliliter")
            {
                vol_in_oz = vol / 29.5735;
            }
            else //input must == "Ounce"
            {
                vol_in_oz = vol;
            }

            if(output == "Gallon")
            {
                return vol_in_oz / 128;
            }
            else if (output == "Quart")
            {
                return vol_in_oz / 32;
            }
            else if (output == "Pint")
            {
                return vol_in_oz / 16;
            }
            else if (output == "Cup")
            {
                return vol_in_oz / 8;
            }
            else if (output == "Liter")
            {
                return vol_in_oz / 33.814;
            }
            else if (output == "Milliliter")
            {
                return vol_in_oz * 29.5735;
            }
            else //input must == "Ounce"
            {
                return vol_in_oz;
            }
        }
    }

    class Weight
    {
        public static void Menu()
        {
            string input_unit;
            string output_unit;
            double weight;
            double new_weight;
            string[] weights = { "Tons", "Pounds", "Ounces", "Kilograms", "Grams", "Stones" };
            int i = 1;
            
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
                input_unit = weights[(Convert.ToInt32(Console.ReadLine())-1)];
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
                output_unit = weights[(Convert.ToInt32(Console.ReadLine())-1)];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please try again...");
                Console.ReadKey();
                goto OutputUnit;
            }

            new_weight = (Conversion(input_unit, output_unit, weight));
            Console.WriteLine($"\n {weight} {input_unit} = {new_weight} {output_unit}");
            Console.ReadKey();
            Console.Clear();
        }

        public static double Conversion(string input, string output, double weight)
        {
           // "Tons", "Pounds", "Ounces", "Kilograms", "Grams", "Stones"
            double weight_in_lbs;

            if (input == "Tons")
            {
                weight_in_lbs = weight * 2240;
            }
            else if (input == "Ounces")
            {
                weight_in_lbs = weight / 16;
            }
            else if (input == "Kilograms")
            {
                weight_in_lbs = weight * 2.2046;
            }
            else if (input == "Grams")
            {
                weight_in_lbs = weight / 453.59327;
            }
            else if (input == "Stones")
            {
                weight_in_lbs = weight * 14;
            }
            else //input must == "Pounds"
            {
                weight_in_lbs = weight;
            }

            if (output == "Tons")
            {
                return weight_in_lbs / 2240;
            }
            else if (output == "Ounces")
            {
                return weight_in_lbs * 16;
            }
            else if (output == "Kilograms")
            {
                return weight_in_lbs / 2.2046;
            }
            else if (output == "Grams")
            {
                return weight_in_lbs * 453.59237;
            }
            else if (output == "Stones")
            {
                return weight_in_lbs / 14;
            }
            else //input must == "Pounds"
            {
                return weight_in_lbs;
            }
        }
    }

}
