using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToUpper();
        bool pengram = true;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char letter in alphabet)
        {
            if (input.Contains(letter) || letter == ' ' ||letter == '_' )
            {
                pengram = true;
            }
            else
            {
                pengram = false;
                break;
            }
        }
        return pengram;
    }
}
