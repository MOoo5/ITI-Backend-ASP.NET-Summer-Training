using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class PartTimeEmployee : Employee, ITypeA, ITypeB
    {
        public bool Login(string username, string password)
        {
            return (username == "iti" && password == "123@iti.com");
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void ShowDetails()
        {
            throw new NotImplementedException();
        }
    }
}
