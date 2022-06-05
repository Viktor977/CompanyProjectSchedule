using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
   public class Project : BaseEntity
    {
        public string ProjectName { get; set; }
        public DateTime DateStart { get; set; }
        public int Term { get; set; }
     
        public virtual ProjectInfo ProjectInfo { get; set; }
        public int TeamId { get; set; }
        public virtual Team CarentTeam { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
      
    }
}
