using CPS.Dal.DataAccess;
using CPS.Dal.Entities;
using CPS.Dal.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Tests.DataTests
{
    [TestFixture]
    public class EmploeeRepositoryTests
    {
        [Test]
        public async Task EmploeeRepository_AddAsync_AddValueToDaneBase()     
        {
            //Arrange
            using var context = new CompanyProjectScheduleDBContext(UnitTestsHelper.GetUnitTestDbOption());
            var employeeRepositiry = new EmployeeRepository(context);
            var employee = new Employee { Id = 4, MainPosition = "PM" };

            //Act
            await employeeRepositiry.AddAsync(employee);
            await context.SaveChangesAsync();

            //Assert
            Assert.That(context.Employees.Count(), Is.EqualTo(4), message: "Method AddAsync work incorrect");

        }
    }
}
