using Shavzak.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak
{
    public class AppState
    {
        public static Deployment CurrentDeployment { get; private set; }

        static AppState()
        {
            var start = DateTime.Today.AddDays(1).AddHours(6);
            var end = start.AddHours(24);
            CurrentDeployment = new Deployment(new Company(), start, end);
        }
    }
}
