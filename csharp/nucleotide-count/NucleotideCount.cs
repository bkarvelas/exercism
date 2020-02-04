using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IReadOnlyDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> nucleotideCounts;
        nucleotideCounts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        for (int i = 0; i < sequence.Length; i++)
        {
            if (nucleotideCounts.ContainsKey(sequence[i]))
            {
                nucleotideCounts[sequence[i]] += 1;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        return (IReadOnlyDictionary<char, int>)nucleotideCounts;
    }
}