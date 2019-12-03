using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class Memory : IMemory
    {
        IBlock[] blocks;
        IAllocationMemoryAlgorithm allocationAlgorithm;

        public Memory(IBlock[] blocks, IAllocationMemoryAlgorithm allocationAlgorithm)
        {
            this.blocks = blocks;
            this.allocationAlgorithm = allocationAlgorithm;
        }

        public IPackage AddPackageToMemory(int sizePackage)
        {
            IPackage package = new CreatorPackage().CreatePackage(sizePackage);
            return package;
        }

        public IPackage DeleteById(int idPackage)
        {
            throw new NotImplementedException();
        }

        public void showMemory()
        {
            throw new NotImplementedException();
        }
    }
}
