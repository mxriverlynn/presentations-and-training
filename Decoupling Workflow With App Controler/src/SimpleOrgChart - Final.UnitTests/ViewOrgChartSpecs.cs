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

	public class ViewOrgChartSpecs
	{

		public class ViewOrgChartSpecsContext : ContextSpecification
		{
			private IEmployeeRepository employeeRepo;
			protected IOrgChartView view;
			protected IList<Employee> employeeList;
			protected Employee bob;
			protected IApplicationController appController;

			protected override void SharedContext()
			{
				view = MockRepository.GenerateMock<IOrgChartView>();
				bob = new Employee("Bob", "Jones", "bob.jones@example.com");
				employeeList = new List<Employee>{bob};

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
		[Concern("View Org Chart")]
		public class When_viewing_the_org_chart : ViewOrgChartSpecsContext
		{

			protected override void Context()
			{
				OrgChartPresenter presenter = GetPresenter();
				presenter.Run();
			}

			[Test]
			[Observation]
			public void Should_show_the_hiearchy_of_employees()
			{
				view.AssertWasCalled(v => v.DisplayEmployeeHierarchy(employeeList));
			}

		}

		[TestFixture]
		[Concern("View Org Chart")]
		public class When_selecting_an_employee : ViewOrgChartSpecsContext
		{

			protected override void Context()
			{
				OrgChartPresenter presenter = GetPresenter();
				presenter.Run();

				presenter.EmployeeSelected(bob);
			}

			[Test]
			[Observation]
			public void Should_send_notification_of_the_selected_employee()
			{
				appController.AssertWasCalled(c => c.Raise<EmployeeSelectedEvent>(null), mo => mo
					.IgnoreArguments()
					.Constraints(Is.TypeOf<EmployeeSelectedEvent>())
				);
			}

		}

	}

}
