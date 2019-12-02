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
        IAllocationMemoryAlgorithm memoryAlgorithm;

        public IPackage AddToBlocksOfMemory(int sizePackage)
        {
            IPackage package = new Package(sizePackage);
            foreach (var item in blocks)
            {
                
            }
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
