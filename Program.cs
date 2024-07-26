namespace CS205_HW_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool res1 = Part_1.IsAbecedarian("abcdefg");
            bool res2 = Part_1.IsAbecedarian("baehint");
            Console.WriteLine("Part 1:");
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine("--------------------");
            Rational rational = new Rational(3, 2);
            // Writing the initial rational number
            Console.WriteLine("Initial rational number:");
            rational.WriteRational(rational);

            // Negating the rational number
            rational.Negate(rational);
            Console.WriteLine("After negation:");
            rational.WriteRational(rational);

            // Negating again to return to original
            rational.Negate(rational);
            Console.WriteLine("After negating again to return to original:");
            rational.WriteRational(rational);

            // Inverting the rational number
            rational.Invert(rational);
            Console.WriteLine("After inversion:");
            rational.WriteRational(rational);

            // Converting to double
            double decimalValue = rational.ToDouble(rational);
            Console.WriteLine("As a double: " + decimalValue);

            // Demonstrating GCD calculation
            Console.WriteLine("GCD of 225 and 500:");
            Console.WriteLine(Rational.GCD(225, 500));

            Rational r1 = new Rational(1, 3);
            Rational r2 = new Rational(1, 6);

            // Add the two Rational numbers
            Rational result = Rational.Add(r1, r2);

            // Print the result
            Console.WriteLine($"The result of adding {r1.numerator}/{r1.denominator} and {r2.numerator}/{r2.denominator} is {result.numerator}/{result.denominator}");
        }
    }
}
