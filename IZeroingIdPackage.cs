﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IZeroingIdPackage
    {
        IPackage ZeroIdPackage(IBlock[] blocks, int idPackage);
    }
}
