using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class SubChild:Child
    {
        public int A { get; set; }
        public SubChild()
        {
            
        }

        public SubChild(int A)
        {
            this.A = A;
        }

        public SubChild(int a, int x, int z):base(z, x)
        {
            A = a;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"a = {A}");
        }
    }
}
