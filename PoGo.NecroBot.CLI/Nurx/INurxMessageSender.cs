using PoGo.NecroBot.Logic.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGo.NecroBot.CLI.Nurx
{
    interface INurxMessageSender
    {
        void RegisterSender(Session pogoSession, NurxService service);
    }
}
