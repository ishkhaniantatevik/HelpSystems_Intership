using System;

namespace ConsoleApp1
{
    public class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public ComplexNumber(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber one, ComplexNumber two)
        {
            return new ComplexNumber(one.Real + two.Real, one.Imaginary + two.Imaginary);
        }
        
        public static ComplexNumber operator -(ComplexNumber one, ComplexNumber two)
        {
            return new ComplexNumber(one.Real - two.Real, one.Imaginary - two.Imaginary);
        }
        
        public override string ToString() {
            return (String.Format("{0} + {1}i", Real, Imaginary));
        }
    }
}
