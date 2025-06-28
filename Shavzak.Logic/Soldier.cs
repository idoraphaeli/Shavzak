using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak
{
    public class Soldier
    {
        public string FullName { get; set; }
        public Role SoldierRole { get; set; }
        public List<string> Constraints { get; set; }

        public Soldier(string fullName, Role role = Role.Fighter)
        {
            FullName = fullName;
            SoldierRole = role;
            Constraints = new List<string>();
        }

        public override string ToString()
        {
            return $"{FullName} - {SoldierRole}";
        }

        public enum Role
        {
            Driver,                 // נהג
            Fighter,                // לוחם
            Medic,                  // חובש
            SquadCommander,         // מפקד כיתה
            Sergeant,               // סמל
            PlatoonCommander,       // מפקד מחלקה
            DeputyLogisticsSergeant,// סרס"פ
            LogisticsSergeant,      // רס"פ
            DeputyCompanyCommander, // סמ"פ
            CompanyCommander        // מ"פ
        }
    }

}
