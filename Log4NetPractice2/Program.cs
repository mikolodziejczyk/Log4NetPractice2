using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4NetPractice2
{
    class Program
    {
        static readonly ILog log = LogManager.GetLogger("Main");

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("Log4NetConfig.xml"));


            log.InfoFormat("Starting with parameters: {0}", String.Join(", ", args));

            // log start here

            if (log.IsInfoEnabled)
            {
                log.Info("Starting invoicing...");
            }

            Invoice i = new Invoice();
            i.Issue();

            log.Info("Completed...");
        }

    }
}
