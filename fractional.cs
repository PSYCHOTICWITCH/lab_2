using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

        public override string ToString() 
        { 
            return $"{this.numerator}/{this.denominator}";
        }

        internal Fraction reduce()
        {
            int max_val = 0;
            if (this.denominator > this.numerator)
            {
                max_val = this.denominator;
            }
            else
            {
                max_val = this.numerator;
            }

            int divider = 2;

            while (divider < max_val) {
                if (this.denominator % divider == 0 && this.numerator % divider == 0)
                {
                    this.denominator /= divider;
                    this.numerator /= divider;
                }
                else
                {
                    divider++;
                }
            }
            return this;

        }

        public Fraction sum(Fraction f)
        {
            int new_denominator = this.denominator * f.denominator;
            int new_numerator = this.numerator * f.denominator + f.numerator * this.denominator;

            Fraction new_fraction = new(new_numerator, new_denominator);

            return new_fraction.reduce();
        }

        public Fraction minus(Fraction f)
        {
            int new_denominator = this.denominator * f.denominator;
            int new_numerator = this.numerator * f.denominator - f.numerator * this.denominator;

            Fraction new_fraction = new(new_numerator, new_denominator);

            return new_fraction.reduce();
        }
        public Fraction multiply(Fraction f) 
        {
            int new_denominator = this.denominator * f.denominator;
            int new_numerator = this.numerator * f.numerator;

            Fraction new_fraction = new(new_numerator, new_denominator);

            return new_fraction.reduce();
        }

        public Fraction div(Fraction f)
        {
            int new_denominator = this.denominator * f.numerator;
            int new_numerator = this.numerator * f.denominator;

            Fraction new_fraction = new(new_numerator, new_denominator);

            return new_fraction.reduce();
        }

    }
}
