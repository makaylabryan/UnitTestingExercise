using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 7, 5, 13)]
        [InlineData(5, 6, 7, 18)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:    DONE

            //Arrange
            // create a Calculator object   DONE
            Calculator calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual     DONE
            int actual = calculator.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(7, 3, 4)]
        [InlineData(20, 11, 9)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:     DONE

            //Arrange
            Calculator subtractCalculator = new Calculator();

            //Act
            int actual = subtractCalculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 7, 42)]
        [InlineData(5, 3, 15)]
        [InlineData(0, 9, 0)]//Add test data <-------     DONE
        public void MultiplyTest(int factor1, int factor2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator multiplyCalculator = new Calculator();

            //Act
            int actual = multiplyCalculator.Multiply(factor1, factor2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(4, 2, 2)]
        [InlineData(12, 1, 12)]//Add test data <-------
        public void DivideTest(int numer, int denom, int expected)
        {
            //Arrange
            Calculator divideCalculator = new Calculator();

            //Act
            int actual = divideCalculator.Divide(numer, denom);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
