using System;
using System.Text.RegularExpressions;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)] //Add test data <-------
        [InlineData(5,5,5,15)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        [InlineData(5, 10, -5)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        [InlineData(5,4,20)]
        public void MultiplyTest(int num1, int num2, int expected)

        {

            //Arrange
            var test = new Calculator();

            //Start Step 7 here:




            //Act
            var actual = test.Multiply(num1, num2);


            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 5, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {

            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }  
}
