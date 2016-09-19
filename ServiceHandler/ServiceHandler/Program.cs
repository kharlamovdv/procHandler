using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Processhandler;
using ServiceHandler.Entities;

namespace ProcessHandler
{
    class Program
    {
        static void Main(string[] args)
        {

            ProcessInfo[] procName = {new ProcessInfo("iexplore" , "C:/Program Files/Internet Explorer/iexplore.exe")};
            Processhandler.Processhandler handler = new Processhandler.Processhandler();
            handler.StartProcess(procName);
        }

        Timer timer = new Timer(90);
        
    }
}
