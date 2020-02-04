using System;
using System.Collections.Generic;

public static class SumOfMultiples {
    public static int Sum (IEnumerable<int> multiples, int max) {

        HashSet<int> h = new HashSet<int>();
        int result = 0;
        foreach (int i in multiples) 
        {
            for(int j = 0; j < max; j += i)
            {
                if(!h.Contains(j))
                {
                    h.Add(j);
                    result += j;
                }
            }
        }
        return result;
    }
}