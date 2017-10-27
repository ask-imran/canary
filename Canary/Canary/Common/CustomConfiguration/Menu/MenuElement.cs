using System;
using System.Configuration;

namespace Canary.Common.CustomConfiguration.Menu
{
    public class MenuElement : ConfigurationElement
    {
        [ConfigurationProperty("menuName", IsRequired = true)]
        public string Name
        {
            get { return (string)this["menuName"]; }
            set { this["menuName"] = value; }
        }

        [ConfigurationProperty("menuSrc", IsRequired = true)]
        public string MenuSrc
        {
            get { return (string)this["menuSrc"]; }
            set { this["menuSrc"] = value; }
        }

        [ConfigurationProperty("isActive", IsRequired = false, DefaultValue = false)]
        public bool IsActive
        {
            get { return (bool)this["isActive"]; }
            set { this["isActive"] = value; }
        }
    }
}