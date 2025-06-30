using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    public class Company
    {
        private List<Soldier> Soldiers;

        public Company()
        {
            Soldiers = new List<Soldier>();
        }

        public void AddSoldier(Soldier newSoldier)
        {
            Soldiers.Add(newSoldier);
        }

        public List<Soldier> GetSoldiers()
        {
            return Soldiers;
        }

        public bool RemoveSoldierByName(string fullName)
        {
            var soldier = Soldiers.FirstOrDefault(s => s.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
            if (soldier != null)
            {
                Soldiers.Remove(soldier);
                return true;
            }
            return false;
        }
    }
}
