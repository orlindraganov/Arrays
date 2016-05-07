using System;


class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        int currentSum = 0;
        int maxSum = int.MinValue;


        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

            currentSum += array[i];

            //If the sum is less than the array member, I'd rather start over
            if (currentSum < array[i])
            {
                currentSum = array[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine(maxSum);
    }
}