using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToLower();

        if (String.IsNullOrEmpty(input))
        {
            return false;
        }
        else
        {
            int sumOfLetters = 0;

            for (char c = 'a'; c <= 'z'; c++)
            {
                foreach (char i in input)
                {
                    if (c == i)
                    {
                        sumOfLetters++;
                        break;
                    }
                }
            }
            return sumOfLetters == 26;
        }
    }
}