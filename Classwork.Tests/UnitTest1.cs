using System;
using Xunit;

namespace Classwork.Tests
{
    ///  <summary>
    /// Ja skaitlis dalās ar 3 tad atgriez "Fizz"
    /// Ja skaitlis dalās ar 5 tad atgriez "Buzz"
    /// Ja skaitlis dalās ar 3 un 5 tad atgriez "FizzBuzz"
    /// Ja skaitlis nedalās ne ar 3 un ne ar 5 tad atgriez skaitli
    /// </summary>

    public class FizzBuzzTests
    {
        // Function_When_Then
        [Fact]
        public void GetNumber_WhenNumberDoesNotDivideBy3Or5_ThenReturnsNumber()
        {
            //Arrange
            var fizzClass = new FizzBuzz();

            //Act
            var fizzText = fizzClass.GetNumber(1);

            // Assert
            Assert.Equal("1", fizzText);


        }
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(21)]
        [InlineData(12)]
        public void GetNumber_WhenNumberDividesBy3_ThenReturnsFizz(int testNumber)
        {
            //Arrange
            var fizzClass = new FizzBuzz();

            //Act
            var fizzText = fizzClass.GetNumber(testNumber);

            // Assert
            Assert.Equal("Fizz", fizzText);


        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(20)]
        public void GetNumber_WhenNumberDividesBy5_ThenReturnsBuzz(int testableNumber)
        {
            // Arrange
            var fizzClass = new FizzBuzz();

            // Act
            var fizzText = fizzClass.GetNumber(testableNumber);

            // Assert
            Assert.Equal("Buzz", fizzText);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        public void GetNumber_WhenNumberDividesBy3And5_ThenReturnsFizzBuzz(int testableNumber)
        {
            // Arrange
            var fizzClass = new FizzBuzz();

            // Act
            var fizzText = fizzClass.GetNumber(testableNumber);

            // Assert
            Assert.Equal("FizzBuzz", fizzText);
        }

    }
}
