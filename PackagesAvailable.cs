using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class PackagesAvailable
    {
        public List<IPackage> AvailablePackages(IBlock[] block, IPackage package)
        {
            List<IPackage> packagesAvailable = null;

            foreach (var item1 in block)
            {
                foreach (var item in item1.GetPackages())
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
