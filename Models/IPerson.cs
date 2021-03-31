using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    interface IPerson
    {
        int Age { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string ToString();
        Boolean IsAdult();

    }
}
