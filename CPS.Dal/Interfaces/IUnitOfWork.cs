using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Interfaces
{
    interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get;  }
        IEmployeeInfoRepository EmployeeInfoRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IProjectInfoRepository ProjectInfoRepository { get; }
        ITeamRepository TeamRepository { get; }
        IFlowStateRepository FlowStateRepository { get; }
        Task SaveAsync();
    }
}
