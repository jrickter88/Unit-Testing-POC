using Microsoft.VisualStudio.TestTools.UnitTesting;
using midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm.Tests
{
    [TestClass()]
    public class ArithmaticTests
    {
        Arithmatic mathers = new Arithmatic();
        

        [TestMethod()]
        public void addTest()
        {

            int a = 10;
            int b = 10;
           var result = mathers.add(a, b);

            Assert.AreEqual(20, result);


       
        }

        [TestMethod()]
        public void addTest1()
        {

            float a = 4.5f;
            float b = 6.3f;
            var result = mathers.add(a, b);

            Assert.AreEqual(10.8f, result);

          
        }

        [TestMethod()]
        public void addTest2()
        {
            double a = 1.7E+3;
            double b = 1.5E+3;

            var result = mathers.add(a, b);

            Assert.AreEqual(3.2E+3, result);



        }
    }
}