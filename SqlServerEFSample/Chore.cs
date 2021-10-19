using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerEFSample
{
    public class Chore
    {
        public int ChoreId { get; set; }
        public string ChoreName { get; set; }
        public string ChoreAssignment { get; set; }
        public bool IsComplete { get; set; }
        public virtual User AssignedTo { get; set; }

        public override string ToString()
        {
            return "Chore [id=" + this.ChoreId + ", name=" + this.ChoreName + "assignment=" + this.ChoreAssignment + "IsComplete" + this.IsComplete + "]";
        }
    }
}
