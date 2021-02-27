using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    abstract class Human
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name - {Name}\nSurname - {Surname}\nAge - {Age}";
        }
    }
}