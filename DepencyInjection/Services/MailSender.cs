using DepencyInjection.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection.Services
{
    class MailSender : IMessageSender
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("MailSender"+ message);
        }
    }
}
