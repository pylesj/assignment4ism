using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 0; i < 25; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }
                Console.WriteLine("The fibonacci number " + i.ToString() + " is : " + fibonacci[i].ToString());
            }

        }
    }
}

