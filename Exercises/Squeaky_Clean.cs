using System;
using System.Text;
using System.Collections.Generic;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var afterCorrections = new StringBuilder();
        var searchCtr = new StringBuilder();
        bool toUpper = false;
        List<char> greekSymbols = new List<char>() {'β', 'ι', 'ε', 'γ', 'τ', 'ω'};
        foreach (char letter in identifier ) 
        {
            if (letter.Equals(' '))
            {
                afterCorrections.Append('_');
            }
            else if (letter.Equals('-'))
            {
                toUpper = true;
            }
            else if (toUpper)
            {
                afterCorrections.Append(char.ToUpper(letter));
                toUpper = false;
            }
            else if ((int)letter > 10000)
            {
                continue;
            }
            else if (greekSymbols.Contains(letter))
            {
                continue;
            }
            else if (char.IsDigit(letter))
            {
                continue;
            }
            else
            {
                afterCorrections.Append(letter);
            }
        }
        if (identifier.Contains("\0"))
        {
            afterCorrections.Replace("\0", "CTRL");
        }
        return afterCorrections.ToString();
    }
}
