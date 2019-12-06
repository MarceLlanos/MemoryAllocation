using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BlockFactory : IBlockFactory
    {
        public IBlock[] createBlocks(int blocksNumber, int sizeBlock)
        {
            if (blocksNumber == 0 || sizeBlock == 0 )
            {
                return null;
            }

            IBlock[] blocks= new Block[blocksNumber];

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new Block(sizeBlock: sizeBlock);
            }

            return blocks;
        }
    }
}
