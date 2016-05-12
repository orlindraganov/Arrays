using System;



class PrimeNumbers
{
    static void Main()
    {
        int max = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[max + 1];
        for (int i = 2; i <= max; i++)
        {
            isPrime[i] = true;
        }

        //foreach (bool toPrint in isPrime)
        //{
        //    Console.WriteLine(toPrint);
        //}

        for (int i = 2; i <= max; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * 2; j <= max; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        while (!isPrime[max])
        {
            max--;
        }
        Console.WriteLine(max);
    }
}
