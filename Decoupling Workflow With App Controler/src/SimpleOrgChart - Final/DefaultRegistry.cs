using System.Windows.Forms;
using EventAggregator;
using SimpleOrgChart___Final.AppController;
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

			RegisterInterceptor(new EventAggregatorInterceptor());
		}

	}
}