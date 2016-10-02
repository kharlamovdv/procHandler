using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NLog;
using Processhandler;
using ServiceHandler;
using ServiceHandler.Entities;

namespace ProcessHandler
{
    class Program
    {

        public static Logger log;
        //IEnumerable<T>
        //Nlog
        static void Main(string[] args)
        {
            GetProcess takeProcess= new GetProcess();
            takeProcess.TakeProcess();
        }
    }
   
}
