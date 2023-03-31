using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hunman
{
    class Program
    {
        class Human
        {
            private string firstname, lastname;

            public Human(string firstname, string lastname)
            {
                this.firstname = firstname;
                this.lastname = lastname;
            }

            public string Firstname { get => firstname; set => firstname = value; }
            public string Lastname { get => lastname; set => lastname = value; }

        }


        static void Main(string[] args)
        {
        }
    }
}
