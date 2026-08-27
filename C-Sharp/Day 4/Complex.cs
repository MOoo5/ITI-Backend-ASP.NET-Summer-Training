using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public Complex()
        {
        }

        public Complex(int Real)
        {
            this.Real = Real;
            Imag = 0;
        }

        public Complex(int Real, int Imag)
        {
            this.Real = Real;
            this.Imag = Imag;
        }

        public override string ToString()
        {
            char op = Imag < 0 ? '-' : '+';
            return $"{Real}{op}{Math.Abs(Imag)}i";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Complex complex)
                return Real == complex.Real;
            return false;
        }

        public override int GetHashCode()
        {
            return Real.GetHashCode();
        }

        // binary operation
        // Complex c3 = c1 + c2
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex(complex1.Real + complex2.Real, complex1.Imag + complex2.Imag);
            //return new Complex
            //{
            //    Real = complex1.Real + complex2.Real,
            //    Imag = complex1.Imag + complex2.Imag
            //};
        }

        // binary operation
        // complex c3 = c1 + 5
        public static Complex operator +(Complex complex1, int x)
        {
            return new Complex(complex1.Real + x, complex1.Imag + x);
        }
        
        // gives error
        //public static Complex operator +(int y, int x)
        //{
        //    return x + y;
        //}
        
        // complex c3 = c1 - 5
        public static Complex operator -(Complex complex1, int x)
        {
            return new Complex(complex1.Real + x, complex1.Imag + x);
        }

        // unary operation
        public static Complex operator ++(Complex c1)
        {
            return new(c1.Real + 1, c1.Imag + 1);
        }

        public static Complex operator --(Complex c1)
        {
            return new(c1.Real - 1, c1.Imag - 1);
        }


        // matching operators
        // x > y  : bool
        public static bool operator >(Complex c1, Complex c2)
        {
            return c1.Real > c2.Real;
        }

        // x < y  : bool
        public static bool operator <(Complex c1, Complex c2)
        {
            return c1.Real < c2.Real;
        }

        public static bool operator >=(Complex c1, Complex c2)
        {
            return c1.Real >= c2.Real;
        }

        public static bool operator <=(Complex c1, Complex c2)
        {
            return c1.Real <= c2.Real;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.Real != c2.Real;
        }
    }
}
