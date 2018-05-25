using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzz fizzbuzz;
        public FizzBuzzTests()
        {
            this.fizzbuzz = new FizzBuzz();
        }
        
        [Fact]
        public void Should_Return_FizzBuzz_Given_15()
        {
            // Arrange
            int inputValue = 15;

            // Act
            string result = this.fizzbuzz.GetValue(inputValue);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }
    }
}
