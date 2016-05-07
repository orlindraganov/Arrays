using System;


class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] firstArray = new int[arraySize];
        int[] secondArray = new int[arraySize];

        bool areSame = true;

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
            if (firstArray[i] != secondArray[i])
            {
                areSame = false;
                break;
            }
        }
        Console.WriteLine(areSame ? "Equal" : "Not equal");
    }
}
