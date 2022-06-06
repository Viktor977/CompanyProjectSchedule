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
            _context.Projects.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(project);
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            var projects = await _context.Projects.ToListAsync();
            return projects;
        }

        public async Task<Project> GetByIdAsync(int id)
        {
            return await _context.Projects.FindAsync(id);
        }

        public void UpDate(Project entity)
        {
            _context.Projects.Update(entity);
        }
    }
}
