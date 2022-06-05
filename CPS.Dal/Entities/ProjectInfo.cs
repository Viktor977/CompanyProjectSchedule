using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class ProjectInfo :BaseEntity
    {
        public int FlowState { get; set; }
        public DateTime DateEnd { get; set; }
        public virtual IEnumerable<FlowState> States { get; set; }
    }
}
