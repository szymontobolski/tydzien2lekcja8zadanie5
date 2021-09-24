using System;

namespace tydzien2lekcja8zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
                do
            {
                Console.WriteLine($"{a*a*a}");
                a++;
                
            } while (a > 0 && a < 21);
        }
    }
}
