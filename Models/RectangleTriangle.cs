using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class RectangleTriangle : IPiece
    {
        public decimal SideA { get; set; }
        public decimal SideB { get; set; }
        public decimal Hypotenuse { get; set; }

        public RectangleTriangle(decimal sideA, decimal sideB)
        {
            SideA = sideA;
            SideB = sideB;
            Hypotenuse = CalculateHipotenuse();
        }

        private decimal CalculateHipotenuse() => Convert.ToDecimal(Math.Sqrt((double)(SideA * SideB + SideB * SideB)));

        public decimal Area() => SideA * SideB / 2;

        public decimal Perimeter() => SideA + SideB + Hypotenuse;

        public string GetChildType() => GetType().Name;
    }
}
