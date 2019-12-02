using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IMemory
    {
        IPackage AddToBlocksOfMemory(int sizePackage);
        IPackage DeleteById(int idPackage);
        void showMemory();
    }
}
