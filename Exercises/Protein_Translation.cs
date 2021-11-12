using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
    
       List<string> sentence = new List<string>();

        for (int i = 0; i < strand.Length /3 ; i++ )
        {
            string protein = ConvertToProtein(strand.Substring(i * 3, 3));

            if (protein == "STOP")
            {
                break;
            }

            sentence.Add(protein);
        }
        return sentence.ToArray();
        
        static string ConvertToProtein(string strandElement)
        {
            if (strandElement == "AUG")
            {
                return "Methionine";
            }
            else if (strandElement == "UUU" || strandElement == "UUC")
            {
                return "Phenylalanine";
            }
            else if (strandElement == "UUA" || strandElement == "UUG")
            {
                return "Leucine";
            }
            else if (strandElement == "UCU" || strandElement == "UCC" || strandElement == "UCA" || 
                 strandElement == "UCG")
            {
                return "Serine";
            }
            else if (strandElement == "UAU" || strandElement == "UAC")
            {
                return "Tyrosine";
            }
            else if (strandElement == "UGU" || strandElement == "UGC")
            {
                return "Cysteine";
            }
             else if (strandElement == "UGG")
            {
                return "Tryptophan";
            }
            else if (strandElement == "UAA" || strandElement == "UAG" || strandElement == "UGA")
            {
                return "STOP";
            }
            else
            {
                throw new Exception("Invalid sequence");
            }
        }
        
    }
}
