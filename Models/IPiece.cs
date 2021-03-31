using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IPiece
    {
        decimal Area();
        decimal Perimeter();

        string GetChildType();
    }
}
