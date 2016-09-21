using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NLog;
using ServiceHandler.Entities;

namespace ServiceHandler
{
    public class ProcessManager
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private ProcessInfo[] watchedProcesses;
        Timer timer = new Timer();

       
        public ProcessManager(ProcessInfo[] watchedProcesses, TimeSpan checkInterval)
        {
            ConfigureTimer(watchedProcesses, checkInterval);
            Start();
            logger.Log(LogLevel.Debug, "Sample informational message");
        }

        private void ConfigureTimer(ProcessInfo[] watchedProcesses, TimeSpan checkInterval)
        {
            this.watchedProcesses = watchedProcesses;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = checkInterval.TotalMilliseconds;

        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Processhandler.Processhandler handler = new Processhandler.Processhandler();
            handler.StartProcess(watchedProcesses);
        }

    }
}

