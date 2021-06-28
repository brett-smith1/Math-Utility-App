using System;
using System.IO;

namespace Math_Utility_App
{
    class Geometry
    {

        /*Geometry Menu welcomes user to section, provides a brief description,
          and gives option to return to Main Menu*/
        public static void Menu(string userName)
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
                CreateShape();
            }
 
        }

        //Create Shape Object
        public static void CreateShape()
        {
            bool flag = true;

            while (flag) //Allows user to continue with Geometry calculations until they choose to return to Main Menu
            {
                Console.Clear();
                Console.WriteLine("\n\t\tGeometry Calculator\n==================================================");
                Console.WriteLine("\n Please choose a shape from the following options: ");
                Console.WriteLine("\t" +
                    "1.) Rectangle\n\t" +
                    "2.) Square\n\t" +
                    "3.) Circle\n\t" +
                    "4.) Right Triangle\n\t" +
                    "Or press \"q\" to return to Main Menu");
                Console.Write(" Enter the number for your selection: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Rectangle.Create();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Square.Create();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Circle.Create();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Triangle.Create();
                            break;
                        }
                    case "q":
                        {
                            flag = false; // this will cause the While loop to end
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input. Please try again.");
                            Console.ReadKey();
                            continue;
                        }
                }
            }
        }

        //Prints .txt file for each shape type.
        public void PrintShape(string type)
        {
            string line;
            TextReader reader = new StreamReader($"{type}.txt");
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
        }

        public class Rectangle: Geometry
        {
            //Fields
            public double Length, Width;
            private readonly double Perimeter, Area;


            //Parametric Constructor
            public Rectangle(double length, double width)
            {
                this.Length = length;
                this.Width = width;
                this.Area = length * width;
                this.Perimeter = (length * 2) + (width * 2);
            }

            //Creating the rectangle object
            public static void Create()
            {
                double length;
                double width;

                Console.WriteLine("\n\t\tGeometry Calculator\n==================================================");

            InputLength:
                Console.Write("\n Please enter the length of your rectangle: ");
                try
                {
                    length = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Enter a valid length.");
                    goto InputLength;
                }

            InputWidth:
                Console.Write("\n Please enter the width of your rectangle: ");
                try
                {
                    width = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Enter a valid width.");
                    goto InputWidth;
                }

                Rectangle obj1 = new Rectangle(length, width);
                
                //Print object specifications to console
                Console.WriteLine("\n The dimensions of your rectangle are as follows:\n\t" +
                                  $" Length = {length}\n\t" +
                                  $" Width = {width}\n\t" +
                                  $" Perimeter = {obj1.Perimeter}\n\t" +
                                  $" Area = {obj1.Area}\n");

                obj1.PrintShape("Rectangle");

                Console.ReadKey();
            }
        }

        public class Square: Geometry
        {
            //Fields
            public double Side;
            private readonly double Area, Perimeter;

            //Constructor
            public Square(double side)
            {
                this.Side = side;
                this.Area = side * side;
                this.Perimeter = side * 4;
            }

            public static void Create()
            {
                double side;

                Console.WriteLine("\n\t\tGeometry Calculator\n==================================================");

            InputLength:
                Console.Write("\n Please enter the length of one side of your square: ");
                try
                {
                    side = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Enter a valid length.");
                    goto InputLength;
                }

                Square obj1 = new Square(side);
                Console.WriteLine("\n The dimensions of your square are as follows:\n\t" +
                                  $" Side = {side}\n\t" +
                                  $" Perimeter = {obj1.Perimeter}\n\t" +
                                  $" Area = {obj1.Area}\n");
                obj1.PrintShape("Square");
                Console.ReadKey();
            }

        }

        public class Circle: Geometry
        {
            public double Radius;
            private readonly double Circumference, Area;

            public Circle(double radius)
            {
                this.Radius = radius;
                this.Area = Math.PI * radius * radius;
                this.Circumference = 2 * Math.PI * radius;
            }

            public static void Create()
            {
                double radius;

                Console.WriteLine("\n\t\tGeometry Calculator\n==================================================");

            InputRadius:
                Console.Write("\n Please enter the radius of your circle: ");
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Enter a valid radius.");
                    goto InputRadius;
                }

                Circle obj1 = new Circle(radius);
                Console.WriteLine("\n The dimensions of your circle are as follows:\n\t" +
                                  $" Radius = {radius}\n\t" +
                                  $" Diameter = {radius * 2}\n\t" +
                                  $" Circumference = {obj1.Circumference}\n\t" +
                                  $" Area = {obj1.Circumference}\n");
                obj1.PrintShape("Circle");
                Console.ReadKey();
            }
        }

        public class Triangle: Geometry
        {
            public double Height, _Base;
            private readonly double Perimeter, Area;


            public Triangle(double height, double _base)
            {
                this.Height = height;
                this._Base = _base;
                this.Perimeter = _base + height + Math.Sqrt((height * height) + (_base * _base));
                this.Area = height * _base / 2;

            }

            public static void Create()
            {
                double height;
                double _base;

                Console.WriteLine("\n\t\tGeometry Calculator\n==================================================");

            InputHeight:
                Console.Write("\n Please enter the height of your right triangle: ");
                try
                {
                    height = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Enter a valid height.");
                    goto InputHeight;
                }

            InputBase:
                Console.Write("\n Please enter the base of your right triangle: ");
                try
                {
                    _base = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid input. Enter a valid base.");
                    goto InputBase;
                }

                Triangle obj1 = new Triangle(height, _base);
                Console.WriteLine("\n The dimensions of your right triangle are as follows:\n\t" +
                                  $" Height = {height}\n\t" +
                                  $" Base = {_base}\n\t" +
                                  $" Perimeter = {obj1.Perimeter}\n\t" +
                                  $" Area = {obj1.Area}\n");
                obj1.PrintShape("Triangle");
                Console.ReadKey();
            }
        }
    }
}

