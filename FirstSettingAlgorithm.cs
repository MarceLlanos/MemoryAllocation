using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class FirstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        

        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            IVacatePackages vacatePackages = new VacatePackages();

            if (vacatePackages.VacatedPackages(blocks, package) == null || vacatePackages.VacatedPackages(blocks, package).Count == 0)
            {
                return package;
            }

            foreach (var item in vacatePackages.VacatedPackages(blocks, package))
            {
                return item;
            }

            return null;
        }

        
    }
}
