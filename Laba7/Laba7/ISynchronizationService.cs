using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    public interface ISynchronizationService
    {
        void PerformAction(string user, string action);
    }
}
