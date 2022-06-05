using CPS.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.EntityConfigurations
{
     public class EmployeesInfoConfiguration : IEntityTypeConfiguration<EmployeesInfo>
    {
        public void Configure(EntityTypeBuilder<EmployeesInfo> builder)
        {
            builder.Property(t => t.Email).HasMaxLength(100);
            builder.Property(t => t.Password).HasMaxLength(100);
            builder.Property(t => t.Phone).HasMaxLength(100);
            
        }
    }
}
