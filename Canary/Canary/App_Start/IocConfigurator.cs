using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace Canary.App_Start
{
    public class IocConfigurator
    {
        public static void Configure()
        {
            IUnityContainer _unityContainer = new UnityContainer();
            RegisterDependencies(_unityContainer);
            DependencyResolver.SetResolver(new UnityDependencyResolver(_unityContainer));
        }
        private static void RegisterDependencies(IUnityContainer _unityContainer)
        {
            throw new NotImplementedException();
        }
    }
}