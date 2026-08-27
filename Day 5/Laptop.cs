using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Laptop
    {
        //public Processor processor { get; set; } = new Processor(4); // composition

        // don't create but inject
        // don't create but ask
        public Processor processor { get; set; }  // strong aggregation/association
        public Laptop(Processor p)
        {
            processor = p;
        }
    }
}
