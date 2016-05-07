using System;



class MaximalSequence
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] arrayToTest = new int[arraySize];
        int currentSeq = 1;
        int maxSeq = 1;
        arrayToTest[0] = int.Parse(Console.ReadLine());
        for (int i = 1; i < arraySize; i++)
        {
            arrayToTest[i] = int.Parse(Console.ReadLine());
            if (arrayToTest[i] == arrayToTest[i - 1])
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
