using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class Team :BaseEntity
    {
        public int EmploeeId { get; set; }
        public string ProjectPosition { get; set; }
    }
}
