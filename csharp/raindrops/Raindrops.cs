using System;
using System.Collections.Generic;

public static class Raindrops
{
    public static string Convert (int number)
    {
        string str = "";
        for (int i = 3; i <= 7; i += 2)
        {
            if (number % i == 0)
            {
                if (i == 3)
                {
                    str += "Pling";
                }
                else if (i == 5)
                {
                    str += "Plang";
                }
                else if (i == 7)
                {
                    str += "Plong";
                }
            }
        }
        if (str.Equals (""))
        {
            str = number.ToString ();
        }
            return str;
    }
}