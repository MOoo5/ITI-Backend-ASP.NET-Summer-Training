using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class OrderService
    {
        public void CreateOrder(EmailService emailService)
        {
            /// booking

            emailService.Send("men3m@gmail.com", "Order created successfully", "you've ordered Shawerma Fra5");
        }
    }
}
