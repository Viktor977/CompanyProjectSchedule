using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class ProjectInfo :BaseEntity
    {
        public int FlowStateId { get; set; }
        public DateTime DateEnd { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public FlowState FlowState { get; set; }
    }
}
