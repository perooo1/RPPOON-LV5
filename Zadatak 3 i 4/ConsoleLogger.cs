using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3_i_4
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;

        private ConsoleLogger() { }
        
        public static ConsoleLogger GetInstance()
        {
            if (instance == null) instance = new ConsoleLogger();
            return instance;
        }

        public void Log(string message) { Console.WriteLine(message); }

    }
}
