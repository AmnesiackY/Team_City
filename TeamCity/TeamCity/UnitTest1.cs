using System;
using Xunit;

namespace TeamCity
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3, -8)]
        [InlineData(4, 5, 6, -71)]
        [InlineData(1, 1, 1, -3)]
        [InlineData(1, 2, 2, -4)]
        [InlineData(2, 2, 3, -20)]
        [InlineData(5, 5, 1, 5)]
        [InlineData(3, 2, 2, -20)]
        [InlineData(3, 1, 1, -11)]
        [InlineData(3, 2, 1, -8)]
        [InlineData(8, 4, 1, -16)]
        [InlineData(8, 5, 3, -71)]
        [InlineData(7, 7, 4, -63)]
        [InlineData(2, 2, 1, -4)]
        [InlineData(3, 3, 1, -3)]
        [InlineData(5, 9, 2, 41)]
        [InlineData(8, 8, 1, 32)]
        [InlineData(7, 7, 1, 21)]
        [InlineData(4, 4, 1, 0)]
        [InlineData(9, 9, 1, 45)]
        [InlineData(9, 9, 2, 9)]
        [InlineData(8, 8, 2, 0 )]
        public void Test1(int a, int b, int c, int expected)
        {
            double actual = Square_equations.Discriminant(a, b, c);
            Assert.Equal(expected, actual);
        }

        public void check()
        {
            int a;
            int b;
            
        }
    }
}
