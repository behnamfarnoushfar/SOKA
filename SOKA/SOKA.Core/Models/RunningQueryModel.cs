using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOKA.Core.Models
{
    public class RunningQueryModel
    {
        public int SessionId { get; set; }
        public decimal PercentComplete { get; set; }
        public string LoginName { get; set; }
        public string IP { get; set; }
        public string HostName { get; set; }
        public string DbName { get; set; }
        public string QueryText { get; set; }
        public string Status { get; set; }
        public string Command { get; set; }
        public decimal RamUsage { get; set; }
        public decimal CPUTime { get; set; }
        public decimal TotalTime { get; set; }
        public decimal Duration { get; set; }
        public string ProgramName { get; set; }
    }
}
