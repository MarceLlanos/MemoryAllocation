using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class CreatorMemory : ICreatorMemory
    {
        public IMemory CreateMemory(int blocksNumber, int sizeBlock, string algorithm)
        {
            IMemory memory = new Memory();
            
        }
    }
}
