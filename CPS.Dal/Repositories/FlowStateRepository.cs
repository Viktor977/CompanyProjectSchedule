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
    public class FlowStateRepository : IFlowStateRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public FlowStateRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(FlowState entity)
        {
            await _context.FlowStates.AddAsync(entity);
        }

        public void Delete(FlowState entity)
        {
            _context.FlowStates.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var state = await _context.FlowStates.FindAsync(id);
            _context.FlowStates.Remove(state);
        }

        public async Task<IEnumerable<FlowState>> GetAllAsync()
        {
            var states = await _context.FlowStates.ToListAsync();
            return states;
        }

        public async Task<FlowState> GetByIdAsync(int id)
        {
            var state = await _context.FlowStates.FindAsync(id);
            return state;
        }

        public void UpDate(FlowState entity)
        {
            _context.FlowStates.Update(entity);
        }
    }
}
