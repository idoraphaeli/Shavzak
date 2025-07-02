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
        public static void AssignSoldiers(Deployment deployment)
        {
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
