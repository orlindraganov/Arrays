using System;



class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('a' + i);
        }

        string targetString = Console.ReadLine();

        int startIndex = 0;
        int endIndex = 25;
        int midIndex = (endIndex - startIndex) / 2;
        int counter = 0;

        foreach (char targetChar in targetString)
        {
            while (counter <= alphabet.Length / 2)
            {
                if (alphabet[midIndex] == targetChar)
                {
                    Console.WriteLine(midIndex);
                    break;
                }
                else if (alphabet[midIndex] < targetChar)
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
            counter = 0;
            startIndex = 0;
            endIndex = 25;
            midIndex = (endIndex - startIndex) / 2;
        }
    }
}
