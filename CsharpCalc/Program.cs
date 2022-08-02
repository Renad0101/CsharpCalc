using System;
using System.Text;


namespace CalcHomework
{
    enum Operators { Add = 1, Multi, Devide, Subtract, Exit, }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t\t Welcome to the Calculator Program");


            bool start = true;

            while (start)
            {
                float a, b, sum = 0;
                int x;

                Console.WriteLine("1--Add\n2--Multi\n3--Devide\n4--Subtract:");
                int.TryParse(Console.ReadLine(), out x);

                Console.WriteLine("Enter the first Number:");
                float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Enter the second Number:");
                float.TryParse(Console.ReadLine(), out b);

                Console.Clear();

                switch ((Operators)x)
                {
                    case Operators.Multi:
                        {
                            sum = Mult(a, b);
                            Console.WriteLine($"\nResult:{a}*{b}={sum}\n\n");
                            break;
                        }


                    case Operators.Devide:
                        {
                            sum = Divide(a, b);
                            Console.WriteLine($"\nResult:{a}/{b}={sum}\n\n");
                            break;
                        }

                    case Operators.Add:
                        {
                            sum = Add(a, b);
                            Console.WriteLine($"\nSum:{a}+{b}={sum}\n\n");
                            break;
                        }

                    case Operators.Subtract:
                        sum = Subt(a, b);
                        Console.WriteLine($"\nResult:{a}-{b}={sum}\n\n");
                        break;


                    case Operators.Exit:
                        start = false;
                        break;


                    default:
                        Console.WriteLine("\n theese choices have already exist!!!");
                        break;
                }

            }

            static float Mult(float a, float b)
            {
                float sum = (a * b);
                return sum;
            }

            static float Divide(float a, float b)
            {
                float sum = 0;
                if (b is 0)
                    Console.WriteLine("it does not aloow to devide zero!!");

                else
                    sum = (a / b);
                return sum;
            }


            static float Add(float a, float b)
            {
                float sum = (a + b);

                return sum;
            }



            static float Subt(float a, float b)
            {
                float sum = (a - b);
                return sum;

            }
        }
    }
}