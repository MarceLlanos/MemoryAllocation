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
        IAllocationMemoryAlgorithm memoryFirstAlgorithm = new FirstSettingAlgorithm();

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
