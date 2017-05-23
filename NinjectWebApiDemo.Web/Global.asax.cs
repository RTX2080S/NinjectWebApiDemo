using Ninject.Web.Common;
using System.Web;
using System.Web.Http;
using Ninject;
using System;
using NinjectWebApiDemo.Repo.Interfaces;
using NinjectWebApiDemo.Repo;

namespace AspNetWebApiDemo
{
    public class WebApiApplication : NinjectHttpApplication
    {
        /// <summary>
        /// Move the code from Application_Start()
        /// </summary>
        protected override void OnApplicationStarted()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);

            // Install our Ninject-based IDependencyResolver into the Web API config
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

            return kernel;
        }

        private void RegisterServices(StandardKernel kernel)
        {
            // This is where we tell Ninject how to resolve service requests
            kernel.Bind<IAnimalRepository>().To<AnimalRepository>();
        }
    }
}
