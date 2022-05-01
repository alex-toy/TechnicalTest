using FluentAssertions;
using NUnit.Framework;

namespace TechnicalTests.UnitTests.LevelOne
{
    [TestFixture]
    internal class SolutionTests
    {
        [Test]
        public void GetMagicNumber_Should_Return_Correct_Value()
        {
            //Assert.Inconclusive();
            int result = TechnicalTests.LevelOne.Solution.GetMagicNumber();
            result.Should().Be(78576);
        }

        [Test]
        public void GetSuperMagicNumber_Should_Return_Correct_Value()
        {
            //Assert.Inconclusive();
            int result = TechnicalTests.LevelOne.Solution.GetSuperMagicNumber();
            result.Should().Be(3902304);
        }
    }
}
