using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public ProjectRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Project entity)
        {
            await _context.Projects.AddAsync(entity);
        }

        public void Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDate(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}
