using System;
using System.Configuration;
using Canary.Common.CustomConfiguration.Menu;

namespace Canary.Common.CustomConfiguration
{
    public class CustomConfiguration
    {
        public static MenuSection _MenuConfig = ConfigurationManager.GetSection("menuSettings") as MenuSection;

        public static MenuElementCollection GetAvailableMenus()
        {
            return _MenuConfig.MenuList;
        }
    }
}