using Shavzak.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shavzak.Logic.Constraint;

namespace Shavzak
{
    public class Soldier
    {
        public string FullName { get; set; }
        public Role SoldierRole { get; set; }
        public ConstraintType Constraint { get; set; }
        public PlatoonNumber PlatoonNum { get; set; }
        public Dictionary<Mission.TaskType, int> TaskTypeCounts { get; set; } = new Dictionary<Mission.TaskType, int>();
        public int TotalMissionsAssigned => TaskTypeCounts.Values.Sum();

        public Soldier(string fullName, Role role = Role.Fighter, ConstraintType constraint = ConstraintType.None, PlatoonNumber platoonNumber = PlatoonNumber.Headquarters)
        {
            FullName = fullName;
            SoldierRole = role;
            Constraint = constraint;
            PlatoonNum = platoonNumber;
        }

        public override string ToString()
        {
            return $"{FullName} - {SoldierRole}";
        }

        public enum Role
        {
            Fighter,                // לוחם
            Medic,                  // חובש
            Driver,                 // נהג
            Squad_Commander,         // מפקד כיתה
            Sergeant,               // סמל
            Platoon_Commander,       // מפקד מחלקה
            Deputy_Logistics_Sergeant,// סרס"פ
            Logistics_Sergeant,      // רס"פ
            Deputy_Company_Commander, // סמ"פ
            Company_Commander        // מ"פ
        }

        public enum PlatoonNumber
        {
            One = 1,
            Two = 2,
            Three = 3,
            Headquarters = 4
        }
    }

}
