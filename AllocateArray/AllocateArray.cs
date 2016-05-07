using System;


class AllocateArray
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];

        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}
