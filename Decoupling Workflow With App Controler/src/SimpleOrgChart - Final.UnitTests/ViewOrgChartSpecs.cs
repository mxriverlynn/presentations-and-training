using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using SimpleOrgChart___Final.App;
using SpecUnit;

namespace SimpleOrgChart___Final.UnitTests
{

	public class ViewOrgChartSpecs
	{

		public class ViewOrgChartSpecsContext : ContextSpecification
		{
			
			protected IOrgChartView view;
			protected IList<Employee> employeeList;

			protected override void SharedContext()
			{
				view = MockRepository.GenerateMock<IOrgChartView>();
				employeeList = new List<Employee>{new Employee("Bob", "Jones", "bob.jones@example.com")};
			}

			protected OrgChartPresenter GetPresenter()
			{
				OrgChartPresenter presenter = new OrgChartPresenter(view);
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

	}

}
