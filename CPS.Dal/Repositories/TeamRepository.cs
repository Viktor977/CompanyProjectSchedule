using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Interfaces;
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
        public Task AddAsync(Team entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Team entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Team>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDate(Team entity)
        {
            throw new NotImplementedException();
        }
    }
}
