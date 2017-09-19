using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canary.Common.Helpers
{
    public interface IViewHelper
    {
        string GetLayoutPath(string layoutFileName = null);
    }
}
