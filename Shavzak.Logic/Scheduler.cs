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

        public static int AssignSoldiers(Deployment deployment)
        {
            int missing = CalculateMissingSoldiers(deployment, minRestHours: 8);

            if (missing > 0)
            {
                return missing;
            }

            foreach (var mission in deployment.Missions)
            {
                foreach (var shift in mission.Shifts)
                {
                    var availableSoldiers = deployment.Company.GetSoldiers()
                        .Where(s => SoldierMeetsConstraints(s, mission))
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
                    }
                }
            }

            return missing;
        }

        private static bool IsAvailable(Soldier soldier, Shift newShift, List<(Soldier soldier, Shift shift)> scheduled, int minRestHours)
        {
            foreach (var (assignedSoldier, shift) in scheduled)
            {
                if (assignedSoldier != soldier)
                    continue;

                if (shift.OverlapsWith(newShift))
                    return false;

                var gap = (newShift.StartTime - shift.EndTime).Duration();
                if (gap.TotalHours < minRestHours)
                    return false;
            }
            return true;
        }

        public static int CalculateMissingSoldiers(Deployment deployment, int minRestHours)
        {
            List<Soldier> allSoldiers = deployment.Company.GetSoldiers();
            List<(Soldier soldier, Shift shift)> scheduled = new List<(Soldier, Shift)>();
            int totalMissing = 0;

            foreach (var mission in deployment.Missions)
            {
                foreach (var shift in mission.Shifts)
                {
                    var available = allSoldiers
                        .Where(s => SoldierMeetsConstraints(s, mission) && IsAvailable(s, shift, scheduled, minRestHours))
                        .ToList();

                    if (available.Count < mission.SoldiersPerShift)
                    {
                        totalMissing += (mission.SoldiersPerShift - available.Count);
                    }
                    else
                    {
                        foreach (var soldier in available.Take(mission.SoldiersPerShift))
                        {
                            scheduled.Add((soldier, shift));
                        }
                    }
                }
            }

            return totalMissing;
        }

        private static bool IsAvailable(Soldier soldier, Shift newShift, List<(Soldier soldier, Shift shift)> scheduled)
        {
            foreach (var (assignedSoldier, shift) in scheduled)
            {
                if (assignedSoldier != soldier)
                    continue;

                var gapBefore = newShift.StartTime - shift.EndTime;
                var gapAfter = shift.StartTime - newShift.EndTime;

                if (shift.OverlapsWith(newShift) || gapBefore.TotalHours < MinRestHours && gapBefore.TotalHours >= 0 ||
                    gapAfter.TotalHours < MinRestHours && gapAfter.TotalHours >= 0)
                {
                    return false;
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
