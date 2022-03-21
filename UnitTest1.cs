using System;
using Xunit;

namespace TestFizzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void MyTest1()
        {

            var sut = 12;
            var actualResult = sut.ToString();
            Assert.Equal("1", actualResult);
        }
    }
}
