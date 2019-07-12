using OddService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OddServiceTests
{
    public class OddServiceTests
    {        
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsOddMethod_OddNumbers_ReturnsTrue(int number)
        {
            var service = new OddServiceImplementation();
            var result = service.IsOdd(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(20)]
        [InlineData(18)]
        public void IsOddMethod_EvenNumbers_ReturnsFalse(int number)
        {
            var service = new OddServiceImplementation();
            var result = service.IsOdd(number);

            Assert.False(result);
        }

        [Fact]
        public void IncreaseCounters_SmallerThanThree_NoCountersIncreased()
        {
            var service = new ExampleServiceImplementation();
            service.IncreaseCounters(1);

            Assert.Equal(0,service.First);
            Assert.Equal(0,service.Second);
            Assert.Equal(0,service.Third);
        }

        [Fact]
        public void IncreaseCounters_BetweenThreeAndFive_FirstIncreased()
        {
            var service = new ExampleServiceImplementation();
            service.IncreaseCounters(4);

            Assert.Equal(1, service.First);
            Assert.Equal(0, service.Second);
            Assert.Equal(0, service.Third);
        }

        [Fact]
        public void IncreaseCounters_BetweenFiveAndSeven_SecondIncreased()
        {
            var service = new ExampleServiceImplementation();
            service.IncreaseCounters(6);

            Assert.Equal(0, service.First);
            Assert.Equal(1, service.Second);
            Assert.Equal(0, service.Third);
        }

    }
}
