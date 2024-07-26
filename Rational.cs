using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS205_HW_3
{
    public class Rational
    {
        public int numerator = 0;
        public int denominator = 1;

        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public void WriteRational(Rational r)
        {
            Console.WriteLine($"{r.numerator}/{r.denominator}");
        }
        public void Negate(Rational r)
        {
            r.numerator *= -1;
        }
        public void Invert(Rational r)
        {

            int temp = r.numerator;
            r.numerator = r.denominator;
            r.denominator = temp;
        }
        public double ToDouble(Rational r)
        {
            float n = (float)r.numerator;
            float d = (float)r.denominator;
            return n / d;
        }
        public static int GCD(int n1, int n2)
        {
            
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
        public static int LCM(int a, int b)
        { return (a * b) / GCD(a, b); }
        public static Rational Add(Rational r1, Rational r2)
        {
            if (r1.denominator == r2.denominator)
            {
                int res = r1.numerator + r2.numerator;
                return new Rational(res, r2.denominator);
            }
            else
            {
                int lcm = LCM(r1.denominator, r2.denominator);
            int adjustedNumerator1 = r1.numerator * (lcm / r1.denominator);
            int adjustedNumerator2 = r2.numerator * (lcm / r2.denominator);

            int resultNumerator = adjustedNumerator1 + adjustedNumerator2;
            return new Rational(resultNumerator, lcm);
            }
        }
    }
}
