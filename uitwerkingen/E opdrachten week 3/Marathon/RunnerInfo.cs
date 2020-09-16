using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    class RunnerInfo : EventArgs
    {
        public string Name { get; set; }
        public uint Rank { get; set; }
        public RunnerInfo(string name, uint rank)
        {
            Name = name;
            Rank = rank;
        }
    }
}
