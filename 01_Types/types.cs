using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            ////integers
            //short a = -32768;
            //short b = 32767;
            //ushort c = 0;
            //ushort d = 65535;
            //sbyte e = -128;
            //sbyte f = 127;
            //uint g = 4294967295;
            //uint h = 0;
            //int i = 2147483647;
            //int j = -2147483648;
            //long k = 9223372036854775807;
            //long l = -9223372036854775808;
            //ulong m = 18446744073709551615;
            //ulong n = 0;
            //byte o = 0;
            //byte p = 255;




            //int number = 1234;
            //bool on = true;
            //bool off = true;

            //decimal hello = 32432424234.32m;
            //float anotherdecimal = 1223.2f;
            //double anotheranotherdecimal = 4324.23;


        }

        [TestMethod]
        public void Operators()
        {
            // Operators=+ - / % *

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            int subtract = numberTwo - numberOne;
            int multiply = numberOne * numberTwo;
            int divide = numberTwo / numberOne;
            Console.WriteLine(sum);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);


        }


        [TestMethod]
        public void ReferanceTypes()
        {
            string firstName = "Kegan";
            string lastName = "Davis";

            // Concatanation 
            string concatanation = firstName + " " + lastName;
            Console.WriteLine(concatanation);

            // Composite Formatting

            string Composite = string.Format("Hello my name is {0} {1} ", firstName, lastName);
            Console.WriteLine(Composite);

            // String Interpolation

            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            // Classes


            // Struct

            // Collections

            List<string> myList = new List<string>();
            myList.Add("Hello World");

            List<int> myNumberList = new List<int>();
            myNumberList.Add(2);


            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello World");

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Stack<int> newStack = new Stack<int>();

            string banana = "Fruit";
            string[] stringArray = { "Hello", "Charaters", "Food", "Water" };





        }
    }

}
