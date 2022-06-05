using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Interfaces
{
   public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get;  }
        IEmployeesInfoRepository EmployeeInfoRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IProjectInfoRepository ProjectInfoRepository { get; }
        ITeamRepository TeamRepository { get; }
        IFlowStateRepository FlowStateRepository { get; }
        Task SaveAsync();
    }
}
