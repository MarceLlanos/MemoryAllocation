using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IPacksFactory
    {
        void CreatePacks(IPackage package, IBlock block, List<IPackage> packages);
    }
}
