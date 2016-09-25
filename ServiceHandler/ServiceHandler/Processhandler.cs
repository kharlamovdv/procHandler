using ServiceHandler.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Collections;

namespace Processhandler
{
    class Processhandler : IEnumerable<ProcessInfo>
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        private ProcessInfo[] procesInfo;

        /// <summary>
        /// метод проверяет, является ли процесс запущенным
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckProcess(string name = "iexplore")
        {
            logger.Debug("log {0}", "Тест CheckProcess");
            return Process.GetProcessesByName(name).Any();
            
        }

        public IEnumerator<ProcessInfo> GetEnumerator()
        {
            throw new NotImplementedException();
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return procesInfo.GetEnumerator();
        }
    }
}
