using System;


class MaxKSSum
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int elementsToSum = int.Parse(Console.ReadLine());
        int biggestSum = 0;

        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = arraySize - 1; i > arraySize - elementsToSum - 1; i--)
        {
            biggestSum += array[i];
        }
        Console.WriteLine(biggestSum);
    }
}
