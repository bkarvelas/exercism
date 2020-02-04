using System.Text;

public static class ReverseString
{
    public static string Reverse(string word)
    {
        StringBuilder reversedWordStringBuilder = new StringBuilder();

        if (word.Length == 0)
        {
            return word;
        }

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWordStringBuilder.Append(word[i]);
        }

        return reversedWordStringBuilder.ToString();
    }
}