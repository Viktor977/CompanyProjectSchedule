using CPS.Dal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class FlowState : BaseEntity
    {
        public int EmploeeId { get; set; }
        public DateTime DateChange { get; set; }
        public StatusTask Status { get; set; }
      
        public ICollection<ProjectInfo> ProjectInfo { get; set; }
       
    }
}
