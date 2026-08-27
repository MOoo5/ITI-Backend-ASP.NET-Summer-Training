using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class EmailService
    {
        public void Send(string email, string subject, string body)
        {
            Console.WriteLine($"Subject: {subject}\nDear {email},\n    {body}");
        }
    }
}
