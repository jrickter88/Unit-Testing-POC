using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class Program
    {
        Conversion converters = new Conversion();
        Arithmatic mathers = new Arithmatic();
        static void Main(string[] args)
        {
            

          



        }   


            public void integrate1(int a, int b)
        {

            float f1 = converters.inttofloat(a);
            float f2 = converters.inttofloat(b);

            var r1 = mathers.add(f1, f2);



        }
        
        public void integrate2(float a, float b)
        {

            int i1 = converters.floattoint(a);
            int i2 = converters.floattoint(b);

            var r1 = mathers.add(i1, i2);



        }
        public void integrate3(float a, float b)
        {
            double d1 = converters.floattodouble(a);
            double d2 = converters.floattodouble(b);

            var r1 = mathers.add(d1, d2);


        }



        }
    }

