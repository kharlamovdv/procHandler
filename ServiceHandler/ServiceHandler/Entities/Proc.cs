using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessHandler.Entities
{
    /// <summary>
    /// Класс, описывающий процессы
    /// </summary>
    class Proc
    {
        private string m_processName;
        private string m_processLouncherPath;
        private bool m_processState;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="ProcessName"></param>
        /// <param name="ProcessLouncherPath"></param>
        /// <param name="ProcessState"></param>
        public Proc(string ProcessName, string ProcessLouncherPath, bool ProcessState)
        {
            m_processName = ProcessName;
            m_processLouncherPath = ProcessLouncherPath;
            m_processState = ProcessState;
        }

        /// <summary>
        /// свойства
        /// </summary>
        public string ProcessName
        {
            get { return ProcessName; }
        }

        public string ProcessLouncherPath
        {
            get { return m_processLouncherPath; }
        }

        public bool ProcessState
        {
            get { return m_processState; }
        }
    }
}
