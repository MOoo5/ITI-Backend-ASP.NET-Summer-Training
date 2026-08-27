using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    interface IPlayer
    {
        public bool IsPlaying { get; set; }
        void Score();
        bool Result();
    }

    interface ITypeC<T>
    {
        T Sum(T a, T b);
    }
}
