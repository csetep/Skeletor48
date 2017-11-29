using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How many girls came? ");
            int girls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" How many boys came? ");
            int boys = Convert.ToInt32(Console.ReadLine());

            int attendes = girls + boys;
            int idealMinimum = 20;

            if (girls == boys && attendes >= idealMinimum)
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (girls != boys && attendes >= idealMinimum && girls != 0)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (attendes < idealMinimum && girls != 0)
            {
                Console.WriteLine("Average party...");
            }
            else if (girls <= 0 && boys != 0)
            {
                Console.WriteLine("Sausage party :( ");
            }
            else
            {
                Console.WriteLine("meh.....");
            }
            Console.ReadKey();
        }
    }
}