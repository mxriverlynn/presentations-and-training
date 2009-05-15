namespace SimpleOrgChart___Final.Model
{
	public class Employee
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Email { get; private set; }

		public Employee(string firstName, string lastName, string email)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
		}
	}
}