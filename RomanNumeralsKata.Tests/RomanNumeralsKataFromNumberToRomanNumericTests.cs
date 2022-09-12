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

    [Test]
    public void Get_RomanNumeric_From_Number_2()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(2).Should().Be("II");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_3()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(3).Should().Be("III");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_4()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(4).Should().Be("IV");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_6()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(6).Should().Be("VI");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_7()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(7).Should().Be("VII");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_8()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(8).Should().Be("VIII");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_9()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(9).Should().Be("IX");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_10()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(10).Should().Be("X");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_400()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(400).Should().Be("CD");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_1000()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(1000).Should().Be("M");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_55()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(55).Should().Be("LV");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_58()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(58).Should().Be("LVIII");
    }

    [Test]
    public void Get_RomanNumeric_From_Number_1994()
    {
        _RomanNumeralsKataFromNumberToRomanNumeric.GetRomanNumericsFromNumber(1994).Should().Be("MCMXCIV");
    }
}