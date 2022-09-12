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

    [Test]
    public void Get_RomanNumeric_From_Number_0()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(0).Should().Be("0");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_3001()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(3001).Should().Be("0");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_5000()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(5000).Should().Be("0");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_5()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(5).Should().Be("V");
    }
}