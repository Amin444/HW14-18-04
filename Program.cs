using System;
using System.Collections.Generic;
namespace HW14_18_04
{
    class Program
    {
     delegate T del<T>(T A, T B);
        static void Main(string[] args)
        {
            bool work = true;
            while (work)
            {
                System.Console.WriteLine("Выберите операцию(*,/,+,-):");
                System.Console.WriteLine("1.умножения(*):");
                System.Console.WriteLine("2.деление(/):");
                System.Console.WriteLine("3.плюс(+):");
                System.Console.WriteLine("4.минус(-):");
                System.Console.WriteLine("5.Выход:");
                

                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":
                        {
                            System.Console.Write("Наберите число А: ");
                            double A= double.Parse(Console.ReadLine());
                            System.Console.Write("Наберите число В: ");
                            double B= double.Parse(Console.ReadLine());
                            del<double> mult = Multiply<double>;
                            double result = mult(A,B);
                            System.Console.WriteLine("======================");
                            System.Console.WriteLine($"ответ->{result}");
                            System.Console.WriteLine("======================");
                           
                            
                        };
                        break;

                    case "2":
                        {
                            System.Console.Write("Наберите число А");
                            double A= double.Parse(Console.ReadLine());
                            System.Console.Write("Наберите число В");
                            double B= double.Parse(Console.ReadLine());
                            if (A != 0 && A != 0)
                            {
                                del<double> div = Divide<double>;
                                double result = div(A,B);
                                
                                System.Console.WriteLine("======================");
                                System.Console.WriteLine($"ответ->{result}");
                                System.Console.WriteLine("======================");
                                
                            }
                            else
                            {
                                
                                System.Console.WriteLine("Error!!!");
                                
                            }

                        }; break;

                    case "3":
                        {
                            System.Console.Write("Наберите число А ");
                            double A= double.Parse(Console.ReadLine());
                            System.Console.Write("Наберите число В ");
                            double B= double.Parse(Console.ReadLine());
                            del<double> sum = Sum<double>;
                            double result = sum.Invoke(A, B);
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("======================");
                            System.Console.WriteLine($"ответ-> {result}");
                            System.Console.WriteLine("======================");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;

                    case "4":
                        {
                            System.Console.Write("Наберите число А ");
                            double A= double.Parse(Console.ReadLine());
                            System.Console.Write("Наберите число  ");
                            double B= double.Parse(Console.ReadLine());
                            del<double> min = Minus<double>;
                            double result = min.Invoke(A, B);
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("======================");
                            System.Console.WriteLine($"ответ-> {result}");
                            System.Console.WriteLine("======================");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;


                    case "5": work = false; break;

                    default:
                       
                        System.Console.WriteLine("======================");
                        Console.WriteLine("You are writed wrong number!!!");
                        System.Console.WriteLine("======================");
                        
                        break;
                }
            }
        }
        static T Multiply<T>(T A, T B)
        {

            return (dynamic)A * (dynamic)A;
        }
        static T Divide<T>(T A, T B)
        {

            return (dynamic)A / (dynamic)B;
        }
        static T Sum<T>(T A, T B)
        {
            return (dynamic)A + (dynamic)B;
        }

        static T Minus<T>(T A, T B)
        {
            return (dynamic)A - (dynamic)B;
        }
    }

}
