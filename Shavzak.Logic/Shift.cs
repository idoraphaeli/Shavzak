using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    public class Shift
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int RequiredSoldiers { get; set; }
        public List<Soldier> AssignedSoldiers { get; set; }

        public Shift(TimeSpan start, TimeSpan end, int requiredSoldiers)
        {
            StartTime = start;
            EndTime = end;
            RequiredSoldiers = requiredSoldiers;
            AssignedSoldiers = new List<Soldier>();
        }

        public override string ToString()
        {
            return $"Shift from {StartTime:hh\\:mm} to {EndTime:hh\\:mm} ({RequiredSoldiers} required)";
        }
    }
}
