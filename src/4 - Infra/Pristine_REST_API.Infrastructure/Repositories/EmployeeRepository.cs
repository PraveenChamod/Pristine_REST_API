using Microsoft.EntityFrameworkCore;
using Pristine_REST_API.Application.Interfaces.Repositories;
using Pristine_REST_API.Domain.Entities;
using Pristine_REST_API.Infrastructure.Context;

namespace Pristine_REST_API.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Employee CreateEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return employee;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var employee =  await _dbContext.Employees.FindAsync(employeeId);
            if (employee != null) _dbContext.Employees.Remove(employee);
        }

        public async Task<Employee?> GetByEmployeeId(int employeeId)
        {
            return await _dbContext.Employees
                            .AsNoTracking()
                            .FirstOrDefaultAsync<Employee>(e => e.Id == employeeId)
                            ?? throw new InvalidOperationException($"Employee with ID {employeeId} not found.");
        }

        public IQueryable<Employee> GetEmployees()
        {
            return _dbContext.Employees.AsNoTracking();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            return employee;
        }
    }
}
