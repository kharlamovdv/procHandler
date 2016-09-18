using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessHandler.Entities;

namespace Processhandler
{
    class Processhandler
    {
        /// <summary>
        /// метод проверяет, является ли процесс запущенным
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckProcess(string name = "IExplore.exe")
        {

            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// метод запускает процесс
        /// </summary>
        public void StartProcess()
        {
            if (CheckProcess() == false)
            {
                Process.Start("IExplore.exe");
            }
            else
            {
                System.Console.Out.WriteLine("приложение уже запущено");
            }

        }



    }
}
