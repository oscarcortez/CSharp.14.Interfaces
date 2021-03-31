using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kitchen : Habitacion
    {
        public int QuantityDrawers { get; set; }

        public Kitchen(decimal metrosCuadrados, int quantityDrawers): base(metrosCuadrados)
        {
            QuantityDrawers = quantityDrawers;
        }

    }
}
