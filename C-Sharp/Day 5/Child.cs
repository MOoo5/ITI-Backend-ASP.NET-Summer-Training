using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Child : Parent
    {
        public int z { get; set; }
        
        public Child()
        {
            
        }

        public Child(int z)
        {
            this.z = z;
        }

        public Child(int z, int x):base(x)
        {
            this.z = z;
        }

        // override virtual methods
        //public override void Show()
        //{
        //    Console.WriteLine($"x={x}, z={z}");
        //}

        //sealed override virtual methods
        //public sealed override void Show()
        //{
        //    Console.WriteLine($"x={x}, z={z}");
        //}

        // override virtual methods
        public new void Show()
        {
            Console.WriteLine($"x={x}, z={z}");
        }

        // method hidden
        //public new void Show()
        //{
        //    base.Show();
        //    Console.WriteLine($"z={z} :)");
        //}
    }
}
