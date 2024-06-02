using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Logger
    {
        private static Logger instance = null;
        private List<string> messages;

        private Logger()
        {
            messages = new List<string>();
        }

        public static Logger getInstance()
        {
            if (instance == null)
            {
                createInstance();
            }

            return instance;
        }

        public void log(string message)
        {
            messages.Add(message);
            // tutaj powinna znaleźć się logiką związana z logowaniem komunikatu
        }

        private static void createInstance()
        {
           instance = new Logger();
        }
    }
}
