using Pristine_REST_API.Domain.Entities;

namespace Pristine_REST_API.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Employee CreateEmployee(Employee employee);
        IQueryable<Employee> GetEmployees();
        Task<Employee?> GetByEmployeeId(int employeeId);
        Employee UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}
