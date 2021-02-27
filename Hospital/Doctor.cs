using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Doctor : Human
    {
        public int Id { get; set; }
        static int staticId { get; set; } = 0;
        public int Workyear { get; set; }
        public bool[] ReserveOrNot { get; set; } = { false, false, false };
        public void Meeting(int id)
        {
            if (id > 0 && id <= 3) ReserveOrNot[id - 1] = true;
            else
            {
                Console.WriteLine("Zanitem.");
            }
        }
        public Doctor()
        {
            Id = ++staticId;
        }
        public override string ToString()
        {
            return $"\nId){Id}\n{base.ToString()}\nWork year - {Workyear}";


        }


    }
}
