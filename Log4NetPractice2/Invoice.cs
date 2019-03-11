using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4NetPractice2
{
    class Invoice
    {
        static readonly ILog log = LogManager.GetLogger("Main.Invoice");

        public void Issue()
        {
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    if (i == 10) throw new InvalidOperationException("An error ocurred when issuing an item.");
                    log.DebugFormat("Issuing {0}", i);
                }
                catch (InvalidOperationException e)
                {
                    log.FatalFormat("Some fatal error {0}", e.Message);
                    log.Debug("An exception ocurred when issuing the invoice", e);
                }
            }

        }
    }
}
