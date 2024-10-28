using System.Security.Cryptography.X509Certificates;

namespace FourDotFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n;
            Console.WriteLine("Fermat's Last Theorum holds that there are no integers a, b, and c such that:");
            Console.WriteLine("\t\ta^n + b^n = c^n.");
            Console.WriteLine("except for when n=2\n");

            Console.WriteLine("Let's test it!\n");

            Console.WriteLine("Please enter an integer for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter an integer for b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter an integer for c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter an integer for n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (CheckFermat(a, b, c, n) == 0)
            {
                Console.WriteLine("Holy smokes, Fermat was wrong!");
            }
            else if (CheckFermat(a, b, c, n) == 1)
            {
                Console.WriteLine("Seems like Fermat was right.");
            }
            else if (CheckFermat(a, b, c, n) == 2)
            {
                Console.WriteLine("Hmmmm...something went wrong.");
            }
        }

        public static int CheckFermat(int a, int b, int c, int n)
        {
            double newA = Math.Pow(a, n);
            double newB = Math.Pow(b, n);
            double newC = Math.Pow(c, n) ;

            Console.WriteLine($"{a}^{n} = " + newA);

            Console.WriteLine($"{b}^{n} = " + newB);

            Console.WriteLine($"{c}^{n} = " + newC);

            Console.WriteLine($"{newA}(a) + {newB}(b) = {newC}(c)");

            if ((newC == (newA + newB)) && n != 2)
            {
                return 0;
            }
            else if ((newC != newA + newB) && n !=2)
            {
                return 1;
            }
            else return 2;
        }
    }
}
