using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IValidatePackagesFactory
    {
        List<IPackage> CreateValidPackages(IBlock block, IPackage package);
    }
}
