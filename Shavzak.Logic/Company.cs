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
    }
}
