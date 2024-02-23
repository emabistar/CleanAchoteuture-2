using System;
using DomainEmployee.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ArchitectureEmployee.Data
{
	public class EmployeeContext :DbContext
	{
		public EmployeeContext()
		{

		}
		
        public EmployeeContext(DbContextOptions<EmployeeContext>option)
			:base(option)

		{
		}
		public DbSet<Employee> Employees { get; set; }
	}
}



