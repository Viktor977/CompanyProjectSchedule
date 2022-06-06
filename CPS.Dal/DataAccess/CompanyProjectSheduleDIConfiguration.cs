using CPS.Dal.Interfaces;
using CPS.Dal.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.DataAccess
{
    public class CompanyProjectSheduleDIConfiguration
    {
        public static void ConfigurationServices(IServiceCollection collection)
        {
            collection.AddScoped<CompanyProjectScheduleDBContext>();
            collection.AddScoped<IUnitOfWork, UnitOfWork>();
            collection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            collection.AddScoped<IEmployeesInfoRepository, EmployeesInfoRepository>();
            collection.AddScoped<IFlowStateRepository, FlowStateRepository>();
            collection.AddScoped<IProjectRepository, ProjectRepository>();
            collection.AddScoped<IProjectInfoRepository, ProjectInfoRepository>();
            collection.AddScoped<ITeamRepository, TeamRepository>();
        }
    }
}
