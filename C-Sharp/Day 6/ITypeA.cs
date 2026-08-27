using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal interface ITypeA
    {
        public void Register();
        public bool Login(string username, string password);
    }
}
