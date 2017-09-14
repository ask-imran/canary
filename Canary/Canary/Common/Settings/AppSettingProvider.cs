using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Canary.Common.Settings
{
    public class AppSettingProvider : ISettingProvider
    {
        public string GetSetting(string key)
        {
          return ConfigurationManager.AppSettings[key];
        }

        public IDictionary<string, string> GetAllSetting()
        {
            throw new NotImplementedException();
        }
    }
}