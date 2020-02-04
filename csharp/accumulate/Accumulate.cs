using System;
using System.Collections.Generic;
using System.Linq;

// Linq Solution

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        // Maps the operation to each element and returns the new collection
        return collection.Select(x => func(x));
    }
}