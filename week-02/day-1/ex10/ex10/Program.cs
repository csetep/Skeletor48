using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Misi";
            int MyAge = 33;
            double MyHeight = 1.94;
            bool married = true;

            Console.WriteLine(MyName);
            Console.WriteLine(MyAge);
            Console.WriteLine(MyHeight);

            if (married == true)
            {
                Console.WriteLine("married");
            }
            Console.ReadLine();
        }


    }
}

