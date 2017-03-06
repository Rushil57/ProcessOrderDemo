using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Repositories.Interface;
using Repositories;
using Core.Interface;
using Core;

namespace ProcessOrderDemo
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType(typeof(IUnitOfWork<>), typeof(UnitOfWork<>), new PerResolveLifetimeManager());
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>), new PerResolveLifetimeManager());
            container.RegisterType<IOrderService, OrderService>(new PerResolveLifetimeManager());
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            return container;
        }
    }
}