using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceHandler.Entities;

namespace ServiceHandler
{
   public static class ExtentionClasss
   {
        public static void ExtentionWait(this Process process, TimeSpan timespan)
        {
            List<ProcessInfo> infos = new List<ProcessInfo>();

            var lines = File.ReadAllLines(@"C:\Programming\ServiceHandler\ServiceHandler\ServiceHandler\ProcessConfig.txt");
            foreach (var line in lines)
            {
                var procName = line.Split(';')[0];
                var procPath = line.Split(';')[1];
                var interval = line.Split(';')[2];
                infos.Add(new ProcessInfo(procName, procPath, interval));
            }

            var manager = new ProcessManager(infos.ToArray(), TimeSpan.FromMinutes(1));
            manager.Start();
            Console.ReadLine();
        }
    }
}
