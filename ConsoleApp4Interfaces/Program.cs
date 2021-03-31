using Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp4Interfaces
{
    class Program
    {
        /// <summary>
        /// interfaces: una interfaz solo tiene las firmas para instanciarse en la clase hija
        /// si un metodo no esta en la interfaz no se puede usar
        /// una clase hija puede tener metodos adicionales aparte de las firmas y lo recomendable es que sean privados
        /// mas de una interfaz para una clase hijo, si se puede
        /// SEALED: para este caso una clase o method sealed no puede usarse para heredarse
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // IPerson person = new Student(); // bad example, its better convert ir into an abstract class

            IPiece cuadrado = new Square(5);
            IPiece triangle = new RectangleTriangle(15, 10);
            
            Console.WriteLine($"area del cuadrado es: {cuadrado.Area()}");

            Console.WriteLine($"area del triangulo es: {triangle.Area()}");

            List<IPiece> pieces = new List<IPiece>()
            {
                new Square(5),
                new Square(9),
                new RectangleTriangle(3,10)
            };

            pieces.ForEach(piece =>
            {                
                Console.WriteLine($"area del {piece.GetChildType()} es:{piece.Area()}");
            });

        }
    }

}
