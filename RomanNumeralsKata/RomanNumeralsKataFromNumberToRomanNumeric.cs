using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsKataFromNumberToRomanNumeric
    {

        public string GetRomanNumericsFromNumber(int number)
        {
            if(number > 0 && number <= 3000)
                return "I";
            else
                return "0";
        }
    }
}
