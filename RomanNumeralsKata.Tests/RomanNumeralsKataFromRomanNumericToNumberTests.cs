using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace RomanNumeralsKata.Tests;
public class RomanNumeralsKataFromRomanNumericToNumberTests
{ 

    private RomanNumeralsKataFromRomanNumericsToNumber _RomanNumeralsKataFromRomanNumericsToNumber;

    [SetUp]
    public void Setup()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber = new RomanNumeralsKataFromRomanNumericsToNumber();
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_I()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("I").Should().Be(1);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_II()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("II").Should().Be(2);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_III()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("III").Should().Be(3);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_IV()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("IV").Should().Be(4);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_V()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("V").Should().Be(5);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_VI()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("VI").Should().Be(6);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_VII()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("VII").Should().Be(7);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_VIII()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("VIII").Should().Be(8);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_IX()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("IX").Should().Be(9);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_X()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("X").Should().Be(10);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_LV()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("LV").Should().Be(55);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_MMMDCCXCV()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("MMMDCCXCV").Should().Be(3795);
    }

    [Test]
    public void Get_Number_For_Roman_Numerics_LVIII()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("LVIII").Should().Be(58);
    }

    [Test]
    public void Get_Number_For_Roman_Numerals_MCMXCIV()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("MCMXCIV").Should().Be(1994);
    }

    [Test]
    public void Get_Number_For_Roman_Numerals_Empty()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("").Should().Be(0);
    }

    [Test]
    public void Get_Number_For_Roman_Numerals_Null()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics(null).Should().Be(0);
    }

    [Test]
    public void Get_Number_For_Roman_Numerals_WhiteSpace()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics(" ").Should().Be(0);
    }

    [Test]
    public void Get_Number_For_Roman_Numerals_WhiteSpaceWith_Roman()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("X V").Should().Be(0);
    }

    [Test]
    public void Get_Number_For_Roman_Numerals_With_Invalid_Input()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("SDE").Should().Be(0);
    }
}
