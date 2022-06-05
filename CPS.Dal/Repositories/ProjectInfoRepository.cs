using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Repositories
{
    public class ProjectInfoRepository : IProjectInfoRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public ProjectInfoRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public Task AddAsync(ProjectInfo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProjectInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProjectInfo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectInfo> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDate(ProjectInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
