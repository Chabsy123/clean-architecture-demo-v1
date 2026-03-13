using clean_architecture_demo_v1.Core.Entities;
using clean_architecture_demo_v1.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture_demo_v1.App.Queries
{
    public record GetEmployeeByIdQuery(Guid EmployeeId) : IRequest<EmployeeEntity>;
    public class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);
        }
    }
}
