using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IMemoryFactory
    {
        IMemory CreateMemory(int blocksNumber, int sizeBlock, string algorithm);
    }
}
