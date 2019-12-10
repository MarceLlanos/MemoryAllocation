using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    interface IVacatePackages
    {
        List<IPackage> VacatedPackages(IBlock[] block, IPackage package);
    }
}
