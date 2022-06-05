using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Repositories
{
    public class FlowStateRepository : IFlowStateRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public FlowStateRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public Task AddAsync(FlowState entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FlowState entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FlowState>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FlowState> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDate(FlowState entity)
        {
            throw new NotImplementedException();
        }
    }
}
