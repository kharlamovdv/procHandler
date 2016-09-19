using ServiceHandler.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processhandler
{
    class Processhandler
    {
        /// <summary>
        /// метод проверяет, является ли процесс запущенным
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckProcess(string name = "iexplore")
        {
            return Process.GetProcessesByName(name).Any();
        }

        /// <summary>
        /// метод запускает процесс
        /// </summary>
        public void StartProcess(ProcessInfo[] processes)
        {
            foreach (var processInfo in processes)
            {
                if (!CheckProcess(processInfo.Name))
                {
                    Process.Start(processInfo.Path);
                }
            }
        }
    }
}
