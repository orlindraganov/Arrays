using System;

class BinarySearch
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] arrayToSearch = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            arrayToSearch[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayToSearch);
        int target = int.Parse(Console.ReadLine());
        int startIndex = 0;
        int endIndex = arraySize - 1;
        int midIndex = (endIndex - startIndex) / 2;
        int counter = 0;
        int result = -1;

        while (counter <= arraySize / 2)
        {
            if (arrayToSearch[midIndex] == target)
            {
                result = midIndex;
                break;
            }
            else if (arrayToSearch[midIndex] < target)
            {
                startIndex = midIndex + 1;
                midIndex = (endIndex + startIndex) / 2;
                counter++;
            }
            else
            {
                endIndex = midIndex - 1;
                midIndex = (startIndex + endIndex) / 2;
                counter++;
            }
        }
        Console.WriteLine(result);
    }
}