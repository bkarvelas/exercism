using System;

// One line solution

public static class TwoFer
{
    public static string Name(string input = null) => $"One for {(String.IsNullOrWhiteSpace(input) ? "you" : input)}, one for me.";
}