using System;

class Combinations
{
    static void Main()
    {
            Console.Write("Positive int < 100: ");
            byte n = byte.Parse(Console.ReadLine());
            Console.Write("Positive int < N: ");
            byte k = byte.Parse(Console.ReadLine());

            double a = 1,b=1;
            for (byte i = 2; i <= n-k; i++)
            {
                a *= i;
            }

            k++;
            for (byte i = k; i <= n ; i++)
            {
                b *= i;
            }
            Console.WriteLine("The answer is: " + b/a);
    }
}
