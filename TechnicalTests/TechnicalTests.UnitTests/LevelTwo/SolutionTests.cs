using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTests.UnitTests.LevelTwo
{
    [TestFixture]
    internal class SolutionTests
    {
        [TestCase(0, "")]
        [TestCase(6, "6")]
        [TestCase(2, "1 1 +")]
        [TestCase(4, "2 2 *")]
        [TestCase(2, "4 2 /")]
        [TestCase(5, "8 3 -")]
        [TestCase(132, "11 12 *")]
        [TestCase(42, "4 8 9 + 3 2 * - * 2 -")]
        public void Calculate_Should_Return_RPN_Result(int expected, string operations)
        {
            //Assert.Inconclusive();
            int result = TechnicalTests.LevelTwo.Solution.Calculate(operations);
            result.Should().Be(expected);
        }
    }
}
