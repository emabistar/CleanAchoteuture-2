﻿using System;
using ApllicationEqmployee.Contracts;
using ApllicationEqmployee.Dtos;
using ArchitectureEmployee.Data;
using DomainEmployee.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureEmployee.Implementation
{
	public class EmployeeRepos:IEmployee
	{
        private readonly EmployeeContext _context;
		public EmployeeRepos(EmployeeContext context)
		{
            _context = context;

		}

        public async Task<EmployeeResponse> AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await SaveAsync();
            return new EmployeeResponse(true , "Employeee added");
        }

        public async Task<EmployeeResponse> deleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee == null)
                return new EmployeeResponse(false ,"User not found");
            _context.Employees.Remove(employee); 
            await SaveAsync();
            return new EmployeeResponse(true, "Employee deleted");
        }

        public async Task<List<Employee>> GetAllAsync()
        {
           return  await _context.Employees.AsNoTracking().ToListAsync();



        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
           
        }

        public async Task<EmployeeResponse> UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await SaveAsync();
            return new EmployeeResponse(true, "Employee Updated");
        }
        private async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

