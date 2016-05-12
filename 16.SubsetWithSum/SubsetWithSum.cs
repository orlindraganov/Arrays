using System;



class Subset
{

    static void Main()
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 77;
        bool isSum = false;
        int length = arr.Length;

        for (int i = 1; i < (int)Math.Pow(2, length); i++)
        {
            long currentSum = 0;

            for (int j = 0; j < length; j++)
            {
                int mask = 1 << j;
                int bit = (mask & i) >> j;

                if (bit == 1)
                {
                    currentSum += arr[j];
                }
            }

            if (currentSum == sum)
            {
                isSum = true;
                break;
            }
        }

        Console.WriteLine(isSum ? "yes" : "no");
    }
}
