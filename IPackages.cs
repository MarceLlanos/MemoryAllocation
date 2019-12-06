using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IPackages
    {
        List<IPackage> PackagesAvailable(IBlock[] blocks, IPackage package);
    }
}
