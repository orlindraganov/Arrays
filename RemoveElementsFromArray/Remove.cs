using System;


class RemoveElements
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());

        int[] arr = new int[arrSize];
        int[] helper = new int[arrSize];
        int maxLength = 1;

        for (int i = 0; i < arrSize; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            helper[i] = 1;
        }

        for (int i = 1; i < arrSize; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[j] <= arr[i]
                    && helper[j] + 1 >= helper[i])
                {
                    helper[i] = helper[j] + 1;
                }
                if (helper[i] > maxLength)
                {
                    maxLength = helper[i];
                }
            }
        }
        Console.WriteLine(arrSize - maxLength);

    }
}
