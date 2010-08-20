﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.Core {
    // Non hardware class, only used by core and hardware drivers for ports etc.
    public class CPU {
        // Amount of RAM in MB's.
        protected static uint GetAmountOfRAM() { return 0; } // Plugged
        protected static uint GetEndOfKernel() { return 0; } // Plugged
        public static void CreateGDT() { } // Plugged
        public static void CreateIDT(bool aEnableInterruptsImmediately) { } // Plugged
        public static void InitFloat() { } // Plugged
    }
}
