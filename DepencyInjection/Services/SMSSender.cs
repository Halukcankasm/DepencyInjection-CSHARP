using DepencyInjection.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection.Services
{
    class SMSSender : IMessageSender
    {
        public void WriteLog(string messsage)
        {
            Console.WriteLine("SMSSender"+ messsage);
        }
    }
}
