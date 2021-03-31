using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Trainer : IPerson
    {
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsAdult()
        {
            throw new NotImplementedException();
        }
    }
}
