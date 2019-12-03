using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstSettingAlgorithm : IAllocationMemoryAlgorithm
    {
        public IPackage FindPackage(IBlock[] blocks, IPackage package)
        {
            var availablePackages = new PackagesAvailable().AvailablePackages(blocks, package);

            if (availablePackages != null)
            {
                return MaximunPackage(availablePackages);
            }

            return null;
        }

        private IPackage MaximunPackage(List<IPackage> packages)
        {
            var packageMinSize = packages[0];

            foreach (var item in packages)
            {
                if (item.GetSizePackage() > packageMinSize.GetSizePackage())
                {
                    packageMinSize = item;
                }

            }

            return packageMinSize;
        }
    }
}
