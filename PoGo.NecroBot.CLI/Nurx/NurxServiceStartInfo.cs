﻿using PoGo.NecroBot.Logic;
using PoGo.NecroBot.Logic.State;
using PoGo.NecroBot.Logic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGo.NecroBot.CLI.Nurx
{
    /// <summary>
    /// Container class for NurxService initializtion.
    /// </summary>
    class NurxServiceStartInfo
    {
        public Session Session { get; set; }
        public GlobalSettings Settings { get; set; }
        public ConsoleLogger Logger { get; set; }
        public Statistics Statistics { get; set; }        
    }
}