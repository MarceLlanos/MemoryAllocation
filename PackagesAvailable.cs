using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackagesAvailable
    {
        public List<IPackage> AvailablePackages(IBlock[] blocks, IPackage package)
        {
            List<IPackage> packagesAvailable = null;

            foreach (var itemBlock in blocks)
            {
                foreach (var item in itemBlock.GetPackages())
                {
                    if (item.GetId() == 0 && item.GetSizePackage() >= package.GetSizePackage())
                    {
                        packagesAvailable.Add(item);
                    }
                }
            }

            return packagesAvailable;
        }
    }
}
