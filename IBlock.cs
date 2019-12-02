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
        void AddPackage(Package package);
        List<IPackage> GetListPackage();
    }
}
