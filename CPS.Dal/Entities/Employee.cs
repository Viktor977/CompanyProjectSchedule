using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MainPosition { get; set; }
     
        public virtual EmployeesInfo EmployeesInfo { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

    }
}
