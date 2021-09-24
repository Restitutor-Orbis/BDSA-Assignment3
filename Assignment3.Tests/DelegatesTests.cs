using System;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        private delegate string ReverseOrder(string str);
        private delegate double SumDecimals(double x, double y);
        private delegate bool NumericallyEqual(string str, int value);

        [Fact]
        public void ReverseOrder_correct_order()
        {
            string str = "abcdef";

            ReverseOrder reverseOrder = delegate(string str) {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            };

            string expected = "fedcba";

            Assert.Equal(expected, reverseOrder(str));
        }

        [Fact]
        public void SumDecimals_correct()
        {
            double x = 5.51;
            double y = 8.21;

            var add = new SumDecimals(
                delegate (double x, double y)
                {
                    return x * y;
                }
            );

            double expected = 45.2371;
            double actual = Math.Round(add(x,y), 4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumericallyEqual_correct()
        {
            string str = "0042";
            int value = 42;

            var numEq = new NumericallyEqual(
                delegate (string str, int value)
                {
                    return Int32.Parse(str) == value;
                }
            );

            Assert.True(numEq(str, value));
        }

        [Fact]
        public void NumericallyEqual_inCorrect()
        {
            string str = "439900001";
            int value = 43991;

            var numEq = new NumericallyEqual(
                delegate (string str, int value)
                {
                    return Int32.Parse(str) == value;
                }
            );

            Assert.False(numEq(str, value));
        }
    }
}
