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
            IAlgorithmFactory creatorAlgorithm = new AlgorithmFactory();
            IBlock[] blocks = new BlockFactory().createBlocks(blocksNumber, sizeBlock);
            var algorithmInstance = creatorAlgorithm.CreateAlgorithm(algorithm);

            IMemory memory = new Memory(blocks, algorithmInstance);
            return memory;
        }
    }
}
