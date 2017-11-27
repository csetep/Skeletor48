namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;

            System.Console.WriteLine(a);

            int b = 100;
            b -= 7;

            System.Console.WriteLine(b);

            int c = 44;
            c *= 2;

            System.Console.WriteLine(c);

            int d = 125;
            d /= 5;

            System.Console.WriteLine(d);

            int e = 8;
            e *= e * e;

            System.Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;

            if (f1 > f2)
            {
                System.Console.WriteLine("It is " + true + " that f1 is bigger than f2!");
            }
            else
            {
                System.Console.WriteLine("It is " + false + " that f1 is bigger than f2!");
            }

            int g1 = 350;
            int g2 = 200;

            if ((2 * g2) > g1)
            {
                System.Console.WriteLine("It is " + true + " that g2x2 is bigger than g1!");
            }
            else
            {
                System.Console.WriteLine("It is " + false + " that g2x2 is bigger than g1!");
            }

            double h = 1357988018575474;
            double div = h % 11;

            if (div == 0)
            {
                System.Console.WriteLine("It is " + true + " that 11 is divisor of h.");
            }
            else
            {
                System.Console.WriteLine("It is " + false + " that 11 is divisor of h.");
            }

            int i1 = 10;
            int i2 = 3;
            double i2Squered = i2 * i2;
            double i2Cubed = i2 * i2 * i2;

            if (i1 > i2Squered && i1 < i2Cubed)
            {

                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }

            int j = 1521;

            if ((j % 3) == 0 || (j % 5) == 0)
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }

            string k = "Apple";

            for (int i = 0; i < 4; i = i + 1)
            {
                System.Console.WriteLine(k);
                System.Console.ReadKey();
            }
        }
    }      
}