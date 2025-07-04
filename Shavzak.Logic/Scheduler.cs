using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shavzak.Logic.Constraint;

namespace Shavzak.Logic
{
    public class Scheduler
    {
        private const int MinRestHours = 8;

        public static bool AssignSoldiers(Deployment deployment)
        {
            bool missing = HasSufficientSoldiers(deployment);

            if (!missing)
            {
                return missing;
            }

            List<(Soldier soldier, Shift shift)> scheduled = new List<(Soldier, Shift)>();

            var orderedMissions = deployment.Missions
                .OrderByDescending(m => m.HoursPerShift)
                .ToList();

            foreach (var mission in orderedMissions)
            {
                foreach (var shift in mission.Shifts)
                {
                    var availableSoldiers = deployment.Company.GetSoldiers()
                        .Where(s => SoldierMeetsConstraints(s, mission) && IsAvailable(s, shift, scheduled, MinRestHours))
                        .OrderBy(s => s.TotalMissionsAssigned)
                        .ThenBy(s => s.TaskTypeCounts.ContainsKey(mission.Type) ? s.TaskTypeCounts[mission.Type] : 0)
                        .Take(mission.SoldiersPerShift)
                        .ToList();

                    shift.AssignedSoldiers = availableSoldiers;

                    foreach (var soldier in availableSoldiers)
                    {
                        if (!soldier.TaskTypeCounts.ContainsKey(mission.Type))
                            soldier.TaskTypeCounts[mission.Type] = 0;

                        soldier.TaskTypeCounts[mission.Type]++;
                        scheduled.Add((soldier, shift));
                    }
                }
            }

            return missing;
        }

        private static bool IsAvailable(Soldier soldier, Shift currentShift, List<(Soldier soldier, Shift shift)> scheduled, int minRestHours)
        {
            var soldierShifts = scheduled
                .Where(s => s.soldier == soldier)
                .Select(s => s.shift);

            foreach (var soldierShift in soldierShifts)
            {
                if (ShiftsOverlap(soldierShift.StartTime, soldierShift.EndTime, currentShift.StartTime, currentShift.EndTime))
                    return false;

                double restBefore = (currentShift.StartTime - soldierShift.EndTime).TotalHours;
                if (restBefore < 0)
                    restBefore += 24;
                if (restBefore < minRestHours)
                    return false;

                double restAfter = (soldierShift.StartTime - currentShift.EndTime).TotalHours;
                if (restAfter < 0)
                    restAfter += 24;
                if (restAfter < minRestHours)
                    return false;
            }

            return true;
        }

        private static bool ShiftsOverlap(TimeSpan start1, TimeSpan end1, TimeSpan start2, TimeSpan end2)
        {
            bool isFullDay1 = start1 == end1;

            if (isFullDay1)
                return true;

            bool overlaps =
                (start1 < end1 && start2 < end2 && start1 < end2 && start2 < end1) ||
                (start1 > end1 && (start2 < end1 || start2 > start1)) ||
                (start2 > end2 && (start1 < end2 || start1 > start2));

            return overlaps;
        }


        public static bool HasSufficientSoldiers(Deployment deployment)
        {
            List<Soldier> allSoldiers = deployment.Company.GetSoldiers();
            List<(Soldier soldier, Shift shift)> scheduled = new List<(Soldier, Shift)>();

            foreach (var mission in deployment.Missions)
            {
                foreach (var shift in mission.Shifts)
                {
                    var available = allSoldiers
                        .Where(s => SoldierMeetsConstraints(s, mission) && IsAvailable(s, shift, scheduled, MinRestHours))
                        .OrderBy(s => s.TotalMissionsAssigned)
                        .ThenBy(s => s.TaskTypeCounts.ContainsKey(mission.Type) ? s.TaskTypeCounts[mission.Type] : 0)
                        .Take(mission.SoldiersPerShift)
                        .ToList();

                    if (available.Count < mission.SoldiersPerShift)
                        return false;

                    foreach (var soldier in available.Take(mission.SoldiersPerShift))
                    {
                        scheduled.Add((soldier, shift));
                    }
                }
            }

            return true;
        }

        private static bool SoldierMeetsConstraints(Soldier soldier, Mission mission)
        {
            if (soldier.Constraint == ConstraintType.No_Kitchen && mission.Type == Mission.TaskType.Kitchen)
                return false;

            if (soldier.Constraint == ConstraintType.Static_Only && !mission.IsStatic)
                return false;

            if (!(mission.Type == Mission.TaskType.Duty_Officer && 
                (soldier.SoldierRole != Soldier.Role.Platoon_Commander ||
                 soldier.SoldierRole != Soldier.Role.Deputy_Company_Commander ||
                 soldier.SoldierRole != Soldier.Role.Company_Commander))) 
                return false;

            if ((soldier.SoldierRole == Soldier.Role.Company_Commander ||
                soldier.SoldierRole == Soldier.Role.Medic ||
                soldier.SoldierRole == Soldier.Role.Platoon_Commander ||
                soldier.SoldierRole == Soldier.Role.Deputy_Company_Commander ||
                soldier.SoldierRole == Soldier.Role.Deputy_Logistics_Sergeant ||
                soldier.SoldierRole == Soldier.Role.Logistics_Sergeant) && 
                mission.Type == Mission.TaskType.Kitchen)
                return false;

            return true;
        }
    }
}
