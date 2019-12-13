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
            IAllocationAlgorithmFactory allocationAlgorithm = new AllocationAlgorithmFactory();
            IBlock[] blocks = new BlockFactory(new List<IPackage>()).createBlocks(blocksNumber, sizeBlock);

            var algorithmInstance = allocationAlgorithm.CreateAllocationAlgorithm(algorithm);

            IMemory memory = new Memory(blocks, algorithmInstance, new UnifierPackage());
           
            return memory;
        }
    }
}
