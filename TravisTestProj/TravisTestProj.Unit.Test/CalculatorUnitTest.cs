using System;
using Xunit;

namespace TravisTestProj.Unit.Test
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void Calculator_Add2Plus3_Returns5()
        {
            var uut = new Calculator();
            Assert.Equal(5, uut.Add(2, 3));
        }

        [Fact]
        public void Calculator_Subtraction2Minus3_ReturnsMinus1()
        {
            var uut = new Calculator();
            Assert.Equal(-1, uut.Subtraction(2, 3));
        }
    }
}
