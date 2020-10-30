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
        PullPump,
        TakeFuel,
        InProgress,
        Thanks,
        ErrorPump,
        ErrorCode,
    }
}
