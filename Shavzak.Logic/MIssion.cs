using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    public class Mission
    {
        public TaskType Type { get; set; }
        public bool IsStatic { get; set; }
        public int HoursPerShift { get; set; }
        public int SoldiersPerShift { get; set; }
        public List<Shift> Shifts { get; set; }

        public Mission(TaskType type, int hoursPerShift, int soldiersPerShift, bool isStatic)
        {
            Type = type;
            HoursPerShift = hoursPerShift;
            SoldiersPerShift = soldiersPerShift;
            Shifts = GenerateShiftsForDay();
            IsStatic = isStatic;
        }

        private List<Shift> GenerateShiftsForDay()
        {
            var shifts = new List<Shift>();
            int totalHours = 24;
            int numShifts = totalHours / HoursPerShift;

            for (int i = 0; i < numShifts; i++)
            {
                TimeSpan start = TimeSpan.FromHours(i * HoursPerShift);
                TimeSpan end = start + TimeSpan.FromHours(HoursPerShift);

                shifts.Add(new Shift(start, end, SoldiersPerShift));
            }

            return shifts;
        }

        public override string ToString()
        {
            return $"{Type} - {Shifts.Count} shifts of {HoursPerShift}h, {SoldiersPerShift} soldier(s) each";
        }

        public enum TaskType
        {
            Kitchen,              // מטבח
            Patrol,               // סיור
            Rapid_Response_Squad,   // כוננות
            Guard,                // ש"ג
            Command_Center,        // חמ"ל
            Joint_Operations,      // שילוב זרועות
            Duty_Officer           // קצין מוצב
        }
    }
}
