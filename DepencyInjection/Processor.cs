using DepencyInjection.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection
{
    class Processor
    {
        ILogger logger;
        IMessageSender messageSender;
        public Processor(ILogger _logger,IMessageSender _messageSender )
        {
            logger = _logger;
            messageSender = _messageSender;
        }

        public void Proces()
        {
            logger.SendMessage("Log Text");
            messageSender.WriteLog("Message Text");
        }

    }
}
