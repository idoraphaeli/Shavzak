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

        public bool OverlapsWith(Shift other)
        {
            TimeSpan thisStart = this.StartTime;
            TimeSpan thisEnd = this.EndTime;
            TimeSpan otherStart = other.StartTime;
            TimeSpan otherEnd = other.EndTime;

            if (thisEnd <= thisStart)
                thisEnd = thisEnd.Add(TimeSpan.FromDays(1));
            if (otherEnd <= otherStart)
                otherEnd = otherEnd.Add(TimeSpan.FromDays(1));

            return thisStart < otherEnd && otherStart < thisEnd;
        }
    }
}
