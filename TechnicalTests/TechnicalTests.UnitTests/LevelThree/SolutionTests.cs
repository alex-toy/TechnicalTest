using FluentAssertions;
using NUnit.Framework;

namespace TechnicalTests.UnitTests.LevelThree
{
    [TestFixture]
    internal class SolutionTests
    {
        [TestCase("5", "Add 2 3")]
        [TestCase("20", "Add 13 7")]
        public void Add_Should_Return_Correct_Result(string expected, string command)
        {
            string result = TechnicalTests.LevelThree.LevelThree.Execute(command);
            result.Should().Be(expected);
        }

        [TestCase("Error, command unknown not found", "unknown")]
        public void Unknown_Command_Should_Return_Error(string expected, string command)
        {
            string result = TechnicalTests.LevelThree.LevelThree.Execute(command);
            result.Should().Be(expected);
        }

        [TestCase("", "Hello")]
        public void Hello_Command_Should_Return_Empty_String(string expected, string command)
        {
            string result = TechnicalTests.LevelThree.LevelThree.Execute(command);
            result.Should().Be(expected);
        }

        [TestCase("Here is some coffee, 2 cups exactly!", "GetCoffee 2")]
        public void GetCoffee_Command_Should_Return_String(string expected, string command)
        {
            string result = TechnicalTests.LevelThree.LevelThree.Execute(command);
            result.Should().Be(expected);
        }

        [TestCase("2", "GetSugar 2")]
        public void GetSugar_Command_Should_Return_Correct_String(string expected, string command)
        {
            string result = TechnicalTests.LevelThree.LevelThree.Execute(command);
            result.Should().Be(expected);
        }
    }
}
