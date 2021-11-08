using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] reversearray = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char temp = input[(input.Length - 1) - i];
            reversearray[i] = temp;
        }
        string reverseString = new string(reversearray);
        return reverseString;
    }
}
