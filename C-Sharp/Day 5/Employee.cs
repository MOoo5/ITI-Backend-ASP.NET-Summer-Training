using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime HireDate { get; set; }

        public void PrintFile(Printer printer)
        {
            string file = "C# Assignment";
            printer.Print(file);
        }
    }
}
