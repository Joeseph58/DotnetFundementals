using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Methods()
        {
            // + = - / * %

            int sum = 2 + 2;
            int subtract = 2 - 2;
            int multiply = 2 * 2;
            int divide = 2 / 2;
            int remainder = 2 % 2;

            int expected = 8;
            int actual = Addtwonumbers(sum, multiply);
            Assert.AreEqual(expected, actual);


            int expectedTwo = 0;
            int actualTwo = Subtracttwonumbers(subtract, remainder);
            Assert.AreEqual(expectedTwo, actualTwo);

            int expectedThree = 0;
            int actualThree = Multiplytwonumbers(multiply, remainder);
            Assert.AreEqual(expectedThree, actualThree);

            int expectedFour = 0;
            int actualFour = Dividetwonumbers(divide, remainder);
            Assert.AreEqual(expectedFour, actualFour);

            int expectedFive = 0;
            int actualFive = Remaindertwonumbers(remainder, remainder);
            Assert.AreEqual(expectedFive, actualFive);


        }

        //access modifier 2 = return type 3= method name 4 = Parentheses(parameters)
        //1     //2 //4     //4

        public int Addtwonumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;

        }

        public int Subtracttwonumbers(int numOne, int numTwo)
        {
            int subtract = numTwo - numOne;
            return subtract;
        }

        public int Multiplytwonumbers(int numOne, int numTwo)
        {
            int multiply = numTwo * numOne;
            return multiply;
        }

        public int Dividetwonumbers(int numOne, int numTwo)
        {
            int divide = numTwo / numOne;
            return divide;
        }

        public int Remaindertwonumbers(int numOne, int numTwo)
        {
            int remainder = numTwo + numOne;
            return remainder;
        }

    }
}
