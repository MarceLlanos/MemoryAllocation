using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class MemoryFactory : IMemoryFactory
    {
        public IMemory CreateMemory(int blocksNumber, int sizeBlock, string algorithm)
        {
            IBlock[] blocks = new BlockFactory(new List<IPackage>()).CreateBlocks(blocksNumber, sizeBlock);

            var fitAlgorithm = new AllocationAlgorithmFactory().CreateAllocationAlgorithm(algorithm);

            var memory = new Memory(blocks, fitAlgorithm, new UnifierPackage(), new ZeroingIdPackage());
           
            return memory;
        }
    }
}
