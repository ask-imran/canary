using System;
using System.Configuration;

namespace Canary.Common.CustomConfiguration.Menu
{
    [ConfigurationCollection(typeof(MenuElement))]
    public class MenuElementCollection : ConfigurationElementCollection
    {
        public MenuElement this[int index]
        {
            get { return (MenuElement)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MenuElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MenuElement)element).Name;
        }
    }
}