using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IBlock
    {
        int GetSizeBlock();
        void SetSizeBlock(int sizeBlock);
        List<IPackage> GetPackages();
    }
}
