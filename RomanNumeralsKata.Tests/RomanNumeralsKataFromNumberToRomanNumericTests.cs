using FluentAssertions;

namespace RomanNumeralsKata.Tests;


public class RomanNumeralsKataFromNumberToRomanNumericTests
{
    private RomanNumeralsKataFromNumberToRomanNumeric _RomanNumeralsKataFromNumberToRomanNumeric;

    [SetUp]
    public void Setup()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric = new RomanNumeralsKataFromNumberToRomanNumeric();
    }

    [Test]
    public void Get_RomanNumeric_From_Number_1()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(1).Should().Be("I");
    }
}