using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    internal class Company
    {
        private List<Platoon> platoons;

        public Company()
        {
            platoons = new List<Platoon>();
        }

        public void AddPlatoon(Platoon platoon)
        {
            platoons.Add(platoon);
        }

        public List<Platoon> GetPlatoons()
        {
            return platoons;
        }
    }
}
