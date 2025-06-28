using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    internal class Platoon
    {
        public PlatoonNumber Number { get; private set; }
        private List<Soldier> soldiers;

        public Platoon(PlatoonNumber number)
        {
            Number = number;
            soldiers = new List<Soldier>();
        }

        public void AddSoldier(Soldier soldier)
        {
            soldiers.Add(soldier);
        }

        public List<Soldier> GetSoldiers()
        {
            return soldiers;
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

