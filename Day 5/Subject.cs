using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Subject
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public Subject()
        {
            
        }
        public Subject(string Code, string Name, int Hours)
        {
            this.Code = Code;
            this.Name = Name;
            this.Hours = Hours;
        }
        public override string ToString()
        {
            return $"Code = {Code}, Name = {Name}, Duration = {Hours}H";
        }
    }
}
