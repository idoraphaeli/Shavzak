using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    internal class MIssion
    {
        public TaskType Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public MIssion(TaskType type, DateTime startTime, DateTime endTime)
        {
            Type = type;
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"{Type} from {StartTime:HH:mm} to {EndTime:HH:mm}";
        }

        public enum TaskType
        {
            Kitchen,         // מטבח
            Patrol,          // סיור
            Standby,         // כוננות
            Guard,           // ש"ג
            CommandCenter,   // חמ"ל
            JointOperations, // שילוב זרועות
            DutyOfficer      // קצין מוצב
        }
    }
}
