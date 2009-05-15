using System.Windows.Forms;
using EventAggregator;
using SimpleOrgChart___Final.App;
using SimpleOrgChart___Final.App.NewEmployeeProcess;
using SimpleOrgChart___Final.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart___Final.App.NewEmployeeProcess.SupplyEmployeeInfo;
using SimpleOrgChart___Final.AppController;
using SimpleOrgChart___Final.Model;
using SimpleOrgChart___Final.Repositories;
using SimpleOrgChart___Final.View;
using StructureMap.Configuration.DSL;

namespace SimpleOrgChart___Final
{

	public class DefaultRegistry : Registry
	{

		public DefaultRegistry()
		{
			ForRequestedType<ApplicationContext>()
				.TheDefault.Is.OfConcreteType<AppContext>();

			ForRequestedType<IApplicationController>()
				.TheDefault.Is.OfConcreteType<ApplicationController>();

			ForRequestedType<IEventPublisher>()
				.AsSingletons()
				.TheDefault.Is.OfConcreteType<EventPublisher>();

			ForRequestedType<IOrgChartView>()
				.TheDefaultIsConcreteType<MainForm>()
				.OnCreation((i,v) => i.GetInstance<EmployeeDetailPresenter>());

			ForRequestedType<IEmployeeRepository>()
				.TheDefaultIsConcreteType<InMemoryEmployeeRepository>();

			ForRequestedType<IEmployeeDetailView>()
				.TheDefaultIsConcreteType<ViewEmployeeDetailControl>();

			ForRequestedType<IAddNewEmployeeService>()
				.TheDefaultIsConcreteType<AddNewEmployeeService>();

			ForRequestedType<ICommand<AddNewEmployeeData>>()
				.TheDefaultIsConcreteType<AddNewEmployeeCommand>();

			ForRequestedType<IGetNewEmployeeInfo>()
				.TheDefaultIsConcreteType<NewEmployeeInfoPresenter>();

			ForRequestedType<INewEmployeeInfoView>()
				.TheDefaultIsConcreteType<NewEmployeeInfoForm>();

			ForRequestedType<IGetEmployeeManager>()
				.TheDefaultIsConcreteType<SelectEmployeeManagerPresenter>();

			ForRequestedType<ISelectEmployeeManagerView>()
				.TheDefaultIsConcreteType<SelectEmployeeManagerForm>();

			RegisterInterceptor(new EventAggregatorInterceptor());
		}

	}

}