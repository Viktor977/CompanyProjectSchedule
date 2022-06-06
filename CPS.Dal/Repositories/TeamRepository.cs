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
    public class TeamRepository : ITeamRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public TeamRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Team entity)
        {
            await _context.Teams.AddAsync(entity);
        }

        public void Delete(Team entity)
        {
            _context.Teams.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            _context.Teams.Remove(team);

        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetByIdAsync(int id)
        {
            return await _context.Teams.FindAsync(id);
        }

        public void UpDate(Team entity)
        {
            _context.Teams.Update(entity);
        }
    }
}
