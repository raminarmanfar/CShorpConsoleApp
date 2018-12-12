using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShorpConsoleApp
{
    class Person
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int DaysLived => (DateTime.Today - BirthDate).Days;
        public int Age => DaysLived / 365;

        public Person(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
    }
}
