using CPS.Dal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class FlowState : BaseEntity
    {
        public int EmloeeId { get; set; }
        public DateTime DateChange { get; set; }
        public StatusTask Status { get; set; }

    }
}
