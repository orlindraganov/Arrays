using System;



class MaxIncSeq
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] arrayToTest = new int[arraySize];
        int currentSeq = 0;
        int maxSeq = 0;

        for (int i = 0; i < arraySize; i++)
        {
            arrayToTest[i] = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                currentSeq = 1;
                continue;
            }
            else if (arrayToTest[i] > arrayToTest[i - 1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }
            if (currentSeq > maxSeq)
            {
                maxSeq = currentSeq;
            }
        }
        Console.WriteLine(maxSeq);
    }
}
