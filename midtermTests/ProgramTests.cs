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
    public class ProgramTests
    {
        Conversion converters = new Conversion();
        Arithmatic mathers = new Arithmatic();

        [TestMethod()]
        public void integrate1Test()
        {
            int a = 15;
            int b = 40;

            float f1 = converters.inttofloat(a);
            float f2 = converters.inttofloat(b);

            var result = mathers.add(f1, f2);

            Assert.AreEqual(55f, result);



        }

        [TestMethod()]
        public void integrate2Test()
        {

            float a = 5.0f;
            float b = 4.0f;

            int f1 = converters.floattoint(a);
            int f2 = converters.floattoint(b);

            var result = mathers.add(f1, f2);

            Assert.AreEqual(9, result);



        }

        [TestMethod()]
        public void integrate3Test()
        {

            float a = 900.7f;
            float b = 2002.6f;

            double f1 = converters.floattodouble(a);
            double f2 = converters.floattodouble(b);

            var result = mathers.add(f1, f2);
            result = Math.Round(result, 1);
            Assert.AreEqual(2.9033E3, result);



        }


    }
}