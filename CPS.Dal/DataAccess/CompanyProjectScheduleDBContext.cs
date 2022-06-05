using CPS.Dal.Entities;
using CPS.Dal.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.DataAccess
{
   public  class CompanyProjectScheduleDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeesInfo> EmployeesInfos { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectInfo> ProjectInfos { get; set; }
        public DbSet<FlowState> FlowStates { get; set; }

        public CompanyProjectScheduleDBContext(DbContextOptions<CompanyProjectScheduleDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeesInfoConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectInfoConfiguration());
            modelBuilder.ApplyConfiguration(new FlowStateConfiguration());
        }
    }
}
