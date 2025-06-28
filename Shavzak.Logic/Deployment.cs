using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    internal class Deployment
    {
        public Company Company { get; set; }
        public List<Task> Tasks { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Deployment(Company company, DateTime startDate, DateTime endDate)
        {
            Company = company;
            StartDate = startDate;
            EndDate = endDate;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public override string ToString()
        {
            return $"Deployment for company from {StartDate:dd/MM/yyyy} to {EndDate:dd/MM/yyyy}, {Tasks.Count} tasks assigned.";
        }
    }
}
