using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n > 0 && n <= 64)
        {
            return (ulong)Math.Pow(2, n - 1);
        }
        else
        {
            throw new System.ArgumentOutOfRangeException();
        }
    }

    public static ulong Total()
    {
        ulong sum = 0;
        for (int i = 1; i < 64 + 1; i++)
        {
            sum += Square(i);
        }
        return sum;
    }
}