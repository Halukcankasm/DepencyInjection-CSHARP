using DepencyInjection.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection.Services
{
    class DBLogger : ILogger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("DBLogger"+ message);
        }
    }
}
