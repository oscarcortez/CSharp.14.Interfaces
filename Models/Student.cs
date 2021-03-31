using System;

namespace Models
{
    public class Student : IPerson
    {
        public int Age { get ; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Boolean IsAdult() => Age >= 18;
        
    }
}
