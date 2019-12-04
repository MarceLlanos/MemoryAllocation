using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBestAllocation
{
    class WorstPackage : IBestWorstPackage
    {
        IMinimumMaximunPackage maxPackage;

        public IPackage GetPackage(List<IPackage> packages)
        {
            var packageMaxSize = packages[0];

            foreach (var item in packages)
            {
                if (item.GetSizePackage() <= packageMaxSize.GetSizePackage())
                {
                    maxPackage = new MaximumPackage(packageMaxSize, item);
                }

            }

            return packageMaxSize;
        }
    }
}
