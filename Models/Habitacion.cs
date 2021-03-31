using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Habitacion
    {
        public decimal MetrosCuadrados { get; set; }

        public virtual Boolean EsSoleado { get; set; }

        public Habitacion(decimal metrosCuadrados)
        {
            MetrosCuadrados = metrosCuadrados;
            EsSoleado = false;
        }

        
    }
}
