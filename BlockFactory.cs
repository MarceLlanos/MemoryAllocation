using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BlockFactory : IBlockFactory
    {
        List<IPackage> packages;

        public BlockFactory(List<IPackage> packages)
        {
            this.packages = packages;
        }

        public IBlock[] createBlocks(int blocksNumber, int sizeBlock)
        {
            IBlock[] blocks= new Block[blocksNumber];

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new Block(sizeBlock, new PackageInserter());
            }

            return blocks;
        }
    }
}
