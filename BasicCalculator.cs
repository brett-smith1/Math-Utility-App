using System;

namespace Math_Utility_App
{
    class BasicCalculator
    {
        public static void Menu(string userName)
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
                    Calculator();
                    break;
                }
            }
        }

        //Method to execute calculations
        public static void Calculator()
        {
            double num1;
            string op;
            double num2;
            bool flag = true;

            //Use a while statement to loop the calculator until the user chooses to quit
            while (flag)
            {
                Console.WriteLine("\n\t\t Basic Calulator \n==================================================\n");
            
                // Receive numbers and operator from user. Try and catch blocks to catch invalide entries and return
                // user to prevous input option
            FirstNumber:
                Console.Write(" Enter the first number: ");
                try
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Please enter a valid number.");
                    Console.ReadKey();
                    goto FirstNumber;
                }

            Operator:
                Console.Write(" Enter an operator (+, -, *, /): ");
                op = Console.ReadLine();

                // Boolean to evaluate if user input a valid operator
                if (op != "+" && op != "-" && op != "*" && op != "/")
                {
                    Console.WriteLine(" Invalid operator.  Please enter a valid operator.");
                    goto Operator;
                }

            SecondNumber:
                Console.Write(" Enter the second number: ");
                try
                {
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Please enter a valid number.");
                    Console.ReadKey();
                    goto SecondNumber;
                }

                //Calculate the equation depending on operator
                switch (op)
                {
                    case "+":
                        {
                            Console.WriteLine($" {num1} {op} {num2} = " + (num1 + num2));
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine($" {num1} {op} {num2} = " + (num1 - num2));
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine($" {num1} {op} {num2} = " + (num1 * num2));
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine($" {num1} {op} {num2} = " + (num1 / num2));
                            break;
                        }
                }

                //Give option to continue with another calculation, clear screen, or return to main menu
                Console.WriteLine("\n Press \"q\" to return to the Main Menu\n" +
                                  " Press \"c\" to clear the screen\n" +
                                  " Press any other key to do another calculation.");

                switch (Console.ReadLine())
                {
                    case "q":
                        {
                            flag = false;
                            break;
                        }
                    case "c":
                        {
                            Console.Clear();
                            continue;
                        }
                    default:
                        {
                            goto FirstNumber;
                        }
                }
            }
        }
    }
}
