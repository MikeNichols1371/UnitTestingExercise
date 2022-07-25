using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 0, 0, 0)] //Add test data <-------
        [InlineData(2, 15, 2, 19)] //Add test data <-------
        [InlineData(32, 13, 25, 70)] //Add test data <-------

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            int actual = calculator.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15,2,13)]//Add test data <-------
        [InlineData(15,0,15)]//Add test data <-------
        [InlineData(0,0,0)]//Add test data <-------
        [InlineData(20,2,18)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc2 = new Calculator();

            //Act
            int actual = calc2.Subtract(minuend,subtrhend);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(3,2,6)]//Add test data <-------
        [InlineData(3,0,0)]//Add test data <-------
        [InlineData(4,2,8)]//Add test data <-------
        [InlineData(5,5,25)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc3 = new Calculator();
            //Act
            int actual = calc3.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]//Add test data <-------
        [InlineData(0,0,0)]//Add test data <-------
        [InlineData(90,3,30)]//Add test data <-------
        [InlineData(15,5,3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc4 = new Calculator();
            //Act
            int actual = calc4.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
