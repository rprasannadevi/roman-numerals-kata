using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsKataFromNumberToRomanNumeric
    {
        private readonly Dictionary<int, string> NumberRomanDictionary;

        public RomanNumeralsKataFromNumberToRomanNumeric()
        {
            NumberRomanDictionary = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };
        }

        public string GetRomanNumericsFromNumber(int number)
        {
            string sRomanString = "";
            if (number > 0 && number <= 3000)
            {
                foreach(var num in NumberRomanDictionary)
                {
                    while(number >= num.Key)
                    {
                        sRomanString = sRomanString + num.Value;
                        number = number - num.Key;
                    }
                }
                return sRomanString;
            }
            else
                return "0";
        }
    }
}
