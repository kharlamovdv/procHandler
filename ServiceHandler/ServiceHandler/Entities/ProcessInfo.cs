using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHandler.Entities
{/// <summary>
/// класс, описывающий процесс
/// </summary>
    public class ProcessInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public ProcessInfo(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }
    }
}
