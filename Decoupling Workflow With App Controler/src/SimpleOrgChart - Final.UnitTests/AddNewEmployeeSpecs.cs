using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;
using SimpleOrgChart___Final.App;
using SimpleOrgChart___Final.AppController;
using SimpleOrgChart___Final.Model;
using SpecUnit;

namespace SimpleOrgChart___Final.UnitTests
{
	public class AddNewEmployeeSpecs
	{

		public class KickoffAddNewEmployeeContext : ContextSpecification
		{

			private IEmployeeRepository employeeRepo;
			private IOrgChartView view;
			private IList<Employee> employeeList;
			private Employee bob;
			protected IApplicationController appController;

			protected override void SharedContext()
			{
				view = MockRepository.GenerateMock<IOrgChartView>();
				bob = new Employee("Bob", "Jones", "bob.jones@example.com");
				employeeList = new List<Employee> { bob };

				appController = MockRepository.GenerateMock<IApplicationController>();

				employeeRepo = MockRepository.GenerateMock<IEmployeeRepository>();
				employeeRepo.Stub(r => r.GetEmployeeOrgChart()).Return(employeeList);

			}

			protected OrgChartPresenter GetPresenter()
			{
				OrgChartPresenter presenter = new OrgChartPresenter(view, appController, employeeRepo);
				return presenter;
			}

		}

		[TestFixture]
		[Concern("Add New Employee")]
		public class When_requesting_to_add_a_new_employee : KickoffAddNewEmployeeContext
		{

			protected override void Context()
			{
				OrgChartPresenter presenter = GetPresenter();
				presenter.Run();

				presenter.AddNewEmployeeRequested();
			}

			[Test]
			[Observation]
			public void Should_kick_off_the_add_new_employee_process()
			{
				appController.AssertWasCalled(c => c.Execute<AddNewEmployeeCommand>(null), mo => mo
					.IgnoreArguments()
					.Constraints(Is.TypeOf<AddNewEmployeeCommand>())
				);
			}

		}

	}
}
