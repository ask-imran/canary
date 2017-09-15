using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;

namespace Canary.App_Start
{
    public class IocConfigurator
    {
        public static void Configure()
        {
            IUnityContainer _unityContainer = new UnityContainer();
            RegisterDependencies(_unityContainer);
        }
        private static void RegisterDependencies(IUnityContainer _unityContainer)
        {
            throw new NotImplementedException();
        }
    }
}