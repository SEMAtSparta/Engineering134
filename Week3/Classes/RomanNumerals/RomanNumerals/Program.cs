using System.Collections.Generic;

namespace RomanNumerals;

public class Program
{
    static void Main(string[] args)
    {
    }

    public static string ConvertIntToRomanNumerals(int input)
    {
        int currentTotal = input;
        int[] dictionaryIndex = { 1, 5, 10, 50, 100, 500, 1000 };
        string outputString = "";
        var numeralLookup = new Dictionary<int, char>()
        {
            {1, 'I' },
            {5, 'V' },
            {10, 'X' },
            {50, 'L' },
            {100, 'C' },
            {500, 'D' },
            {1000, 'M' }
        };
        while(currentTotal > 0)
        {
            for (int i = 0; i < dictionaryIndex.Length; i++)
            {
                int currentNumber = dictionaryIndex[i];
                if (currentTotal >= currentNumber)
                {
                    continue;
                }
                if(
                    //prevent 4x repetition of numerals
                    currentTotal >= dictionaryIndex[i-1] * 4
                    ||
                    //special case to prevent 2x repetition
                    (dictionaryIndex[i - 1] == 5 || dictionaryIndex[i-1] == 50 || dictionaryIndex[i-1] == 500) 
                    && 
                    (currentNumber - currentTotal <= dictionaryIndex[i-2])
                    )
                {
                    char largestNumeral;
                    char smallerNumeral;
                    if (dictionaryIndex[i-1] == 5 || dictionaryIndex[i-1] == 50 || dictionaryIndex[i-1] == 500)
                    {
                        largestNumeral = numeralLookup[dictionaryIndex[i]];
                        smallerNumeral = numeralLookup[dictionaryIndex[i - 2]];
                    }
                    else
                    {
                        largestNumeral = numeralLookup[dictionaryIndex[i]];
                        smallerNumeral = numeralLookup[dictionaryIndex[i - 1]];
                    }
                    
                    outputString += smallerNumeral;
                    outputString += largestNumeral;
                    currentTotal -= dictionaryIndex[i - 1] * 4;
                    break;
                }
                else
                //standard case
                {
                    int largestNumeral = dictionaryIndex[i - 1];
                    int numberOfNumerals = currentTotal / largestNumeral;
                    char currentNumeral = numeralLookup[largestNumeral];
                    for(int j = 0; j < numberOfNumerals; j++)
                    {
                        outputString += currentNumeral;
                    }
                    
                    currentTotal -= numberOfNumerals * largestNumeral;
                    break;
                }
            }                    
        }
        return outputString;
    }
}