using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection.Services.IServices
{
    interface ILogger
    {
        void SendMessage(string message);
    }
}
