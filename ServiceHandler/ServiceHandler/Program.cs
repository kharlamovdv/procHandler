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
      


            List<ProcessInfo> infos = new List<ProcessInfo>();
            
            var lines = File.ReadAllLines(@"C:\Programming\ServiceHandler\ServiceHandler\ServiceHandler\ProcessConfig.txt");
            foreach (var line in lines)
            {
                var procName = line.Split(';')[0];
                var procPath = line.Split(';')[1];
                infos.Add(new ProcessInfo(procName, procPath));
            }
           
            var manager = new ProcessManager(infos.ToArray(), TimeSpan.FromMinutes(1));
            manager.Start();
            Console.ReadLine();
        }
        
    }
   
}
