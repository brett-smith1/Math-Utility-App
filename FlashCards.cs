using System;

namespace Math_Utility_App
{
    class FlashCards
    {
        public static void Menu(string userName)
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
                        {
                            Console.Clear();
                            FlashCards.Addition();
                            continue;
                        }
                    case "2":
                        {
                            Console.Clear();
                            FlashCards.Subtraction();
                            continue;
                        }
                    case "3":
                        {
                            Console.Clear();
                            FlashCards.Multiplication();
                            continue;
                        }
                    case "4":
                        {
                            Console.Clear();
                            FlashCards.Division(); ;
                            continue;
                        }
                    case "q":
                        {
                            Console.Clear();
                            flag = false;  //Will break the while loop.  User will be returned to Main Menu
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                        }
                }
            }
        }

        public static void Addition()
        {
            int upperLimit = 100;  //sets upper limit of random number
            int count = 0; //sets number of correct answers to zero

            Console.Clear();
            Console.WriteLine("\n\t    Flash Cards - Addition\n==================================================\n\t" +
                              " You will be given ten addition questions.  Answer them as quickly as possible.  \n" +
                              " Are you ready?\n\t" +
                              " Press any key to begin...");

            //Generate 10 mathematic problems
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("\n\t    Flash Cards - Addition\n==================================================");
                int num1 = 0;
                int num2 = 0;
                int answer;
                Random random = new Random();
                num1 = random.Next(0, upperLimit);
                num2 = random.Next(0, upperLimit);

                Console.Write($"\n\t{num1} + {num2} = ");

                //Use try and catch in case user input is not an integer
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    answer = -1;  //sets answer to -1 which will result in a Wrong answer
                }

                if (answer == num1 + num2)
                {
                    Console.WriteLine("\n\tCorrect!");
                    Console.ReadKey();
                    count += 1;
                }
                else
                {
                    Console.WriteLine("\n\tWrong!\n\t" +
                                      $"{num1} + {num2} = " + (num1 + num2));
                    Console.ReadKey();
                }
            }
            Console.WriteLine($"\n\tYou got {count} out of 10 correct!\n\n\tPress any key to return to the Flash Cards Menu...");
            Console.ReadKey();

        }

        public static void Subtraction()
        {
            int upperLimit = 100;
            int count = 0;
            Console.Clear();
            Console.WriteLine("\n\t    Flash Cards - Subtraction\n==================================================\n\t" +
                              " You will be given ten subtraction questions.  Answer them as quickly as possible.  Are you ready?\n\t" +
                              " Press any key to begin...");
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("\n\t    Flash Cards - Subtraction\n==================================================");
                int num1 = 0;
                int num2 = 0;
                int answer;
                Random random = new Random();
                num1 = random.Next(0, upperLimit);
                num2 = random.Next(num1, upperLimit);

                Console.Write($"\n\t{num2} - {num1} = ");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    answer = -1;
                }
                if (answer == num2 - num1)
                {
                    Console.WriteLine("\n\tCorrect!");
                    Console.ReadKey();
                    count += 1;
                }
                else
                {
                    Console.WriteLine("\n\tWrong!\n\t" +
                                      $"{num2} - {num1} = " + (num2 - num1));
                    Console.ReadKey();
                }
            }
            Console.WriteLine($"\n\tYou got {count} out of 10 correct!\n\n\tPress any key to return to the Flash Cards Menu...");
            Console.ReadKey();
        }

        public static void Multiplication()
        {
            int upperLimit = 20;
            int count = 0;
            int answer;
            Console.Clear();
            Console.WriteLine("\n\t    Flash Cards - Multiplication\n==================================================\n\t" +
                              " You will be given ten multiplication questions.  Answer them as quickly as possible.  Are you ready?\n\t" +
                              " Press any key to begin...");
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("\n\t    Flash Cards - Multiplication\n==================================================");
                int num1 = 0;
                int num2 = 0;
                Random random = new Random();
                num1 = random.Next(0, upperLimit);
                num2 = random.Next(0, upperLimit);

                Console.Write($"\n\t{num1} x {num2} = ");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    answer = -1;
                }
                if (answer == num1 * num2)
                {
                    Console.WriteLine("\n\tCorrect!");
                    Console.ReadKey();
                    count += 1;
                }
                else
                {
                    Console.WriteLine("\n\tWrong!\n\t" +
                                      $"{num1} * {num2} = " + (num1 * num2));
                    Console.ReadKey();
                }
            }
            Console.WriteLine($"\n\tYou got {count} out of 10 correct!\n\n\tPress any key to return to the Flash Cards Menu...");
            Console.ReadKey();
        }

        public static void Division()
        {
            int upperLimit = 100;
            int count = 0;
            int answer;
            Console.Clear();
            Console.WriteLine("\n\t    Flash Cards - Division\n==================================================\n\t" +
                              " You will be given ten division questions.  Divide to the nearest whole number. Answer them as quickly as possible.  Are you ready?\n\t" +
                              " Press any key to begin...");
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("\n\t    Flash Cards - Division\n==================================================\n" +
                                  " Remember to divide to the nearest whole number.\n");
                int num1 = 0;
                int num2 = 0;
                Random random = new Random();
                num1 = random.Next(1, upperLimit / 2);
                num2 = random.Next(num1, upperLimit);

                Console.Write($"\n\t{num2} / {num1} = ");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    answer = -1;
                }
                if (answer == num2 / num1)
                {
                    Console.WriteLine("\n\tCorrect!");
                    Console.ReadKey();
                    count += 1;
                }
                else
                {
                    Console.WriteLine("\n\tWrong!\n\t" + $"{num2} / {num1} = " + (num2 / num1));
                    Console.ReadKey();
                }
            }
            Console.WriteLine($"\n\tYou got {count} out of 10 correct!\n\n\tPress any key to return to the Flash Cards Menu...");
            Console.ReadKey();
        }
    }
}

