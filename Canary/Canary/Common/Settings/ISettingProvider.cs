using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canary.Common.Settings
{
    //Sources for Settings
    public interface ISettingProvider
    {
        string GetSetting(string key);

        IDictionary<string,string> GetAllSetting();
    }
}
