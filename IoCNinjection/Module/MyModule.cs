using IoCNinjection.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCNinjection.Module
{
    public class MyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILanguage>().To<Russian>();
        }
    }
}