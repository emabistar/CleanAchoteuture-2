using System;
using ApllicationEqmployee.Dtos;
using DomainEmployee.Entities;

namespace ApllicationEqmployee.Contracts
{
	public interface IEmployee
	{
		Task<EmployeeResponse> AddAsync(Employee employee);
        Task<EmployeeResponse>UpdateAsync(Employee employee);
        Task<EmployeeResponse> deleteAsync(int id);
        Task<List<Employee>>GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
    }
}

