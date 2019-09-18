using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_loops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 13;
           
            

            // for (int i = 0 ; i < studentCount; i++)
            //
            //  
            //


            for (int i = 0; i < studentCount; i++)
            {
                
                Console.WriteLine(i);
                studentCount--;

            }


            for (int i = studentCount; i >= 1; i--)
            {
                Console.WriteLine(i);

            }

            for (int i = 0; i < studentCount--; i++)
            {
                Console.WriteLine(i);
            }

        }

        [TestMethod]
        public void WhileLoops()
        {
            int number = 5;
            while (number != 6)
            {
                Console.WriteLine(number);
                number++;
            }
        }

            [TestMethod]
        public void ForeachLoops()
        {
            List<string> students = new List<string>();

            students.Add("Erick Forson");
            students.Add("Regan Nitz");
            students.Add("Jacob Newbie");
            students.Add("Trevor Stuat");
            students.Add("Becky");

            foreach(string studentName in students)
            {
                Console.WriteLine(studentName);
            }

            string mountainName = "Mauna Kea";
            foreach (char letter in mountainName) //always declaries a variable
            {
                if (letter == 'a')

                {
                    Console.WriteLine(letter);
                    //if (letter == 'a')
                    //{
                    //}


                }
            }
            
        }

    















    }
}
