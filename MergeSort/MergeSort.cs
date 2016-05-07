using System;


class MergeSort
{

    public static int[] SplitArray(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;
        int[] leftArr = new int[middle];
        int[] rightArr = new int[arr.Length - middle];

        for (int i = 0; i < arr.Length; i++)
        {
            if (i < middle)
            {
                leftArr[i] = arr[i];
            }
            else
            {
                rightArr[i - middle] = arr[i];
            }
        }

        leftArr = SplitArray(leftArr);
        rightArr = SplitArray(rightArr);

        return MergeArrays(leftArr, rightArr);
    }

    public static int[] MergeArrays(int[] left, int[] right)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int[] arr = new int[left.Length + right.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (rightIndex == right.Length
            || (leftIndex < left.Length
            && left[leftIndex] <= right[rightIndex]))
            {
                arr[i] = left[leftIndex];
                leftIndex++;
            }
            else if (leftIndex == left.Length
            || (rightIndex < right.Length
            && right[rightIndex] <= left[leftIndex]))
            {
                arr[i] = right[rightIndex];
                rightIndex++;
            }
        }

        return arr;
    }




    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] mergeSort = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            mergeSort[i] = int.Parse(Console.ReadLine());
        }

        mergeSort = SplitArray(mergeSort);

        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine(mergeSort[i]);
        }


    }
}