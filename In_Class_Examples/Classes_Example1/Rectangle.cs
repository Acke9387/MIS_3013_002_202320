using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Example1
{
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// The Length value of the Rectangle
        /// </summary>
        public double Length { get; set; }
        public double Width { get; set; }

        private string Message;

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Message = string.Empty;
        }

        /// <summary>
        /// Calculate the Area of the Rectangle
        /// </summary>
        /// <returns>The area of the Rectangle</returns>
        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

    }
}
