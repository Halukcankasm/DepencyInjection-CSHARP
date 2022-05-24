using DepencyInjection.Services;
using DepencyInjection.Services.IServices;
using System;
using System.Configuration;

namespace DepencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor(CreateLogger(), CreateMessageSender());
            processor.Proces();
        }

        static IMessageSender CreateMessageSender()
        {
            IMessageSender retVal;
            string messageSender = ConfigurationManager.AppSettings["Message"].ToString();

            if (messageSender=="SMS")
            {
                retVal = new SMSSender();
            }
            else
            {
                retVal = new MailSender();
            }
            return retVal;
        }

        static ILogger CreateLogger()
        {
            ILogger retVal;
            string logger = ConfigurationManager.AppSettings["Logger"].ToString();

            if (logger == "DB")
            {
                retVal = new DBLogger();
            }
            else
            {
                retVal = new FileLogger();
            }

            return retVal;
        }

    }
}
