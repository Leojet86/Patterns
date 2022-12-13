using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    /// <summary>
    /// Another common implementation of builder
    /// </summary>
    public class PersonBuilder
    {
        private Person person = new Person();

        public PersonBuilder FirstName(string firstName)
        {
            person.FirstName = firstName;
            return this;
        }

        public PersonBuilder LastName(string lastName)
        {
            person.LastName = lastName;
            return this;
        }

        public PersonBuilder Age(int age)
        {
            person.Age = age;
            return this;
        }

        public PersonBuilder Phone(string phone)
        {
            person.Phone = phone;
            return this;
        }

        public PersonBuilder NAS(string nas)
        {
            person.NAS = nas;
            return this;
        }

        public Person Build()
        {
            return person;
        }
    }
}
