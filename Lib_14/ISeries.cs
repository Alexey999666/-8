using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_14
{
    internal interface ISeries
    {

        int GetNext();
        void Reset();
        void SetStart(int startNumber);

    }
}
