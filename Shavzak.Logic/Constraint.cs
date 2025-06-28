using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    internal class Constraint
    {
        public ConstraintType Type { get; set; }

        public Constraint(ConstraintType type = ConstraintType.None)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type.ToString();
        }

        public enum ConstraintType
        {
            None,               // אין אילוץ (deafult)
            NoKitchen,          // איסור על מטבח
            StaticOnly          // רק משימות סטטיות
        }
    }
}
