using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Welcome to the equation calculator. Please, select problem to be solved.");
            Console.WriteLine("Is it a linear equation with a single argument? (y/n)");
            answer=Console.ReadLine();
            if (answer == "y")
            {
              Console.WriteLine("This program figures out a solution for a linear equation for you."); // Word 'of' instead of 'for' is also OK, but 'for' is somewhat cooler.
                Console.Write("k=");
                double k = Convert.ToDouble(Console.ReadLine());
                Console.Write("m=");
                double m = Convert.ToDouble(Console.ReadLine());
                double x1 = (-m) / k;
                Console.WriteLine("x1=" + x1);
            }
            else if (answer == "n")
            {
                Console.WriteLine("Is it a squared equation?");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("This program figures out solutions for a squared equation for you.");
                    Console.Write("a=");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b=");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c=");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double d = b * b / (4 * a * c);
                    double x1 = -b + Math.Sqrt(d) / 2 * a;
                    double x2 = -b - Math.Sqrt(d) / 2 * a;
                    Console.WriteLine("x1=" + x1 + ", x2=" + x2);
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Does it have 3 degrees?");
                    answer = Console.ReadLine();
                    if (answer == "y") {
                        Console.Write("a=");
                        int a =Convert.ToInt32(Console.ReadLine());
                        Console.Write("b=");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("c=");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("d=");
                        int d = Convert.ToInt32(Console.ReadLine());

                        int n = -d;
                        int z=1;
                        while (n <= d)
                        {
                            if ((a * n ^ 3 + b * n ^ 2 + c * n + d) == 0) {
                                Console.WriteLine("x" + z + "=" + n);
                                z++;
                            }
                            n++;
                        }
                        if (z == 1) Console.WriteLine("I'm sorry, it's hard for me.");
                    }
                    else if (answer == "n")
                    {

                    }
                    else Console.WriteLine("Ooooops! I don't understand you :'("); // Why Thou [hast] copied the same message for three times?
                }
                else Console.WriteLine("Ooooops! I don't understand you :'(");
            }
            else Console.WriteLine("Ooooops! I don't understand you :'(");
        }
    }
}
