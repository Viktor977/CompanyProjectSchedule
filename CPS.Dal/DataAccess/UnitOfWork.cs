using CPS.Dal.Interfaces;
using CPS.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public UnitOfWork(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public IEmployeeRepository EmployeeRepository
        {
            get 
            {
                return new EmployeeRepository(_context);
            }
        }

        public IEmployeesInfoRepository EmployeeInfoRepository
        {
            get
            {
                return new EmployeesInfoRepository(_context);
            }
        }

        public IProjectRepository ProjectRepository
        {
            get
            {
                return new ProjectRepository(_context);
            }
        }

        public IProjectInfoRepository ProjectInfoRepository
        {
            get
            {
                return new ProjectInfoRepository(_context);
            }
        }

        public ITeamRepository TeamRepository
        {
            get
            {
                return new TeamRepository(_context);
            }
        }

        public IFlowStateRepository FlowStateRepository
        {
            get
            {
                return new FlowStateRepository(_context);
            }
        }

        public  async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
