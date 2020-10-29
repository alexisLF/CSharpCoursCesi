using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation
{
    public enum State
    {
        Welcome,
        InsertCard,
        PutCode,
        PullCard,
        ChooseTypeFuel,
        TakeFuel,
        InProgress,
        Thanks
    }
}
