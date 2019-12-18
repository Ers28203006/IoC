using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IoCCastle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCCastle.Installers
{
    public class LanguageInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                .Register(Component.For<ILanguage>()
                .ImplementedBy<Russian>()
                .LifestyleSingleton());
        }
    }
}