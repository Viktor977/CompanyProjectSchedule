using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public async Task AddAsync(ProjectInfo entity)
        {
            await _context.ProjectInfos.AddAsync(entity);

        }

        public void Delete(ProjectInfo entity)
        {
            _context.ProjectInfos.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var projectInfo = await _context.ProjectInfos.FindAsync(id);
            _context.ProjectInfos.Remove(projectInfo);
        }

        public async Task<IEnumerable<ProjectInfo>> GetAllAsync()
        {
            var projectInfoes = await _context.ProjectInfos.ToListAsync();
            return projectInfoes;
        }

        public async Task<ProjectInfo> GetByIdAsync(int id)
        {
            var projectInfo = await _context.ProjectInfos.FindAsync(id);
            return projectInfo;
        }

        public void UpDate(ProjectInfo entity)
        {
            _context.ProjectInfos.Update(entity);
        }
    }
}
