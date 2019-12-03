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
            ICreatorAlgorithm creatorAlgorithm = new CreatorAlgorithm();
            IBlock[] blocks = new CreatorBlock().createBlocks(blocksNumber, sizeBlock);
            var algorithmInstance = creatorAlgorithm.CreateAlgorithm(algorithm);

            IMemory memory = new Memory(blocks, algorithmInstance);
            return memory;
        }
    }
}
