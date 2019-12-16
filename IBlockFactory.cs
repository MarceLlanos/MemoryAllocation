﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IBlockFactory
    {
        IBlock[] CreateBlocks(int blocksNumber, int sizeBlock);
    }
}
