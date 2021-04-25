using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] output = input.ToCharArray();
        Array.Reverse( output );
        string revertedString = string.Join("", output);
        return revertedString;
    }
}