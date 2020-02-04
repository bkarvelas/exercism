using System;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if (nucleotide.Equals(""))
        {
            return "";
        }
        else
        {
            return string.Concat(nucleotide.Select(nuc => transcribeNucleotide(nuc)));
        }
    }

    private static char transcribeNucleotide(char nucleotide)
    {
        switch (nucleotide)
        {
            case 'C':
                return 'G';
            case 'G':
                return 'C';
            case 'T':
                return 'A';
            case 'A':
                return 'U';
            default:
                return '?';
        }
    }
}