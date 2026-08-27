using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    sealed class SealedClass : AbstractClass //, Parent >> error: multiple inheritance
    {

        // can inherit from other class
        // can take object from sealedClass
        // can't make another class inherit from sealedClass
        public int Id { get; set; }
    }
}
