using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Repositories
{
   public class EmployeesInfoRepository : IEmployeesInfoRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public EmployeesInfoRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(EmployeesInfo entity)
        {
            await _context.EmployeesInfos.AddAsync(entity);
            _context.SaveChanges();
        }

        public void Delete(EmployeesInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeesInfo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeesInfo> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDate(EmployeesInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
