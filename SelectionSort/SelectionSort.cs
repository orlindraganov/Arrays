using System;



class SelectionSort
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}