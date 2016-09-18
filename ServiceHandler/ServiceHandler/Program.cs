using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Processhandler;

namespace ProcessHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Processhandler.Processhandler handler = new Processhandler.Processhandler();
            handler.StartProcess();
        }
    }
}
