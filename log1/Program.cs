using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log1
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Debug("Start");
            log.Debug("End");

            //skriver til C: \Users\admin\Source\Repos\cskursus\log1\bin\Debug\logs
        }
    }
}
