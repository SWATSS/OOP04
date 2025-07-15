using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Classes
{
    #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion

        public static Complex operator +(Complex Left, Complex Right)
        {
            Complex Result = new Complex()
            {
                Real = Left.Real + Right.Real,
                Imag = Left.Imag + Right.Imag
            };
            return Result;
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            Complex Result = new Complex()
            {
                Real = Left.Real - Right.Real,
                Imag = Left.Imag - Right.Imag
            };
            return Result;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
    #endregion
}
