using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User : Human
    {
        public string Email { get; set; }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            return $"\n{base.ToString()}\n{Email}";
            Console.ResetColor();
        }
    }
}
