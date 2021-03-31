using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    sealed class Suite : Habitacion
    {
        public override Boolean EsSoleado { get; set; }

        public Suite(decimal metrosCuadrados, bool esSoleado): base(metrosCuadrados)
        {
            EsSoleado = esSoleado;
        }
    }
}
