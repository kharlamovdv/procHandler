using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceHandler.Entities;

namespace ServiceHandler
{
    /// <summary>
    /// класс принимающий процессы
    /// </summary>
    class GetProcess
    {
        /// <summary>
        /// метод, принимающий процессы из файла
        /// </summary>
        public void TakeProcess()
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
