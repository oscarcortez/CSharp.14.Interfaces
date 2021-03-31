using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Square : IPiece
    {
        public decimal Side { get; set; }

        public Square(decimal side)
        {
            Side = side;
        }

        public decimal Area() => Side * Side;

        public decimal Perimeter() => Side * 4;

        public string GetChildType() => GetType().Name;

        //public string GetChildInstanceOf() => this.GetChildInstanceOf();
    }
}
