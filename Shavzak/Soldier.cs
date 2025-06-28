using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak
{
    internal class Soldier
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public List<string> Constraints { get; set; }
        public List<string> Preferences { get; set; }

        public Soldier(string fullName, string role = "לוחם")
        {
            FullName = fullName;
            Role = role;
            Constraints = new List<string>();
            Preferences = new List<string>();
        }
    }
}
