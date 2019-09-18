using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class Classexamples
    {
        [TestMethod]
        public void CookieClassInstatiation()
        {
            Cookie cookie = new Cookie();

            cookie.Name = "SnickerDoodle";
            cookie.BatchSize = 122;
            cookie.Direction = "Put togeather, and throw in oven";
            cookie.Ingredient = "Secret: Sour Cream";
            cookie.Shape = "Eiffel Tower";
            cookie.Size = "1365";

            Cookie cookie2 = new Cookie();

            cookie2.Name = "Peanutbuttercup";
            cookie2.BatchSize = 85;
            cookie2.Direction = "dont burn them";
            cookie2.Ingredient = "peanutbutter";
            cookie2.Shape = "round";
            cookie2.Size = "big";


            Cookie cookie3 = new Cookie("Chocolate cups", "Peanutbutter", "XL", "Something", "odd", 345););



        }


    }
}
