using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Tests
{
    internal static class UnitTestsHelper
    {
        public static DbContextOptions<CompanyProjectScheduleDBContext>GetUnitTestDbOption()
        {
            var option = new DbContextOptionsBuilder<CompanyProjectScheduleDBContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())            
                .Options;
            using(var context=new CompanyProjectScheduleDBContext(option))
            {
                SeedData(context);
            }

            return option;

        }

        public static void SeedData(CompanyProjectScheduleDBContext context)
        {
            context.EmployeesInfos.AddRange(
            new EmployeesInfo { Id = 1, EmploeeId = 1, Email = "emailOne@one.com", Password = "qwertyuOne", Phone = "+38(068)234-34-31", Role = Role.user },
            new EmployeesInfo { Id = 2, EmploeeId = 2, Email = "emailTwo@one.com", Password = "qwertyuTwo", Phone = "+38(068)234-34-32", Role = Role.user },
            new EmployeesInfo { Id = 3, EmploeeId = 3, Email = "emailThree@one.com", Password = "qwertyuthree", Phone = "+38(068)234-34-33", Role = Role.user }
            ); 

            context.Employees.AddRange(
                new Employee { Id = 1, FirstName = "Name1", LastName = "LName1",MainPosition="developer",ProjectId=1},
                new Employee { Id = 2, FirstName = "Name2", LastName = "LName3",MainPosition="developer",ProjectId=2},
                new Employee { Id = 3, FirstName = "Name3", LastName = "LName3",MainPosition="developer",ProjectId=3}
                );

            context.Projects.AddRange(
                new Project { Id=1,DateStart=new DateTime(2020,06,10),ProjectName="SummerSpring",TeamId=1,Term=30},
                new Project { Id=2,DateStart=new DateTime(2020,11,10),ProjectName="WinterSpring",TeamId=1,Term=30},
                new Project { Id=3,DateStart=new DateTime(2020,09,10),ProjectName="AutumnSpring",TeamId=1,Term=30}
                );
            context.Teams.AddRange(
                new Team { Id=1,EmploeeId=1,ProjectPosition="tester"},
                new Team { Id=2,EmploeeId=2,ProjectPosition="tester"},
                new Team { Id=3,EmploeeId=3,ProjectPosition="tester"}
                );
            context.ProjectInfos.AddRange(
                new ProjectInfo { Id=1,ProjectId=1,DateEnd=new DateTime(2020,07,01),FlowStateId=1},
                new ProjectInfo { Id=2,ProjectId=2,DateEnd=new DateTime(2020,12,01),FlowStateId=1},
                new ProjectInfo { Id=3,ProjectId=3,DateEnd=new DateTime(2020,10,01),FlowStateId=1}
                );
            context.FlowStates.AddRange(
                new FlowState { Id = 1, EmploeeId = 1, Status = StatusTask.needsImprovement,DateChange=new DateTime(2020,06,20) },
                new FlowState { Id = 2, EmploeeId = 2, Status = StatusTask.completed,DateChange=new DateTime(2020,10,29) },
                new FlowState { Id = 3, EmploeeId = 3, Status = StatusTask.open,DateChange=new DateTime(2020,10,10) }
                );

            context.SaveChanges();
        }
    }
}
