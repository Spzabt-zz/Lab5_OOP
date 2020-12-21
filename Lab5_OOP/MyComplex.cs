using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab5_OOP
{
    class MyComplex : IMyNumber<MyComplex>
    {
        public double Re { get; private set; }
        public double Im { get; private set; }

        public MyComplex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public MyComplex(int re, int im)
        {
            Re = re;
            Im = im;
        }

        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(Re + that.Re, Im + that.Im);
        }

        public MyComplex Divide(MyComplex that)
        {
            try
            {
                return new MyComplex((Re * that.Re + Im * that.Im) / (Math.Pow(that.Re, 2) + Math.Pow(that.Im, 2)),
                                  (Im * that.Re - Re * that.Im) / (Math.Pow(that.Re, 2) + Math.Pow(that.Im, 2)));
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(Re * that.Re - Im * that.Im, Re * that.Im + Im * that.Re);
        }

        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(Re - that.Re, Im - that.Im);
        }

        public override string ToString()
        {
            return Re + "+" + Im + "i";
        }
    }
}
