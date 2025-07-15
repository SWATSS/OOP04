using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Classes
{
    internal class Rectangle
    {
        #region Q2) Create a class named Rectangle with the following constructors:
        #region Properites
        public int width { get; set; }
        public int height { get; set; }
        #endregion
        #region Ctor
        public Rectangle()
        {
            width = height = 0;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int WH)
        {
            height = width = WH;
        } 
        #endregion
        public override string ToString()
        {
            return $"Width: {width}, Height: {height}";
        }
        #endregion
    }
}
