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
            Assert.Equal(4, uut.Add(2, 2));
        }
    }
}
