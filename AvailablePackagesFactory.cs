using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AvailablePackagesFactory : IPacksFactory
    {

        public void CreatePacks(IPackage package, IBlock block, List<IPackage> packages)
        {

            foreach (var item in block.GetPackages())
            {
                if (item.GetId() == 0 && item.GetSizePackage() >= package.GetSizePackage())
                {
                    packages.Add(item);
                }
            }
        }

    }
}
