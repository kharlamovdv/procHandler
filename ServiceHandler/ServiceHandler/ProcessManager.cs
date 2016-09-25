using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NLog;
using ProcessHandler;
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
            logger.Debug("log {0}", "Тест ProcessManager");
            ConfigureTimer(watchedProcesses, checkInterval);
            Start();
           
        }

        private void ConfigureTimer(ProcessInfo[] watchedProcesses, TimeSpan checkInterval)
        {
            logger.Debug("log {0}", "Тест ConfigureTimer");
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
            logger.Debug("log {0}", "Тест OnTimedEvent");
            Processhandler.Processhandler handler = new Processhandler.Processhandler();
            handler.StartProcess(watchedProcesses);
        }
    }
}

