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
        public void WriteRational()
        {
            Console.WriteLine($"{this.numerator}/{this.denominator}");
        }
        public void Negate()
        {
            this.numerator *= -1;
        }
        public void Invert()
        {

            int temp = this.numerator;
            this.numerator = this.denominator;
            this.denominator = temp;
        }
        public double ToDouble()
        {
            return (double)this.numerator / this.denominator;
        }

        // Mistake: Trying to call GCD as if it were an instance method
        // This will cause a compilation error because GCD is static
        //public int MistakenGCDCall()
        //{
        //    return this.GCD(15, 10); // Mistake here
        //}
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
        {
            return (a * b) / GCD(a, b); 
        }

        // Mistake: Trying to call an instance method as if it were static
        // This will cause a compilation error because Add is an instance method
        //public static Rational MistakenAddCall(Rational r1, Rational r2)
        //{
        //    return Add(r1, r2); // Mistake here
        //}
        public Rational Add(Rational r)
        {
            int lcm = LCM(this.denominator, r.denominator);

            int adjustedNumerator1 = this.numerator * (lcm / this.denominator);
            int adjustedNumerator2 = r.numerator * (lcm / r.denominator);

            int resultNumerator = adjustedNumerator1 + adjustedNumerator2;

            return new Rational(resultNumerator, lcm);
        }
        }
    }

