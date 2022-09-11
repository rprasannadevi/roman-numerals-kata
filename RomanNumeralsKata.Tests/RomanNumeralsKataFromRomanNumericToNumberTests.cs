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
    public void Get_Number_From_Roman_Numerics()
    {
        _RomanNumeralsKataFromRomanNumericsToNumber.GetNumberFromRomanNumerics("I").Should().Be(1);
    }
}
