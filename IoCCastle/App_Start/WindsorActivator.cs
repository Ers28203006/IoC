using System;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(IoCCastle.App_Start.WindsorActivator), "PreStart")]
[assembly: ApplicationShutdownMethodAttribute(typeof(IoCCastle.App_Start.WindsorActivator), "Shutdown")]

namespace IoCCastle.App_Start
{
    public static class WindsorActivator
    {
        static ContainerBootstrapper bootstrapper;

        public static void PreStart()
        {
            bootstrapper = ContainerBootstrapper.Bootstrap();
        }
        
        public static void Shutdown()
        {
            if (bootstrapper != null)
                bootstrapper.Dispose();
        }
    }
}