using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class BestPackage : IBestWorstPackage
    {
        IMinimumMaximunPackage minPackage;
        public IPackage GetPackage(List<IPackage> packages)
        {
            var packageMinSize = packages[0];

            foreach (var item in packages)
            {
                if (item.GetSizePackage() <= packageMinSize.GetSizePackage())
                {
                    minPackage = new MinimumPackage(packageMinSize, item);
                }

            }

            return packageMinSize;
        }
    }
}
