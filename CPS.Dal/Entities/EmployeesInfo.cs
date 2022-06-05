using CPS.Dal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.Entities
{
    public class EmployeesInfo : BaseEntity
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; }
        public int EmploeeId { get; set; }
        public virtual Employee Employee { get; set; }
        
    }
}
