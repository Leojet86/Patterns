using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string NAS { get; set; }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, age: {Age}, phone: {Phone}, NAS: {NAS}";
        }
    }
}
