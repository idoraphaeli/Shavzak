using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    public class Constraint
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
            No_Kitchen,          // איסור על מטבח
            Static_Only          // רק משימות סטטיות
        }
    }
}
