using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class AvailablePacks: IPackages
    {
        
        public List<IPackage> GetAvailablePackages(IBlock[] blocks, IPackage package)
        {
            List<IPackage> packagesAvailable = new List<IPackage>();

            foreach (var item1 in blocks)
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

        public List<IPackage> Packages(IBlock[] blocks, IPackage package)
        {
            throw new NotImplementedException();
        }

        private void FillPackages(IPackage package, List<IPackage> packages, IBlock block)
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
