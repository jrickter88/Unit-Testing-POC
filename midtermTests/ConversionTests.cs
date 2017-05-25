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
    public class ConversionTests
    {
        Conversion convershun = new Conversion();

        [TestMethod()]
        public void ConverionTest()
        {

           

        }

        [TestMethod()]
        public void inttofloatTest()
        {
            int a = 10;
            int b = 15;

            var c = convershun.inttofloat(a);
            var d = convershun.inttofloat(b);

            Assert.AreEqual(c.GetType(), typeof(float));
            Assert.AreEqual(d.GetType(), typeof(float));
        }

        [TestMethod()]
        public void floattointTest()
        {
            float a = 4.5f;
            float b = 3.5f;

            var c = convershun.floattoint(a);
            var d = convershun.floattoint(b);

            Assert.AreEqual(c.GetType(), typeof(int));
            Assert.AreEqual(d.GetType(), typeof(int));
        }

        [TestMethod()]
        public void floattodoubleTest()
        {
            float a = 6.3f;
            float b = 2.5f;

            var c = convershun.floattodouble(a);
            var d = convershun.floattodouble(b);

            Assert.AreEqual(c.GetType(), typeof(double));
            Assert.AreEqual(d.GetType(), typeof(double));
        }
    }
}