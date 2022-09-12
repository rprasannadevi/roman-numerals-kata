using RomanNumeralsKata;

var RomanNumeralsKataFromRomanNumericsToNumber = new RomanNumeralsKataFromRomanNumericsToNumber();
var RomanNumeralsKataFromNumberToRomanNumeric = new RomanNumeralsKataFromNumberToRomanNumeric();

string? sRoman;
int iNumericValue;

Console.WriteLine("\n RomanNumeric to Number Conversion. \n");
Console.Write("Please Enter a Roman Numeral: ");
sRoman = Console.ReadLine();

if(!string.IsNullOrEmpty(sRoman))
    iNumericValue = RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics(sRoman);
else
    iNumericValue = 0;
Console.WriteLine($"The value of {sRoman}: " + iNumericValue);

Console.WriteLine("\n Number to RomanNumeric Conversion. \n");
Console.Write("Please Enter a Number: ");
iNumericValue =Convert.ToInt32(Console.ReadLine());
if (iNumericValue > 0 && iNumericValue <= 3000)
    sRoman = RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(iNumericValue);
else
    sRoman = "0";
Console.WriteLine($"The RomanNumeric of {iNumericValue}: " + sRoman);