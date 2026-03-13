using clean_architecture_demo_v1.App.Events;
using clean_architecture_demo_v1.Core.Entities;
using clean_architecture_demo_v1.Core.Interfaces;
using MediatR;

namespace clean_architecture_demo_v1.App.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository, IPublisher mediator)
        : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var user = await employeeRepository.AddEmployeeAsync(request.Employee);
            await mediator.Publish(new UserCreatedEvent(user.Id));
            return user;
        }
    }
}
