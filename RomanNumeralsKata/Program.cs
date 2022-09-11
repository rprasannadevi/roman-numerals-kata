using RomanNumeralsKata;

var RomanNumeralsKataFromRomanNumericsToNumber = new RomanNumeralsKataFromRomanNumericsToNumber();


string sRoman;
int iNumericValue;
Console.Write("Please Enter a Roman Numeral: ");
sRoman = Console.ReadLine();

iNumericValue = RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics(sRoman);
Console.WriteLine($"The value of {sRoman}: " + iNumericValue);