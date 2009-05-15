using System.Collections.Generic;
using SimpleOrgChart___Final.Model;

namespace SimpleOrgChart___Final.Repositories
{
	
	public class InMemoryEmployeeRepository: IEmployeeRepository
	{

		private static readonly IList<Employee> employeeList = new List<Employee>{new Employee("Bob", "Jones", "bob.jones@example.com")};

		public IList<Employee> GetEmployeeOrgChart()
		{
			return employeeList;
		}

		public void Save(Employee employee)
		{
			employeeList.Add(employee);
		}

	}

}
