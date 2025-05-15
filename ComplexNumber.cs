using L12_OOP_12.Models;
using System;
using System.Text.RegularExpressions;

namespace L12_OOP_12.Models
{
    public class ComplexNumber : StringClass, IComparable, ICloneable
    {
        public double RealPart { get; private set; }
        public double ImaginaryPart { get; private set; }

        public ComplexNumber(string str) : base(str)
        {
            if (!IsValidComplexNumber(str))
            {
                RealPart = 0;
                ImaginaryPart = 0;
                characters = "0+0i";
            }
            else
            {
                ParseComplexNumber(str);
            }
            UpdateLength();
        }

        private bool IsValidComplexNumber(string str)
        {
            string pattern = @"^[+-]?\d+(\.\d+)?[+-]\d+(\.\d+)?i$";
            return Regex.IsMatch(str.Replace(" ", ""), pattern);
        }

        private void ParseComplexNumber(string str)
        {
            try
            {
                str = str.Replace(" ", "");
                int indexOfI = str.IndexOf('i');
                string withoutI = str.Substring(0, indexOfI);

                // Знайти останній + або - як роздільник між дійсною та уявною частинами
                int separatorIndex = Math.Max(withoutI.LastIndexOf('+', withoutI.Length - 1), withoutI.LastIndexOf('-', withoutI.Length - 1));

                RealPart = double.Parse(withoutI.Substring(0, separatorIndex));
                ImaginaryPart = double.Parse(withoutI.Substring(separatorIndex));
            }
            catch (Exception ex)
            {
                throw new FormatException("Error parsing complex number: " + ex.Message);
            }
        }

        public bool IsEqual(ComplexNumber other)
        {
            return RealPart == other.RealPart && ImaginaryPart == other.ImaginaryPart;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            double real = RealPart + other.RealPart;
            double imaginary = ImaginaryPart + other.ImaginaryPart;
            return new ComplexNumber($"{real}+{imaginary}i");
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            double real = RealPart * other.RealPart - ImaginaryPart * other.ImaginaryPart;
            double imaginary = RealPart * other.ImaginaryPart + ImaginaryPart * other.RealPart;
            return new ComplexNumber($"{real}+{imaginary}i");
        }

        public override string Display()
        {
            return $"Complex Number: {characters}, Real Part: {RealPart}, Imaginary Part: {ImaginaryPart}";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is ComplexNumber otherComplex)
            {
                double thisMagnitude = Math.Sqrt(RealPart * RealPart + ImaginaryPart * ImaginaryPart);
                double otherMagnitude = Math.Sqrt(otherComplex.RealPart * otherComplex.RealPart + otherComplex.ImaginaryPart * otherComplex.ImaginaryPart);
                return thisMagnitude.CompareTo(otherMagnitude);
            }
            throw new ArgumentException("Object is not a ComplexNumber");
        }

        public object Clone()
        {
            return new ComplexNumber(this.characters);
        }
    }
}
