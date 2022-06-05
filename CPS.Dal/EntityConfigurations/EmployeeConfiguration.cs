using CPS.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.FirstName).HasMaxLength(50);
            builder.Property(t => t.LastName).HasMaxLength(100);
            builder.Property(t => t.MainPosition).HasMaxLength(200);

            builder.HasOne(t => t.EmployeesInfo).WithOne(t => t.Employee).HasForeignKey<EmployeesInfo>(t=>t.EmploeeId);
            builder.HasOne(t => t.Project).WithMany(t => t.Employees).HasForeignKey(t => t.ProjectId);
        }
    }
}
