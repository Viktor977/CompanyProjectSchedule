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
            _context.EmployeesInfos.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
           var emploeeInfo= await _context.EmployeesInfos.FindAsync(id);
            _context.EmployeesInfos.Remove(emploeeInfo);
        }

        public async Task<IEnumerable<EmployeesInfo>> GetAllAsync()
        {
            var emploeeInfo = await _context.EmployeesInfos.ToListAsync();
            return emploeeInfo;
        }

        public async Task<EmployeesInfo> GetByIdAsync(int id)
        {
            var emploesInfo = await _context.EmployeesInfos.FindAsync(id);
            return emploesInfo;
        }

        public void UpDate(EmployeesInfo entity)
        {
            _context.EmployeesInfos.Update(entity);
        }
    }
}
