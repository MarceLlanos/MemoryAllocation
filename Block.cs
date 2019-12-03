using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Block : IBlock
    {
        int sizeBlock;
        List<IPackage> packages;

        public Block(int sizeBlock)
        {
            this.sizeBlock = sizeBlock;
            
        }

        public Block()
        {
            packages = new List<IPackage>();
        }

        public int GetSizeBlock()
        {
            return sizeBlock;
        }
        public void SetSizeBlock(int sizeBlock)
        {
            this.sizeBlock = sizeBlock;
        }

        public List<IPackage> GetPackages()
        {
            return packages;
        }
    }
}
