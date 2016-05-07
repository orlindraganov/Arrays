using System;


class FreqNumber
{
    static void Main(string[] args)
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] freqArray = new int[arraySize];

        int currentCount = 1;
        int maxCount = 0;
        int maxCountedNumber = 0;

        for (int i = 0; i < arraySize; i++)
        {
            freqArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(freqArray);

        for (int i = 0; i < arraySize - 1; i++)
        {
            if (freqArray[i] == freqArray[i+1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxCountedNumber = freqArray[i];
            }
        }
        Console.WriteLine("{0} ({1} times)",maxCountedNumber ,maxCount);
    }
}
