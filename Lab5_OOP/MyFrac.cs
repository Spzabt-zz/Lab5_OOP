using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab5_OOP
{
    class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        public BigInteger Nom { get; private set; }
        public BigInteger Denom { get; private set; }

        public double Value
        {
            get { return (double)Nom / (double)Denom; }
        }

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            Nom = nom;
            Denom = denom;
        }

        public MyFrac(int nom, int denom)
        {
            Nom = nom;
            Denom = denom;
        }

        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(Nom * that.Denom + that.Nom * Denom, Denom * that.Denom);
        }

        public MyFrac Divide(MyFrac that)
        {
            try
            {
                return new MyFrac(Nom * that.Denom, Denom * that.Nom);
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(Nom * that.Nom, Denom * that.Denom);
        }

        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(Nom * that.Denom + that.Nom * Denom, Denom * that.Denom);
        }

        public int CompareTo(MyFrac frac)
        {
            return Value.CompareTo(frac.Value);
        }

        public override string ToString()
        {
            double up = (double)Nom / (double)Denom;
            return Nom + "/" + Denom + $" - ({Math.Round(up, 2)})";
        }
    }
}
