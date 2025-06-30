using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    public class Deployment
    {
        public Company Company { get; set; }
        public List<Mission> Missions { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Deployment(Company company, DateTime startDate, DateTime endDate)
        {
            Company = company;
            StartDate = startDate;
            EndDate = endDate;
            Missions = new List<Mission>();
        }

        public void AddMission(Mission mission)
        {
            Missions.Add(mission);
        }

        public override string ToString()
        {
            return $"Deployment for company from {StartDate:dd/MM/yyyy} to {EndDate:dd/MM/yyyy}, {Missions.Count} tasks assigned.";
        }
    }
}
