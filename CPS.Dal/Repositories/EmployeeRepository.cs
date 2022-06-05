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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyProjectScheduleDBContext _context;
        public EmployeeRepository(CompanyProjectScheduleDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Employee entity)
        {
           await _context.Employees.AddAsync(entity);
        }

        public  void Delete(Employee entity)
        {
             _context.Employees.Remove(entity);
        }

        public async  Task DeleteByIdAsync(int id)
        {
           var employee= await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
                
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return  employees;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return employee;
        }

        public void UpDate(Employee entity)
        {
            _context.Employees.Update(entity);
            _context.SaveChanges();
        }
    }
}
