using System;
using System.Collections.Generic;
namespace HW14_18_04
{
    class Program
    {
       delegate T Operation<T>(T x, T y);
        static void Main(string[] args)
        {
            bool sss = true;
            while (sss)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("Choose your operations(*,/,+,-):");
                System.Console.WriteLine("1.Multiply(*):");
                System.Console.WriteLine("2.Divide(/):");
                System.Console.WriteLine("3.Add(+):");
                System.Console.WriteLine("4.Minus(-):");
                System.Console.WriteLine("5.Exit:");
                Console.ForegroundColor = ConsoleColor.White;

                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":
                        {
                            System.Console.Write("Enter your first number: ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.Write("Enter your second number: ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Operation<double> mult = Multiply<double>;
                            double result = mult.Invoke(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("======================");
                            System.Console.WriteLine($"Result is:{result}");
                            System.Console.WriteLine("======================");
                            Console.ForegroundColor = ConsoleColor.White;
                        };
                        break;

                    case "2":
                        {
                            System.Console.Write("Enter your first number:");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.Write("Enter your second number:");
                            double y = Convert.ToDouble(Console.ReadLine());
                            if (x != 0 && y != 0)
                            {
                                Operation<double> div = Divide<double>;
                                double result = div.Invoke(x, y);
                                Console.ForegroundColor = ConsoleColor.Green;
                                System.Console.WriteLine("======================");
                                System.Console.WriteLine($"Result is:{result}");
                                System.Console.WriteLine("======================");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.WriteLine("======================");
                                Console.WriteLine("You are writed wrong number, 0 can't divide any number!!!");
                                System.Console.WriteLine("======================");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }; break;

                    case "3":
                        {
                            System.Console.Write("Enter your first number: ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.Write("Enter your second number: ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Operation<double> sum = Sum<double>;
                            double result = sum.Invoke(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("======================");
                            System.Console.WriteLine($"Result is: {result}");
                            System.Console.WriteLine("======================");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;

                    case "4":
                        {
                            System.Console.Write("Enter your first number: ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.Write("Enter your second number: ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Operation<double> min = Minus<double>;
                            double result = min.Invoke(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("======================");
                            System.Console.WriteLine($"Result is: {result}");
                            System.Console.WriteLine("======================");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;


                    case "5": sss = false; break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("======================");
                        Console.WriteLine("You are writed wrong number!!!");
                        System.Console.WriteLine("======================");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
        static T Multiply<T>(T x, T y)
        {

            return (dynamic)x * (dynamic)y;
        }
        static T Divide<T>(T x, T y)
        {

            return (dynamic)x / (dynamic)y;
        }
        static T Sum<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }

        static T Minus<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;
        }
    }

}
