using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsKataFromRomanNumericsToNumber
    {
        private readonly Dictionary<char, int> RomanNumericDictionary;

        public RomanNumeralsKataFromRomanNumericsToNumber()
        {
            RomanNumericDictionary = new Dictionary<char, int>
            { 
                {'I', 1 },
                {'V', 5},
                {'X', 10 },
                {'L', 50},
                {'C', 100 },
                {'D', 500},
                {'M', 1000 }
            };
        }

        public int GetNumberFromRomanNumerics(string roman)
        {
            int iValue = 0;
            if(!string.IsNullOrEmpty(roman) && !roman.Contains(' '))
            {
                char prevChar = roman[0];
                foreach (char currChar in roman)
                {
                    if (RomanNumericDictionary.ContainsKey(currChar))
                    {
                        if (RomanNumericDictionary[currChar] > RomanNumericDictionary[prevChar])
                            iValue += RomanNumericDictionary[currChar] - RomanNumericDictionary[prevChar] * 2;
                        else
                            iValue += RomanNumericDictionary[currChar];
                        prevChar = currChar;
                    }
                    else
                        return 0;
                }
            }
            return iValue;
        }
    }
}
