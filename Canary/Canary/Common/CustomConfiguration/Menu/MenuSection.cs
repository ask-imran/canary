using System;
using System.Configuration;

namespace Canary.Common.CustomConfiguration.Menu
{
    public class MenuSection : ConfigurationSection
    {
        [ConfigurationProperty("menu")]
        public MenuElementCollection MenuList
        {
            get { return (MenuElementCollection)this["menu"]; }
        }
    }
}