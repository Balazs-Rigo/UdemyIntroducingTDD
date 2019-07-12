using IntroductionTDD;
using System;
using Xunit;


namespace XUnitTestProject
{
    public class No2_1_NaturalNumberCalculatorTests
    {
        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            var calculator = new No2_1_NaturalNumberCalculator();
            var result = calculator.Subtract(4,3);

            Assert.Equal(1,result);
        }

        [Fact]
        public void SubtractMethod_SecondLargerThanFirst_Success()
        {
            var calculator = new No2_1_NaturalNumberCalculator();
            var result = calculator.Subtract(4, 546);

            Assert.Equal(0, result);
        }
    }
}
