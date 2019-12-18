using IoCNinjection.Module;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCNinjection.Controllers
{
    public class BaseController:Controller
    {
        protected IKernel kernel;
        public BaseController()
        {
            kernel = new StandardKernel(new MyModule());
        }
    }
}