using System;


class Program
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine().ToCharArray();
        char[] secondArray = Console.ReadLine().ToCharArray();

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine(firstArray.Length > secondArray.Length ? ">" : "<");
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine(firstArray[i] > secondArray[i] ? ">" : "<");
                    break;
                }
                else if (i == firstArray.Length - 1)
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
