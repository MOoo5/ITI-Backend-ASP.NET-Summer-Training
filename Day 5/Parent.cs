using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day5
{
    class Parent //: SealedClass
    {
        int y;
        public int x { get; set; }

        public Parent()
        {
            y = -1;
            x = -1;
        }

        public Parent(int x)
        {
            this.x = x;
            y = -12;
        }

        public virtual void Show()
        {
            Console.WriteLine($"x = {x}, y={y}");
        }

        //public void Show()
        //{
        //    Console.WriteLine($"x = {x} y = {y}");
        //}

    }
}
